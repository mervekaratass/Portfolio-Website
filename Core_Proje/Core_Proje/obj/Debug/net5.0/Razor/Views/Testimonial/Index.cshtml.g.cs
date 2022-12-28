#pragma checksum "D:\vscode2019\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc8bf72d33985816dc959ae09f7e9844fee3676d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Testimonial_Index), @"mvc.1.0.view", @"/Views/Testimonial/Index.cshtml")]
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
#line 1 "D:\vscode2019\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc8bf72d33985816dc959ae09f7e9844fee3676d", @"/Views/Testimonial/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Testimonial_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\vscode2019\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Referans Listesi</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th> Ad Soyad </th>
                                <th> Şirket </th>
                                <th> Unvan </th>
                                <th> Sil </th>
                                <th> Detaylar </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 26 "D:\vscode2019\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1110, "\"", 1130, 1);
#nullable restore
#line 30 "D:\vscode2019\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 1116, item.ImageUrl, 1116, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" />\r\n                                    </td>\r\n                                    <td> ");
#nullable restore
#line 32 "D:\vscode2019\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
                                    Write(item.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> ");
#nullable restore
#line 33 "D:\vscode2019\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
                                    Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> ");
#nullable restore
#line 34 "D:\vscode2019\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td> <a");
            BeginWriteAttribute("href", " href=\"", 1420, "\"", 1477, 2);
            WriteAttributeValue("", 1427, "/Testimonial/DeleteTestimonial/", 1427, 31, true);
#nullable restore
#line 35 "D:\vscode2019\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 1458, item.TestimonialID, 1458, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a> </td>\r\n                                    <td> <a");
            BeginWriteAttribute("href", " href=\"", 1568, "\"", 1623, 2);
            WriteAttributeValue("", 1575, "/Testimonial/EditTestimonial/", 1575, 29, true);
#nullable restore
#line 36 "D:\vscode2019\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 1604, item.TestimonialID, 1604, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Detaylar</a> </td>\r\n                                </tr>\r\n");
#nullable restore
#line 38 "D:\vscode2019\Core_Proje\Core_Proje\Views\Testimonial\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                    <br />
                    <a href=""/Testimonial/AddTestimonial/"" class=""btn btn-outline-info"">Yeni Referans Ekle</a>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; }
    }
}
#pragma warning restore 1591