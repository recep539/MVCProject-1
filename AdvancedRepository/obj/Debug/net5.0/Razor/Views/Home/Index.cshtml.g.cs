#pragma checksum "D:\C#örnek programlar\MVCProject-1\AdvancedRepository\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "563ab4daf0cdeba1f0457f76c1c45e66e544bd5f"
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
#line 1 "D:\C#örnek programlar\MVCProject-1\AdvancedRepository\Views\_ViewImports.cshtml"
using AdvancedRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#örnek programlar\MVCProject-1\AdvancedRepository\Views\_ViewImports.cshtml"
using AdvancedRepository.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"563ab4daf0cdeba1f0457f76c1c45e66e544bd5f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5375d1ec7ee915ddf63588b5726041bff0309f1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\C#örnek programlar\MVCProject-1\AdvancedRepository\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 7 "D:\C#örnek programlar\MVCProject-1\AdvancedRepository\Views\Home\Index.cshtml"
     if (ViewBag.UserName != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"display-4\">\r\n            Welcome ");
#nullable restore
#line 10 "D:\C#örnek programlar\MVCProject-1\AdvancedRepository\Views\Home\Index.cshtml"
               Write(ViewBag.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n");
#nullable restore
#line 12 "D:\C#örnek programlar\MVCProject-1\AdvancedRepository\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>RECEP CAN BOYACI</h1>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
