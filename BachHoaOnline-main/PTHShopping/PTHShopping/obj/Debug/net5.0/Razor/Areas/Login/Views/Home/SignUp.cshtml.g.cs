#pragma checksum "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eccca73ff59568aa85ee512025a94f0aca30599"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Login_Views_Home_SignUp), @"mvc.1.0.view", @"/Areas/Login/Views/Home/SignUp.cshtml")]
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
#line 1 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\_ViewImports.cshtml"
using PTHShopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\_ViewImports.cshtml"
using PTHShopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eccca73ff59568aa85ee512025a94f0aca30599", @"/Areas/Login/Views/Home/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98bc40aeb7f02c4ad2dfab2f91ee5096ea0c5ddb", @"/Areas/Login/Views/_ViewImports.cshtml")]
    public class Areas_Login_Views_Home_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PTHShopping.Models.KhachHang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/SignUpassets/fonts/material-design-iconic-font/css/material-design-iconic-font.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/SignUpassets/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignUp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
  
        ViewData["Title"] = "SignUp";
        Layout = "~/Areas/Login/Views/Shared/_LoginLayout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eccca73ff59568aa85ee512025a94f0aca305996836", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>RegistrationForm_v1 by Colorlib</title>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n\r\n    <!-- MATERIAL DESIGN ICONIC FONT -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9eccca73ff59568aa85ee512025a94f0aca305997314", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <!-- STYLE CSS -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9eccca73ff59568aa85ee512025a94f0aca305998523", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <style>\r\n        *:not(i) {\r\n        font-family: \'Segoe UI\', Tahoma, Geneva, Verdana, sans-serif !important;\r\n    }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eccca73ff59568aa85ee512025a94f0aca3059910558", async() => {
                WriteLiteral(@"

    <div class=""wrapper"" style=""background-image: url('https://www.cslbc.com/wp-content/uploads/2016/02/montreal-city-scape-background.jpg') "">
        <div class=""inner"">
            <div class=""image-holder"">
                <img src=""https://cf.shopee.vn/file/1c7e50cb841be71947a49d07333c11cd""");
                BeginWriteAttribute("alt", " alt=\"", 1062, "\"", 1068, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"height:100%\">\r\n            </div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eccca73ff59568aa85ee512025a94f0aca3059911338", async() => {
                    WriteLiteral("\r\n                <h3>????ng k?? t??i kho???n</h3>\r\n\r\n                <div class=\"form-wrapper\">\r\n                    <input name=\"HoTen\" type=\"text\" placeholder=\"H??? t??n *\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 1351, "\"", 1371, 1);
#nullable restore
#line 37 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
WriteAttributeValue("", 1359, ViewBag.ten, 1359, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                </div>\r\n");
#nullable restore
#line 39 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
                 if (ViewBag.name != null)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <div class=\"text-danger\">H??? t??n ch??a ???????c ??i???n</div>\r\n");
#nullable restore
#line 42 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                <div class=\"form-wrapper\">\r\n                    <input type=\"text\" name=\"Sdt\" placeholder=\"S??? ??i???n tho???i *\" class=\"form-control\" id=\"sdt\"");
                    BeginWriteAttribute("value", " value=\"", 1710, "\"", 1732, 1);
#nullable restore
#line 45 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
WriteAttributeValue("", 1718, ViewBag.phone, 1718, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" maxlength=\"11\">\r\n                    <i class=\"zmdi zmdi-phone\"></i>\r\n                </div>\r\n");
#nullable restore
#line 48 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
                 if (ViewBag.sdtTrung != null)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <div class=\"text-danger\">S??? ??i???n tho???i ???? ???????c s??? d???ng</div>\r\n");
#nullable restore
#line 51 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
                 if (ViewBag.sdt != null)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <div class=\"text-danger\">S??? ??i???n tho???i ch??a ???????c ??i???n</div>\r\n");
#nullable restore
#line 55 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                <div class=\"form-wrapper\">\r\n                    <input name=\"mail\" type=\"text\" placeholder=\"Email\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 2293, "\"", 2314, 1);
#nullable restore
#line 57 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
WriteAttributeValue("", 2301, ViewBag.mail, 2301, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                    <i class=\"zmdi zmdi-email\"></i>\r\n                </div>\r\n                <div class=\"form-wrapper\">\r\n                    <select name=\"gioitinh\"");
                    BeginWriteAttribute("id", " id=\"", 2482, "\"", 2487, 0);
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 2509, "\"", 2534, 1);
#nullable restore
#line 61 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
WriteAttributeValue("", 2517, ViewBag.gioitinh, 2517, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eccca73ff59568aa85ee512025a94f0aca3059915996", async() => {
                        WriteLiteral("Gi???i t??nh");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eccca73ff59568aa85ee512025a94f0aca3059917981", async() => {
                        WriteLiteral("Nam");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eccca73ff59568aa85ee512025a94f0aca3059919290", async() => {
                        WriteLiteral("N???");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"

                    </select>
                    <i class=""zmdi zmdi-caret-down"" style=""font-size: 17px""></i>
                </div>
                <div class=""form-wrapper"">
                    <input name=""pass1"" type=""password"" placeholder=""M???t kh???u *"" class=""form-control"" id=""pass1"">
                    <i class=""zmdi zmdi-lock""></i>
                </div>
                <div class=""form-wrapper"">
                    <input name=""pass2"" type=""password"" placeholder=""Nh???p l???i m???t kh???u *"" class=""form-control"" id=""pass2"">
                    <i class=""zmdi zmdi-lock""></i>
                </div>
");
#nullable restore
#line 77 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
                 if (ViewBag.passN != null)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <div class=\"text-danger\">M???t kh???u ch??a ???????c ??i???n</div>\r\n");
#nullable restore
#line 80 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
                 if (ViewBag.pass != null)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <div class=\"text-danger\">Nh???p l???i m???t kh???u ch??a ????ng</div>\r\n");
#nullable restore
#line 84 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\SignUp.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                <button id=\"click\">\r\n                    Register\r\n                    <i class=\"zmdi zmdi-arrow-right\"></i>\r\n                </button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<!-- This templates was made by Colorlib (https://colorlib.com) -->\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PTHShopping.Models.KhachHang> Html { get; private set; }
    }
}
#pragma warning restore 1591
