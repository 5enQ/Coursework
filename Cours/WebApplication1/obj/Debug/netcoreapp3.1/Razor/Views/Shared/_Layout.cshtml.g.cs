#pragma checksum "C:\Users\kulae\OneDrive\Рабочий стол\Coursework\Cours\WebApplication1\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d6b2959471c97a81ad8d909ec4f1ccd5dd74b40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\kulae\OneDrive\Рабочий стол\Coursework\Cours\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kulae\OneDrive\Рабочий стол\Coursework\Cours\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kulae\OneDrive\Рабочий стол\Coursework\Cours\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d6b2959471c97a81ad8d909ec4f1ccd5dd74b40", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9303d0325d3bbfd5d8dcb3d92689316bb80bc7cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("is-preload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d6b2959471c97a81ad8d909ec4f1ccd5dd74b403886", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 4 "C:\Users\kulae\OneDrive\Рабочий стол\Coursework\Cours\WebApplication1\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("MetatagsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 6 "C:\Users\kulae\OneDrive\Рабочий стол\Coursework\Cours\WebApplication1\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("CssPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d6b2959471c97a81ad8d909ec4f1ccd5dd74b405401", async() => {
                WriteLiteral("\r\n    <!-- Wrapper -->\r\n    <div id=\"wrapper\">\r\n\r\n        ");
#nullable restore
#line 14 "C:\Users\kulae\OneDrive\Рабочий стол\Coursework\Cours\WebApplication1\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("HeaderPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <!-- Menu -->
        <nav id=""menu"">
            <h2>Menu</h2>
            <ul>
                <li><a href=""index.html"">Home</a></li>
                <li><a href=""generic.html"">Ipsum veroeros</a></li>
                <li><a href=""generic.html"">Tempus etiam</a></li>
                <li><a href=""generic.html"">Consequat dolor</a></li>
                <li><a href=""elements.html"">Elements</a></li>
            </ul>
        </nav>

        <!-- Main -->
        <div id=""main""> 
            <div class=""inner"">
");
                WriteLiteral("\r\n                ");
#nullable restore
#line 39 "C:\Users\kulae\OneDrive\Рабочий стол\Coursework\Cours\WebApplication1\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        ");
#nullable restore
#line 179 "C:\Users\kulae\OneDrive\Рабочий стол\Coursework\Cours\WebApplication1\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("FooterPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    ");
#nullable restore
#line 181 "C:\Users\kulae\OneDrive\Рабочий стол\Coursework\Cours\WebApplication1\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("ScriptsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
