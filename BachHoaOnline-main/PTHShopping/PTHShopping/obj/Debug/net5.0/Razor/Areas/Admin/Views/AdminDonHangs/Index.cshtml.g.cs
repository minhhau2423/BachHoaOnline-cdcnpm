#pragma checksum "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f94e820aa9188a2ddaf86e7b31706eebdaeb56be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminDonHangs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminDonHangs/Index.cshtml")]
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
#nullable restore
#line 1 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94e820aa9188a2ddaf86e7b31706eebdaeb56be", @"/Areas/Admin/Views/AdminDonHangs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81781e9eafab353c8c8571f297611c0fb50fbd73", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminDonHangs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<PTHShopping.Models.DonHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminCtDonHangs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminDonHangs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "anDonHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "hienDonHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
<style>
    th {
        font-weight: bold !important;
        text-align: center;
    }

    td {
        text-align: center !important;
        vertical-align: middle !important;
    }
    .scroll {
        overflow-x: scroll;
        width: 100%;
    }

    td {
        max-width: 200px;
        overflow-x: hidden;
    }
</style>

<h5 class=""text-info"">Danh sách các đơn hàng</h5>

<p>
    <a href=""/Admin/DonHang/1/all"" class=""badge badge-gradient-info""> Tất cả</a>
    <a href=""/Admin/DonHang/1/dagiao"" class=""badge badge-gradient-success""> &#10004; Đã giao</a>
    <a href=""/Admin/DonHang/1/danggiao"" class=""badge badge-gradient-primary"">&#9992; Đang giao</a>
    <a href=""/Admin/DonHang/1/chuagiao"" class=""badge badge-gradient-warning"">&#9888; Chưa giao</a>
    <a href=""/Admin/DonHang/1/dahuy"" class=""badge badge-gradient-danger"">&#10006; Đã hủy</a>
    <a href=""/Admin/DonHang/1/an""");
            WriteLiteral(@" class=""badge badge-gradient-secondary""> <del>Các đơn ẩn</del></a>
</p>
<div class=""scroll"">
    <table class=""table table-hover table-striped"">
        <thead>
            <tr>
                <th>
                    Mã đơn hàng
                </th>
                <th>
                    Ngày đặt
                </th>
                <th>
                    Ngày giao
                </th>

                <th>
                    Khách hàng
                </th>
                <th>
                    Trạng thái
                </th>
                <th>
                    Ghi chú
                </th>
                <th>
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 68 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 72 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IddonHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 75 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NgayDatHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 78 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NgayGiaoHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 81 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdkhachHangNavigation.HoTen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 83 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                     if (item.IdtrangThaiGiaoDichNavigation.TrangThai.Contains("Chưa giao"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-warning\">\r\n                            ");
#nullable restore
#line 86 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdtrangThaiGiaoDichNavigation.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 88 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                     if (item.IdtrangThaiGiaoDichNavigation.TrangThai.Contains("Đang giao"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-primary\">\r\n                            ");
#nullable restore
#line 92 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdtrangThaiGiaoDichNavigation.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 94 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                     if (item.IdtrangThaiGiaoDichNavigation.TrangThai.Contains("Đã giao"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-success\">\r\n                            ");
#nullable restore
#line 98 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdtrangThaiGiaoDichNavigation.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 100 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                     if (item.IdtrangThaiGiaoDichNavigation.TrangThai.Contains("Đã hủy"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-danger\">\r\n                            ");
#nullable restore
#line 104 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdtrangThaiGiaoDichNavigation.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 106 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 108 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f94e820aa9188a2ddaf86e7b31706eebdaeb56be14727", async() => {
                WriteLiteral("Chi tiết đơn hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                                                                                                  WriteLiteral(item.IddonHang);

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
            WriteLiteral(" |\r\n");
#nullable restore
#line 112 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                         if (item.Deleted == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f94e820aa9188a2ddaf86e7b31706eebdaeb56be17704", async() => {
                WriteLiteral(" Ẩn");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                                                                                                                            WriteLiteral(item.IddonHang);

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
            WriteLiteral("\r\n");
#nullable restore
#line 115 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f94e820aa9188a2ddaf86e7b31706eebdaeb56be20778", async() => {
                WriteLiteral(" Hiện");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                                                                                                                               WriteLiteral(item.IddonHang);

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
            WriteLiteral("\r\n");
#nullable restore
#line 119 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 122 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div aria-label=\"Page navigation example\">\r\n    <ul class=\"pagination\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f94e820aa9188a2ddaf86e7b31706eebdaeb56be24189", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
#nullable restore
#line 128 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspArea = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__PagedList_Core_Mvc_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-published", "PagedList.Core.Mvc.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\AdminDonHangs\Index.cshtml"
                                                                                                              WriteLiteral(ViewBag.CurrentFilter);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["published"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-published", __PagedList_Core_Mvc_PagerTagHelper.RouteValues["published"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<PTHShopping.Models.DonHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591