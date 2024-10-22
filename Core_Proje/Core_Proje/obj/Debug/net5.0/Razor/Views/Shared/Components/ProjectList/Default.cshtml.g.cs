#pragma checksum "D:\vscode2019\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdc5f52a4ac45556f97ef645e3d677ce1d1bf405"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjectList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
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
#line 1 "D:\vscode2019\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\vscode2019\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\vscode2019\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdc5f52a4ac45556f97ef645e3d677ce1d1bf405", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProjectList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Proje Listesi</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th> Ana Görsel </th>
                                <th> Proje Adı </th>
                                <th> Url </th>
                                <th> Fiyat </th>
                                <th> Tamamlanma Oranı </th>
                                <th> Durum </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 22 "D:\vscode2019\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                             foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 24 "D:\vscode2019\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.PortfolioID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><img");
            BeginWriteAttribute("src", " src=\"", 1051, "\"", 1071, 1);
#nullable restore
#line 25 "D:\vscode2019\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1057, item.ImageUrl, 1057, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                                <td>");
#nullable restore
#line 26 "D:\vscode2019\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 27 "D:\vscode2019\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.ProjectUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 28 "D:\vscode2019\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>%");
#nullable restore
#line 29 "D:\vscode2019\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1379, "\"", 1428, 2);
            WriteAttributeValue("", 1386, "/Portfolio/EditPortfolio/", 1386, 25, true);
#nullable restore
#line 31 "D:\vscode2019\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1411, item.PortfolioID, 1411, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div class=\"badge badge-outline-success\">Detayları Gör</div></a>\r\n                                </td>\r\n                            </tr>");
#nullable restore
#line 33 "D:\vscode2019\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
