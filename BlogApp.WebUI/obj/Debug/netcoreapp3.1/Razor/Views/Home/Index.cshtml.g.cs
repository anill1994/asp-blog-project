#pragma checksum "C:\Users\anil_\OneDrive\Masaüstü\filmolok\BlogApp.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c42bcd4cc2de31473ce31c955159d9a9604bcb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\anil_\OneDrive\Masaüstü\filmolok\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.WebUI.Models;

#line default
#line hidden
#line 2 "C:\Users\anil_\OneDrive\Masaüstü\filmolok\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.Entity;

#line default
#line hidden
#line 3 "C:\Users\anil_\OneDrive\Masaüstü\filmolok\BlogApp.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c42bcd4cc2de31473ce31c955159d9a9604bcb2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde1a6e346d300d03327b0a5ab65382bbac7d21d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeBlogModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\anil_\OneDrive\Masaüstü\filmolok\BlogApp.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(63, 94, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(158, 43, false);
#line 9 "C:\Users\anil_\OneDrive\Masaüstü\filmolok\BlogApp.WebUI\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(201, 62, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            ");
            EndContext();
            BeginContext(264, 41, false);
#line 12 "C:\Users\anil_\OneDrive\Masaüstü\filmolok\BlogApp.WebUI\Views\Home\Index.cshtml"
       Write(Html.Partial("_Slider",Model.SliderBlogs));

#line default
#line hidden
            EndContext();
            BeginContext(305, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(320, 42, false);
#line 13 "C:\Users\anil_\OneDrive\Masaüstü\filmolok\BlogApp.WebUI\Views\Home\Index.cshtml"
       Write(Html.Partial("_BlogList", Model.HomeBlogs));

#line default
#line hidden
            EndContext();
            BeginContext(362, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeBlogModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
