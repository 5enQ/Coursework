using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyCompany.Domain;
using MyCompany.Domain.Repositories.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domain;
using WebApplication1.Domain.Repositories.Abstract;
using WebApplication1.Service;

namespace WebApplication1
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;

        /*public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        This method gets called by the runtime. Use this method to add services to the container.*/
        public void ConfigureServices(IServiceCollection services)
        {
            //���������� ������ �� appsettings.json
            Configuration.Bind("Project", new Config());

            //���������� ������ ���������� ���������� � �������� ��������
            services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
            services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
            services.AddTransient<DataManager>();

            //���������� �������� ��
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

            //����������� identity �������
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //����������� authentication cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "myCompanyAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });

            //��������� ������� ��� ������������ � ������������� (MVC)
            services.AddControllersWithViews()
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /*public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //��������� ��� ���������� �������� ������ ���������� �� �������
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
                
            app.UseRouting();
                //���������� ��������� ��������� ������ � ����������
            app.UseAuthorization();
                //������������ ������ ���������
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }*/

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //!!! ������� ����������� middleware ����� �����

            //� �������� ���������� ��� ����� ������ ����� ������ ������
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            //���������� ��������� ��������� ������ � ���������� (css, js � �.�.)
            app.UseStaticFiles();

            //���������� ������� �������������
            app.UseRouting();

            //���������� �������������� � �����������
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            //������������� ������ ��� �������� (���������)
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
