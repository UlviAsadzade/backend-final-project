#pragma checksum "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0762d8e40b160d85c8b611c64afc1adc80e7586c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0762d8e40b160d85c8b611c64afc1adc80e7586c", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6164c15bcf79cae31e3ee8a11675ec071c85592a", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Team\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        <div class=""ltn__utilize-overlay""></div>

        <!-- BREADCRUMB AREA START -->
        <div class=""ltn__breadcrumb-area text-left bg-overlay-white-30 bg-image "" data-bs-bg=""~/assets/img/bg/14.jpg"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""ltn__breadcrumb-inner"">
                            <h1 class=""page-title"">Our Agent</h1>
                            <div class=""ltn__breadcrumb-list"">
                                <ul>
                                    <li><a href=""index.html""><span class=""ltn__secondary-color""><i class=""fas fa-home""></i></span> Home</a></li>
                                    <li>Agent</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- BREADCRUMB AREA END -->

        <!-- TEAM AREA START");
            WriteLiteral(" (Team - 3) -->\r\n        <div class=\"ltn__team-area pt-110--- pb-90\">\r\n            <div class=\"container\">\r\n                <div class=\"row justify-content-center\">\r\n");
#nullable restore
#line 33 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Team\Index.cshtml"
                     foreach (var item in Model.Teams)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 col-sm-6\">\r\n                            <div class=\"ltn__team-item ltn__team-item-3---\">\r\n                                <div class=\"team-img\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0762d8e40b160d85c8b611c64afc1adc80e7586c6032", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1569, "~/uploads/team/", 1569, 15, true);
#nullable restore
#line 38 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Team\Index.cshtml"
AddHtmlAttributeValue("", 1584, item.Image, 1584, 11, false);

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
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"team-info\">\r\n                                    <h4><a href=\"team-details.html\">");
#nullable restore
#line 41 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Team\Index.cshtml"
                                                               Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h4>
                                    <h6 class=""ltn__secondary-color"">Sale Manager</h6>
                                    <div class=""ltn__social-media"">
                                        <ul>
                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2054, "\"", 2078, 1);
#nullable restore
#line 45 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Team\Index.cshtml"
WriteAttributeValue("", 2061, item.FacebookUrl, 2061, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 2082, "\"", 2118, 1);
#nullable restore
#line 45 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Team\Index.cshtml"
WriteAttributeValue("", 2090, Model.Settings.FacebookIcon, 2090, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2185, "\"", 2208, 1);
#nullable restore
#line 46 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Team\Index.cshtml"
WriteAttributeValue("", 2192, item.TwitterUrl, 2192, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 2212, "\"", 2247, 1);
#nullable restore
#line 46 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Team\Index.cshtml"
WriteAttributeValue("", 2220, Model.Settings.TwitterIcon, 2220, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2314, "\"", 2338, 1);
#nullable restore
#line 47 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Team\Index.cshtml"
WriteAttributeValue("", 2321, item.LinkedinUrl, 2321, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 2342, "\"", 2378, 1);
#nullable restore
#line 47 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Team\Index.cshtml"
WriteAttributeValue("", 2350, Model.Settings.LinkedinIcon, 2350, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2445, "\"", 2468, 1);
#nullable restore
#line 48 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Team\Index.cshtml"
WriteAttributeValue("", 2452, item.YoutubeUrl, 2452, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 2472, "\"", 2507, 1);
#nullable restore
#line 48 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Team\Index.cshtml"
WriteAttributeValue("", 2480, Model.Settings.YoutubeIcon, 2480, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n                                        </ul>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 54 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Views\Team\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- TEAM AREA END -->\r\n   \r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
