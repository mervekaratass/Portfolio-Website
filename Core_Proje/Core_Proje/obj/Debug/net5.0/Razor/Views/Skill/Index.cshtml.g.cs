#pragma checksum "D:\vscode2019\Core_Proje\Core_Proje\Views\Skill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f45b3e41b284757a4884140347405b0128f54b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "D:\vscode2019\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f45b3e41b284757a4884140347405b0128f54b7", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\vscode2019\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yetenekler</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead ");
            WriteLiteral(@">
                        <tr>
                            <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                            <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                            <th scope=""col"" class=""sort"" data-sort=""status"">Oran</th>
                            <th scope=""col"">Sil</th>
                            <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "D:\vscode2019\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
#line 29 "D:\vscode2019\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                           Write(item.SkillID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <td class=\"budget\">\r\n                                ");
#nullable restore
#line 32 "D:\vscode2019\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"d-flex align-items-center\">\r\n                                    <span class=\"completion mr-2\">");
#nullable restore
#line 36 "D:\vscode2019\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                                                             Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                    <div>\r\n                                        <div class=\"progress\">\r\n                                            <div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 1726, "\"", 1752, 3);
            WriteAttributeValue("", 1734, "width:", 1734, 6, true);
#nullable restore
#line 39 "D:\vscode2019\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1740, item.Value, 1740, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1751, "%", 1751, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1753, "\"", 1780, 1);
#nullable restore
#line 39 "D:\vscode2019\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1769, item.Value, 1769, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2029, "\"", 2068, 2);
            WriteAttributeValue("", 2036, "/Skill/DeleteSkill/", 2036, 19, true);
#nullable restore
#line 44 "D:\vscode2019\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 2055, item.SkillID, 2055, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2149, "\"", 2186, 2);
            WriteAttributeValue("", 2156, "/Skill/EditSkill/", 2156, 17, true);
#nullable restore
#line 45 "D:\vscode2019\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 2173, item.SkillID, 2173, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Düzenle</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 47 "D:\vscode2019\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <br />\r\n                <a href=\"/Skill/AddSkill\" class=\"btn btn-outline-primary\">Yeni Yetenek Ekle</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; }
    }
}
#pragma warning restore 1591