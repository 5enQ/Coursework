#pragma checksum "C:\Users\kulae\OneDrive\Рабочий стол\Coursework\Cours\WebApplication1\Views\Shared\HeaderParial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b166953d15ef20212414d756ae6119c13ff8334"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_HeaderParial), @"mvc.1.0.view", @"/Views/Shared/HeaderParial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b166953d15ef20212414d756ae6119c13ff8334", @"/Views/Shared/HeaderParial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeef3e39f65522a3584f19682a527f82bf4c963c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_HeaderParial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<header id=\"header\">\r\n    <div class=\"inner\">\r\n\r\n        <!-- Logo -->\r\n        <a href=\"index.html\" class=\"logo\">\r\n            <span class=\"symbol\"><img src=\"images/logo.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 175, "\"", 181, 0);
            EndWriteAttribute();
            WriteLiteral(" /></span><span class=\"title\">Phantom</span>\r\n        </a>\r\n\r\n        <!-- Nav -->\r\n        <nav>\r\n            <ul>\r\n                <li><a href=\"#menu\">Menu</a></li>\r\n            </ul>\r\n        </nav>\r\n\r\n    </div>\r\n</header>");
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