#pragma checksum "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminCategories\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0886063cdd2f0abf89b8ff510d4e5863127c2589"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminCategories_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminCategories/Details.cshtml")]
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
#line 1 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\_ViewImports.cshtml"
using PTHShopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\_ViewImports.cshtml"
using PTHShopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0886063cdd2f0abf89b8ff510d4e5863127c2589", @"/Areas/Admin/Views/AdminCategories/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81781e9eafab353c8c8571f297611c0fb50fbd73", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminCategories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PTHShopping.Models.Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminCategories\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .avt {\r\n        max-width: 500px;\r\n        max-height: 400px;\r\n    }\r\n</style>\r\n<h5 class=\"text-info\">Chi tiết danh mục - ");
#nullable restore
#line 13 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminCategories\Details.cshtml"
                                     Write(Html.DisplayFor(model => model.CatName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 13 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminCategories\Details.cshtml"
                                                                               Write(Html.DisplayFor(model => model.CatId));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n\r\n<div>\r\n    <hr />\r\n    <table");
            BeginWriteAttribute("class", " class=\"", 399, "\"", 407, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <tr>\r\n            <td class=\"col-6\" valign=\"top\">\r\n                <img class=\"avt card shadow-lg\" id=\"thumd\"");
            BeginWriteAttribute("src", " src=\"", 528, "\"", 547, 2);
            WriteAttributeValue("", 534, "/", 534, 1, true);
#nullable restore
#line 20 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminCategories\Details.cshtml"
WriteAttributeValue("", 535, Model.Thumb, 535, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n            <td class=\"col-6 rounded bg-light shadow-lg\">\r\n                <span class=\"font-weight-bold\"> Mã: </span> ");
#nullable restore
#line 23 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminCategories\Details.cshtml"
                                                       Write(Html.DisplayFor(model => model.CatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <hr />\r\n                <span class=\"font-weight-bold\"> Danh mục: </span> ");
#nullable restore
#line 26 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminCategories\Details.cshtml"
                                                             Write(Html.DisplayFor(model => model.CatName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <hr />\r\n                <span class=\"font-weight-bold\"> Mô tả: </span> ");
#nullable restore
#line 29 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminCategories\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <hr />\r\n\r\n                <span class=\"font-weight-bold\"> Published: </span> ");
#nullable restore
#line 33 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminCategories\Details.cshtml"
                                                              Write(Html.DisplayFor(model => model.Published));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <hr />\r\n\r\n                <span class=\"font-weight-bold\"> Ký hiệu: </span> ");
#nullable restore
#line 37 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminCategories\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.KyHieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0886063cdd2f0abf89b8ff510d4e5863127c25897992", async() => {
                WriteLiteral("&lt; Trở lại");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0886063cdd2f0abf89b8ff510d4e5863127c25899159", async() => {
                WriteLiteral("Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminCategories\Details.cshtml"
                           WriteLiteral(Model.CatId);

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
            WriteLiteral(" \r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PTHShopping.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591