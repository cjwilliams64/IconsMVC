#pragma checksum "C:\Users\Student\git\SideWork\Udemy\MP3\MP3\GameToWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32a0af9b5194939f6a5f2ec445de9270cf6a3eb1"
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
#line 1 "C:\Users\Student\git\SideWork\Udemy\MP3\MP3\GameToWeb\Views\_ViewImports.cshtml"
using GameToWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\git\SideWork\Udemy\MP3\MP3\GameToWeb\Views\_ViewImports.cshtml"
using GameToWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32a0af9b5194939f6a5f2ec445de9270cf6a3eb1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd9c3230583a4617fa18eda1f1727d865d589181", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Icons>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Student\git\SideWork\Udemy\MP3\MP3\GameToWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 29 "C:\Users\Student\git\SideWork\Udemy\MP3\MP3\GameToWeb\Views\Home\Index.cshtml"
     for (int i = 0; i < 16; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"cell\">");
#nullable restore
#line 31 "C:\Users\Student\git\SideWork\Udemy\MP3\MP3\GameToWeb\Views\Home\Index.cshtml"
                      Write(Model.RandomList[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 32 "C:\Users\Student\git\SideWork\Udemy\MP3\MP3\GameToWeb\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Icons> Html { get; private set; }
    }
}
#pragma warning restore 1591