#pragma checksum "/murach/aspnet_core_mvc/FAQ/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5f8748f28af0b9e4cb168173ea685060997a60b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/murach/aspnet_core_mvc/FAQ/Views/_ViewImports.cshtml"
using FAQ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/murach/aspnet_core_mvc/FAQ/Views/_ViewImports.cshtml"
using FAQ.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f8748f28af0b9e4cb168173ea685060997a60b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30098c286f7bd125548f6093f276470e306cf333", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Question>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/murach/aspnet_core_mvc/FAQ/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"allQuestionsContainer\">\n");
#nullable restore
#line 8 "/murach/aspnet_core_mvc/FAQ/Views/Home/Index.cshtml"
     foreach (var question in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"questionContainer\">\n            <p>\n                <span class=\"ask\">");
#nullable restore
#line 12 "/murach/aspnet_core_mvc/FAQ/Views/Home/Index.cshtml"
                             Write(question.Ask);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"answer\">");
#nullable restore
#line 12 "/murach/aspnet_core_mvc/FAQ/Views/Home/Index.cshtml"
                                                                       Write(question.Answer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            </p>\n            <p>\n                <span class=\"topic\">Topic: ");
#nullable restore
#line 15 "/murach/aspnet_core_mvc/FAQ/Views/Home/Index.cshtml"
                                      Write(question.Topic.TopicName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                <span class=\"category\">Category: ");
#nullable restore
#line 16 "/murach/aspnet_core_mvc/FAQ/Views/Home/Index.cshtml"
                                            Write(question.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            </p>\n        </div>\n");
#nullable restore
#line 19 "/murach/aspnet_core_mvc/FAQ/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591
