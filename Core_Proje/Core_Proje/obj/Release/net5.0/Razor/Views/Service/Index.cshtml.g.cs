#pragma checksum "D:\vscode2019\Core_Proje\Core_Proje\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efc7ec6d9cf93c1c2bb462161e122b994a06d6de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 1 "D:\vscode2019\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efc7ec6d9cf93c1c2bb462161e122b994a06d6de", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\vscode2019\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Hizmetler</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                            <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                            <th scope=""col"">Sil</th>
                            <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 23 "D:\vscode2019\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>                            \r\n                            <th>\r\n                                ");
#nullable restore
#line 27 "D:\vscode2019\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
                           Write(item.ServiceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <td class=\"budget\">\r\n                                ");
#nullable restore
#line 30 "D:\vscode2019\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1278, "\"", 1323, 2);
            WriteAttributeValue("", 1285, "/Service/DeleteService/", 1285, 23, true);
#nullable restore
#line 32 "D:\vscode2019\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
WriteAttributeValue("", 1308, item.ServiceID, 1308, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1404, "\"", 1447, 2);
            WriteAttributeValue("", 1411, "/Service/EditService/", 1411, 21, true);
#nullable restore
#line 33 "D:\vscode2019\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
WriteAttributeValue("", 1432, item.ServiceID, 1432, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Düzenle</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 35 "D:\vscode2019\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <br />\r\n                <a href=\"/Service/AddService/\" class=\"btn btn-outline-primary\">Yeni Hizmet Ekle</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591