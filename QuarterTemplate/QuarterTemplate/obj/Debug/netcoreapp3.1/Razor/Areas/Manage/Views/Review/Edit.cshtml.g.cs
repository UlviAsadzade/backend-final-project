#pragma checksum "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\Review\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00c537c7769cb5624dbe606caa4b708d0f365c50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Review_Edit), @"mvc.1.0.view", @"/Areas/Manage/Views/Review/Edit.cshtml")]
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
#line 1 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\_ViewImports.cshtml"
using QuarterTemplate.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\_ViewImports.cshtml"
using QuarterTemplate.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\_ViewImports.cshtml"
using QuarterTemplate.Areas.Manage.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\_ViewImports.cshtml"
using QuarterTemplate.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c537c7769cb5624dbe606caa4b708d0f365c50", @"/Areas/Manage/Views/Review/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c1e0f3b75e44a9a09f4ebc70e8208dc8b6c0ad5", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Review_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Review>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "accept", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "reject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\Review\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n    <h1>Edit</h1>\r\n    <div class=\"card\" style=\"width: 40%; margin:0 auto;\">\r\n        <div class=\"card-body\">\r\n            <p class=\"card-text\">\r\n                Product Name - ");
#nullable restore
#line 12 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\Review\Edit.cshtml"
                          Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <p class=\"card-text\">\r\n                User Name - ");
#nullable restore
#line 15 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\Review\Edit.cshtml"
                       Write(Model.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <p class=\"card-text\">\r\n                Member Email - ");
#nullable restore
#line 18 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\Review\Edit.cshtml"
                          Write(Model.AppUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <p class=\"card-text\">\r\n                Comment - ");
#nullable restore
#line 21 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\Review\Edit.cshtml"
                     Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n            <p class=\"card-text\">\r\n                Date - ");
#nullable restore
#line 25 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\Review\Edit.cshtml"
                  Write(Model.CreatedAt.AddHours(4).ToString("HH:mm dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n            <p class=\"card-text\">\r\n                Order Status - ");
#nullable restore
#line 29 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\Review\Edit.cshtml"
                          Write(Model.IsAccepted);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c537c7769cb5624dbe606caa4b708d0f365c508153", async() => {
                WriteLiteral("Accept");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\Review\Edit.cshtml"
                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c537c7769cb5624dbe606caa4b708d0f365c5010442", async() => {
                WriteLiteral("Reject");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\lenovo\OneDrive\Masaüstü\backend-final-project\QuarterTemplate\QuarterTemplate\Areas\Manage\Views\Review\Edit.cshtml"
                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Review> Html { get; private set; }
    }
}
#pragma warning restore 1591
