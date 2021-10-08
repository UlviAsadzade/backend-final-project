#pragma checksum "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4a1bdca983f6bc578ecd52d483a3157b7693344"
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
#line 1 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\_ViewImports.cshtml"
using QuarterTemplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\_ViewImports.cshtml"
using QuarterTemplate.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\_ViewImports.cshtml"
using QuarterTemplate.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\_ViewImports.cshtml"
using QuarterTemplate.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4a1bdca983f6bc578ecd52d483a3157b7693344", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6164c15bcf79cae31e3ee8a11675ec071c85592a", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


        <!-- BREADCRUMB AREA START -->
        <div class=""ltn__breadcrumb-area text-left bg-overlay-white-30 bg-image "" data-bs-bg=""img/bg/14.jpg"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""ltn__breadcrumb-inner"">
                            <h1 class=""page-title"">What We Do</h1>
                            <div class=""ltn__breadcrumb-list"">
                                <ul>
                                    <li><a href=""index.html""><span class=""ltn__secondary-color""><i class=""fas fa-home""></i></span> Home</a></li>
                                    <li>Service</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- BREADCRUMB AREA END -->
       
        <!-- SERVICE AREA START (Service 1) -->
        <div class=""ltn__ser");
            WriteLiteral(@"vice-area section-bg-1 pt-115 pb-70"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""section-title-area ltn__section-title-2--- text-center"">
                            <h6 class=""section-subtitle section-subtitle-2 ltn__secondary-color"">Our Services</h6>
                            <h1 class=""section-title"">Our Core Services</h1>
                        </div>
                    </div>
                </div>
                <div class=""row  justify-content-center"">
");
#nullable restore
#line 40 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Service\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-lg-4 col-sm-6 col-12"">
                            <div class=""ltn__feature-item ltn__feature-item-6 text-center bg-white  box-shadow-1"">
                                <div class=""ltn__feature-icon"">
                                    <span><i");
            BeginWriteAttribute("class", " class=\"", 2036, "\"", 2054, 1);
#nullable restore
#line 45 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Service\Index.cshtml"
WriteAttributeValue("", 2044, item.Icon, 2044, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></i></span>
                                    <!-- <img src=""img/icons/icon-img/21.png"" alt=""#""> -->
                                </div>
                                <div class=""ltn__feature-info"">
                                    <h3><a href=""service-details.html"">");
#nullable restore
#line 49 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Service\Index.cshtml"
                                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                    <p>");
#nullable restore
#line 50 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Service\Index.cshtml"
                                  Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <!-- <a class=""ltn__service-btn"" href=""service-details.html"">Find A Home <i class=""flaticon-right-arrow""></i></a> -->
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 55 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Service\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <!-- SERVICE AREA END -->\r\n \r\n\r\n\r\n\r\n");
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
