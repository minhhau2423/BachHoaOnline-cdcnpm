#pragma checksum "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a68b1a4fe2082282d6589f126d82e12de4e5227"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Login_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Login/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
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
#nullable restore
#line 2 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\Index.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a68b1a4fe2082282d6589f126d82e12de4e5227", @"/Areas/Login/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98bc40aeb7f02c4ad2dfab2f91ee5096ea0c5ddb", @"/Areas/Login/Views/_ViewImports.cshtml")]
    public class Areas_Login_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Login/Views/Shared/_LoginLayout.cshtml";



#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"login-block\">\r\n    <div class=\"container login-container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4 login-sec pl-5\">\r\n                <h2 class=\"text-center\">Wellcome</h2>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a68b1a4fe2082282d6589f126d82e12de4e52274977", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label>S??? ??i???n tho???i</label>\r\n                        <input type=\"text\" class=\"form-control\" placeholder=\"Nh???p s??? ??i???n tho???i c???a b???n\" name=\"sdt\"");
                BeginWriteAttribute("value", " value=\"", 627, "\"", 647, 1);
#nullable restore
#line 17 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\Index.cshtml"
WriteAttributeValue("", 635, ViewBag.sdt, 635, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" maxlength=""11"">

                    </div>
                    <div class=""form-group"">
                        <label>M???t kh???u</label>
                        <input type=""password"" class=""form-control"" placeholder=""Nh???p m???t kh???u c???a b???n"" name=""Password"">
                    </div>
");
#nullable restore
#line 24 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\Index.cshtml"
                     if (ViewBag.notFound != null)
                    {
                        if (ViewBag.notFound == "0")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"text-danger\">S??? ??i???n tho???i v?? m???t kh???u kh??ng ???????c tr???ng!</div>\r\n");
#nullable restore
#line 29 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\Index.cshtml"
                        }
                        if (ViewBag.notFound == "1")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"text-danger\">S??? ??i???n tho???i ho???c m???t kh???u kh??ng ????ng!</div>\r\n");
#nullable restore
#line 33 "E:\BachHoaOnline\BachHoaOnline\PTHShopping\PTHShopping\Areas\Login\Views\Home\Index.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <div class=""form-check"">
                        <input type=""checkbox"" class=""form-check-input"" id=""exampleCheck1"">
                        <label class=""form-check-label"">
                            <small>Nh??? m???t kh???u<a href=""#"" style=""float:right;"">Qu??n m???t kh???u</a></small>
                        </label>

                        <button type=""submit"" class=""btn btn-login float-right"">????ng nh???p</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""copy-text""><i class=""fa fa-heart""></i><a href=""Login/Home/SignUp""> ????ng k?? ngay</a></div>
            </div>
            <div class=""col-md-8 banner-sec"">
                <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                    <ol class=""carousel-indicators"">
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                    </ol>
                    <div class=""carousel-inner"" role=""listbox"">
                        <div class=""carousel-item active"">
                            <img class=""d-block img-slide"" src=""https://vnn-imgs-f.vgcloud.vn/2020/09/24/18/tranh-cai-an-hoa-qua-truoc-hay-sau-bua-an-da-co-cau-tra-loi.jpg"" alt=""First slide"">
                            <div class=""ca");
            WriteLiteral(@"rousel-caption d-none d-md-block"">
                                <div class=""banner-text"">
                                    <h2>This is Heaven</h2>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation</p>
                                </div>
                            </div>
                        </div>
                        <div class=""carousel-item"">
                            <img class=""d-block img-slide"" src=""https://icdn.dantri.com.vn/thumb_w/640/2018/do-hop-1515983456164.jpeg"" alt=""First slide"">
                            <div class=""carousel-caption d-none d-md-block"">
                                <div class=""banner-text"">
                                    <h2>This is Heaven</h2>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut lab");
            WriteLiteral(@"ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation</p>
                                </div>
                            </div>
                        </div>
                        <div class=""carousel-item"">
                            <img class=""d-block img-slide"" src=""https://cdn.tgdd.vn/2021/04/content/xred-meat-vs-white-meat.jpg.pagespeed.ic.FDaubWNNo--800x533.jpg"" alt=""First slide"">
                            <div class=""carousel-caption d-none d-md-block"">
                                <div class=""banner-text"">
                                    <h2>This is Heaven</h2>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation</p>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </d");
            WriteLiteral("iv>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
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
