#pragma checksum "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dd4aa952758b8756e85da0a8abcfd916965cd42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dd4aa952758b8756e85da0a8abcfd916965cd42", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81781e9eafab353c8c8571f297611c0fb50fbd73", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Adminassets/images/dashboard/circle.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-absolute"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("circle-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "del", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    List<MaGiamGium> Mas = ViewBag.magiamgia;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\" id=\"proBanner\">\r\n");
            WriteLiteral(@"</div>
<div class=""page-header"">
    <h3 class=""page-title"">
        <span class=""page-title-icon bg-gradient-primary text-white mr-2"">
            <i class=""mdi mdi-home""></i>
        </span> Tổng quan
    </h3>
    
</div>
<div class=""row"">
    <div class=""col-md-4 stretch-card grid-margin"">
        <div class=""card bg-gradient-danger card-img-holder text-white"">
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1dd4aa952758b8756e85da0a8abcfd916965cd426237", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h4 class=\"font-weight-normal mb-3\">\r\n                    Doanh số trong tháng <i class=\"mdi mdi-chart-line mdi-24px float-right\"></i>\r\n                </h4>\r\n                <h2 class=\"mb-5\">");
#nullable restore
#line 35 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                            Write(ViewBag.danhso);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</h2>\r\n                <h6 class=\"card-text\">Tính đến ");
#nullable restore
#line 36 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                          Write(ViewBag.now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-4 stretch-card grid-margin\">\r\n        <div class=\"card bg-gradient-info card-img-holder text-white\">\r\n            <div class=\"card-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1dd4aa952758b8756e85da0a8abcfd916965cd428489", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h4 class=\"font-weight-normal mb-3\">\r\n                    Đơn hàng trong tháng <i class=\"mdi mdi-bookmark-outline mdi-24px float-right\"></i>\r\n                </h4>\r\n                <h2 class=\"mb-5\">");
#nullable restore
#line 47 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                            Write(ViewBag.sodh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <h6 class=\"card-text\">Tính đến ");
#nullable restore
#line 48 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                          Write(ViewBag.now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-4 stretch-card grid-margin\">\r\n        <div class=\"card bg-gradient-success card-img-holder text-white\">\r\n            <div class=\"card-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1dd4aa952758b8756e85da0a8abcfd916965cd4210744", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h4 class=\"font-weight-normal mb-3\">\r\n                    Số lượng khách hàng <i class=\"mdi mdi-diamond mdi-24px float-right\"></i>\r\n                </h4>\r\n                <h2 class=\"mb-5\">");
#nullable restore
#line 59 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                            Write(ViewBag.SLKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <h6 class=\"card-text\">Tính đến ");
#nullable restore
#line 60 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                          Write(ViewBag.now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">sản phẩm bán chạy</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> Sản phẩm  </th>
                                <th> Loại </th>
                                <th> Tình trạng </th>
                                <th> Số lượng bán </th>
                                <th> Còn lại </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 104 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                             if (ViewBag.sp.Count > 0) {
                                var count = ViewBag.sp.Count > 5 ? 5 : ViewBag.sp.Count;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                 for (int i = 0; i < count; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 4909, "\"", 4936, 2);
            WriteAttributeValue("", 4915, "/", 4915, 1, true);
#nullable restore
#line 110 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 4916, ViewBag.sp[i].Thumb, 4916, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\"> ");
#nullable restore
#line 110 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                                                                                  Write(ViewBag.sp[i].TenSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td> ");
#nullable restore
#line 112 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                        Write(ViewBag.sp[i].Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>\r\n                                            <label class=\"badge badge-gradient-success\">Bán chạy</label>\r\n                                        </td>\r\n                                        <td> ");
#nullable restore
#line 116 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                        Write(ViewBag.sp[i].Slban);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td> ");
#nullable restore
#line 117 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                        Write(ViewBag.sp[i].UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 119 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n");
#nullable restore
#line 133 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
             if (ViewBag.news.Count>=4) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card-body"">
                    <h4 class=""card-title"">Tin tức đăng gần đây</h4>
                    <div class=""d-flex"">
                        <div class=""d-flex align-items-center mr-4 text-muted font-weight-light"">
                            <i class=""mdi mdi-account-outline icon-sm mr-2""></i>
                            <span>Admin shop</span>
                        </div>
                        <div class=""d-flex align-items-center text-muted font-weight-light"">
                            <i class=""mdi mdi-clock icon-sm mr-2""></i>
                            <span>Bài đăng gần nhất ");
#nullable restore
#line 143 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                               Write(ViewBag.news[0].NgayTao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row mt-3\">\r\n                        <div class=\"col-6 pr-1\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 6723, "\"", 6752, 2);
            WriteAttributeValue("", 6729, "/", 6729, 1, true);
#nullable restore
#line 148 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 6730, ViewBag.news[0].Thumb, 6730, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mb-2 mw-100 w-100 rounded\" alt=\"image\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 6834, "\"", 6863, 2);
            WriteAttributeValue("", 6840, "/", 6840, 1, true);
#nullable restore
#line 149 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 6841, ViewBag.news[1].Thumb, 6841, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mw-100 w-100 rounded\" alt=\"image\">\r\n                        </div>\r\n                        <div class=\"col-6 pl-1\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 7022, "\"", 7051, 2);
            WriteAttributeValue("", 7028, "/", 7028, 1, true);
#nullable restore
#line 152 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 7029, ViewBag.news[2].Thumb, 7029, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mb-2 mw-100 w-100 rounded\" alt=\"image\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 7133, "\"", 7162, 2);
            WriteAttributeValue("", 7139, "/", 7139, 1, true);
#nullable restore
#line 153 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 7140, ViewBag.news[3].Thumb, 7140, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mw-100 w-100 rounded\" alt=\"image\">\r\n                        </div>\r\n                    </div>\r\n               \r\n                 </div>\r\n");
#nullable restore
#line 158 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-7 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">khách hàng mới</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> Khách hàng </th>
                                <th> Ngày tạo </th>
                                <th> </th>
                                <th> Đăng nhập gần đây </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 178 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                             if (ViewBag.kh.Count > 0)
                            {
                                var count = ViewBag.kh.Count > 5 ? 5 : ViewBag.kh.Count;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 181 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                 for (int i = 0; i < count; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n");
#nullable restore
#line 185 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                             if (ViewBag.kh[i].Avatar != null && ViewBag.kh[i].Avatar != string.Empty)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <img");
            BeginWriteAttribute("src", " src=\"", 8617, "\"", 8645, 2);
            WriteAttributeValue("", 8623, "/", 8623, 1, true);
#nullable restore
#line 187 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 8624, ViewBag.kh[i].Avatar, 8624, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\"> ");
#nullable restore
#line 187 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                                                                                       Write(ViewBag.kh[i].HoTen);

#line default
#line hidden
#nullable disable
#nullable restore
#line 187 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                                                                                                                
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <img src=\"https://www.iconpacks.net/icons/2/free-user-icon-3297-thumb.png\" class=\"mr-2\" alt=\"image\"> ");
#nullable restore
#line 191 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                                                                                                                                Write(ViewBag.kh[i].HoTen);

#line default
#line hidden
#nullable disable
#nullable restore
#line 191 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                                                                                                                                                         
                                                
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td> ");
#nullable restore
#line 195 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                        Write(ViewBag.kh[i].NgayTao);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>\r\n                                            <label class=\"badge badge-gradient-info\">New</label>\r\n                                        </td>\r\n                                        <td> ");
#nullable restore
#line 199 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                        Write(ViewBag.kh[i].LastLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 201 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 201 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-5 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title text-white"">Todo</h4>
                <p class=""text-warning"">&#9888; Mã giảm giá có dạng: ...xx (xx là số % khuyến mãi) mới được thêm thành công. </p>
                <div class=""add-items d-flex"">
                    <input type=""text"" class=""form-control todo-list-input"" placeholder=""Tạo mã giảm giá - Ví dụ: NOEL30"" id=""ma"" maxlength=""25"">
                    <button type=""submit"" class=""add btn btn-gradient-primary font-weight-bold"" id=""add-task"">Add</button>
                </div>
");
#nullable restore
#line 218 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                 if (Mas.Count > 0)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"list-wrapper\">\r\n                        <ul class=\"d-flex flex-column-reverse todo-list todo-list-custom\">\r\n");
#nullable restore
#line 223 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                             foreach (var item in Mas)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li>
                                    <div class=""form-check"">
                                        <label class=""form-check-label"">
                                            <i class=""mdi mdi-sale text-primary""></i>
                                            ");
#nullable restore
#line 229 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                       Write(item.Magiamgia);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </label>\r\n                                    </div>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dd4aa952758b8756e85da0a8abcfd916965cd4228965", async() => {
                WriteLiteral(" <i class=\"mdi mdi-close-circle-outline\" id=\"del\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ma", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 232 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                                                                                               WriteLiteral(item.Ma);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ma"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ma", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ma"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 234 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 237 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Admin\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@" 
    <script>
        $(document).ready(() => {
            $('#add-task').click(() => {
                var ma = $(""#ma"").val();
                $.ajax({
                    url: '/Admin/Home/magiamgia',
                    datatype: ""json"",
                    type: ""POST"",
                    data: {
                        ma: ma
                    },
                    async: true,
                    success: function (result) {
                        if (result.status == ""success"") {
                            window.location.href = result.redirectUrl;
                        }
                    },
                    error: function (xhr) {
                        alert('error')
                    }
                });
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591