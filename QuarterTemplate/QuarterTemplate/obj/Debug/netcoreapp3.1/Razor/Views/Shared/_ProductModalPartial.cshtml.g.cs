#pragma checksum "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Shared\_ProductModalPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c420a76ad0c3faefb63f9fa6ed79dd69594788b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductModalPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductModalPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c420a76ad0c3faefb63f9fa6ed79dd69594788b0", @"/Views/Shared/_ProductModalPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6164c15bcf79cae31e3ee8a11675ec071c85592a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductModalPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-6 col-12\">\r\n        <div class=\"modal-product-img\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c420a76ad0c3faefb63f9fa6ed79dd69594788b05292", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 135, "~/uploads/product/", 135, 18, true);
#nullable restore
#line 6 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Shared\_ProductModalPartial.cshtml"
AddHtmlAttributeValue("", 153, Model.ProductImages.FirstOrDefault(x=>x.IsPoster==true)?.Image, 153, 63, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-6 col-12\">\r\n        <div class=\"modal-product-info\">\r\n            <div class=\"product-ratting\">\r\n                <ul>\r\n");
            WriteLiteral(@"
                    <li><a href=""#""><i class=""fas fa-star""></i></a></li>
                    <li><a href=""#""><i class=""fas fa-star""></i></a></li>
                    <li><a href=""#""><i class=""fas fa-star""></i></a></li>
                    <li><a href=""#""><i class=""fas fa-star""></i></a></li>
                    <li><a href=""#""><i class=""fas fa-star-half-alt""></i></a></li>
                    <li><a href=""#""><i class=""far fa-star""></i></a></li>
                    <li class=""review-total""> <a href=""#""> ( 95 Reviews )</a></li>
                </ul>
            </div>
            <h3><a href=""product-details.html"">");
#nullable restore
#line 39 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Shared\_ProductModalPartial.cshtml"
                                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n            <div class=\"product-price\">\r\n                <span>$");
#nullable restore
#line 41 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Shared\_ProductModalPartial.cshtml"
                  Write(Model.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <hr>\r\n            <div class=\"modal-product-brief\">\r\n                <p>");
#nullable restore
#line 45 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Shared\_ProductModalPartial.cshtml"
              Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
            <div class=""modal-product-meta ltn__product-details-menu-1 d-none"">
                <ul>
                    <li>
                        <strong>Categories:</strong>
                        <span>
                            <a href=""#"">Parts</a>
                            <a href=""#"">Car</a>
                            <a href=""#"">Seat</a>
                            <a href=""#"">Cover</a>
                        </span>
                    </li>
                </ul>
            </div>
            
            <!-- <hr> -->
            <div class=""ltn__product-details-menu-3"">
                <ul>
                    <li>
                        <a href=""#""");
            BeginWriteAttribute("class", " class=\"", 2337, "\"", 2345, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""Wishlist"" data-bs-toggle=""modal"" data-bs-target=""#liton_wishlist_modal"">
                            <i class=""far fa-heart""></i>
                            <span>Add to Wishlist</span>
                        </a>
                    </li>
                    <li>
                        <a href=""#""");
            BeginWriteAttribute("class", " class=\"", 2662, "\"", 2670, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""Compare"" data-bs-toggle=""modal"" data-bs-target=""#quick_view_modal"">
                            <i class=""fas fa-exchange-alt""></i>
                            <span>Compare</span>
                        </a>
                    </li>
                </ul>
            </div>
            <hr>
            <div class=""ltn__social-media"">
                <ul>
                    <li>Share:</li>
                    <li><a href=""#"" title=""Facebook""><i class=""fab fa-facebook-f""></i></a></li>
                    <li><a href=""#"" title=""Twitter""><i class=""fab fa-twitter""></i></a></li>
                    <li><a href=""#"" title=""Linkedin""><i class=""fab fa-linkedin""></i></a></li>
                    <li><a href=""#"" title=""Instagram""><i class=""fab fa-instagram""></i></a></li>

                </ul>
            </div>
            <label class=""float-end mb-0"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c420a76ad0c3faefb63f9fa6ed79dd69594788b011176", async() => {
                WriteLiteral("<small>View Details</small>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Shared\_ProductModalPartial.cshtml"
                                                                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</label>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591