#pragma checksum "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "024c67840685359c8cf473ea7a04337aef23c508"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
#line 1 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\_ViewImports.cshtml"
using PTHShopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\_ViewImports.cshtml"
using PTHShopping.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"024c67840685359c8cf473ea7a04337aef23c508", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffed51b33a69608cde4de23549a5a67c17c07f58", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PTHShopping.Models.KhachHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
  
    Layout = "~/Views/Shared/_ProfileLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
  
    var idKH = User.Claims.First(c => c.Type == "IdKH").Value.Trim();

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
      
        var test = Model.Where(c => c.IdkhachHang == @idKH);
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
     foreach (var item in test)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table>\r\n            <tr>\r\n                <td width=\"100px;\">\r\n\r\n                </td>\r\n                <td>\r\n                    <img style=\"width: 400px; height: 400px; object-fit: cover; display:inline-block;\"");
            BeginWriteAttribute("src", " src=\"", 561, "\"", 580, 2);
            WriteAttributeValue("", 567, "/", 567, 1, true);
#nullable restore
#line 21 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
WriteAttributeValue("", 568, item.Avatar, 568, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n                <td width=\"50px;\">\r\n                </td>\r\n                <td>\r\n                    <div style=\"font-size:50px;font-weight:bold;\">");
#nullable restore
#line 26 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
                                                             Write(item.HoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><br />\r\n                    <span style=\"font-size:20px;font-weight:bold;\">Giới tính: </span>\r\n");
#nullable restore
#line 28 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
                     if (item.Giotinh == false)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Nữ</span>\r\n");
#nullable restore
#line 31 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Nam</span>\r\n");
#nullable restore
#line 35 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br />\r\n                    <span style=\"font-size:20px;font-weight:bold;\">Sinh nhật: </span> ");
#nullable restore
#line 37 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
                                                                                 Write(item.SinhNhat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    <span style=\"font-size:20px;font-weight:bold;\">Địa chỉ: </span> ");
#nullable restore
#line 38 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
                                                                               Write(item.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    <span style=\"font-size:20px;font-weight:bold;\">Email: </span> ");
#nullable restore
#line 39 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
                                                                             Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    <span style=\"font-size:20px;font-weight:bold;\">Số điện thoại: </span> ");
#nullable restore
#line 40 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
                                                                                     Write(item.Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    <span style=\"font-size:20px;font-weight:bold;\">Ngày tạo: </span>");
#nullable restore
#line 41 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
                                                                               Write(item.NgayTao);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    <div style=\"width:100px; background-color:aquamarine; border: 1px solid black; text-align:center; margin-top:20px;float:right;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "024c67840685359c8cf473ea7a04337aef23c5089131", async() => {
                WriteLiteral("Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
                                                                       WriteLiteral(item.IdkhachHang);

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
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 48 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Views\Profile\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(() => {\r\n            $(\'#trangchu\').removeClass(\'active\');\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PTHShopping.Models.KhachHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591