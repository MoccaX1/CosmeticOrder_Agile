#pragma checksum "/home/moccax1/Documents/WebProJD/Agile/CosmeticOrder_Agile/Cosmetic/Cosmetic/Views/DangNhap/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00b47888d44ba8f28fba27bffd4e0eb72493147b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DangNhap_Index), @"mvc.1.0.view", @"/Views/DangNhap/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DangNhap/Index.cshtml", typeof(AspNetCore.Views_DangNhap_Index))]
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
#line 1 "/home/moccax1/Documents/WebProJD/Agile/CosmeticOrder_Agile/Cosmetic/Cosmetic/Views/_ViewImports.cshtml"
using Cosmetic;

#line default
#line hidden
#line 2 "/home/moccax1/Documents/WebProJD/Agile/CosmeticOrder_Agile/Cosmetic/Cosmetic/Views/_ViewImports.cshtml"
using Cosmetic.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00b47888d44ba8f28fba27bffd4e0eb72493147b", @"/Views/DangNhap/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f98c58fe1896fb78cbba9dc053d8a35efcfe68e", @"/Views/_ViewImports.cshtml")]
    public class Views_DangNhap_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DangNhap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("customer-orders.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/home/moccax1/Documents/WebProJD/Agile/CosmeticOrder_Agile/Cosmetic/Cosmetic/Views/DangNhap/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Frontend.cshtml";

#line default
#line hidden
            BeginContext(87, 1010, true);
            WriteLiteral(@"
<div id=""content"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <!-- breadcrumb-->
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""#"">Trang chủ</a></li>
                        <li aria-current=""page"" class=""breadcrumb-item active"">Đăng nhập</li>
                    </ol>
                </nav>
            </div>
            <div class=""col-lg-6"">
                <div class=""box"">
                    <h1 style=""text-align:center"">Đăng nhập </h1>
                    <p class=""lead"">Bạn đã có tài khoản khách hàng?</p>
                    <p class=""text-muted"">
                        Đăng nhập ngay để mua hàng, theo dõi đơn hàng, lưu
                        danh sách sản phẩm yêu thích, đánh giá cho sản phẩm và nhận
                        thêm nhiều ưu đãi hấp dẫn.
                    </p>
                    <hr>
                    ");
            EndContext();
            BeginContext(1097, 958, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "057080703d4b43f6ba0a2c21682a98c5", async() => {
                BeginContext(1125, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(1150, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81e00eb39e3d403fb4e1ff752a962436", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 30 "/home/moccax1/Documents/WebProJD/Agile/CosmeticOrder_Agile/Cosmetic/Cosmetic/Views/DangNhap/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1210, 728, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label>Tài khoản</label>
                            <input id=""email"" type=""text"" class=""form-control"" required>
                        </div>
                        <div class=""form-group"">
                            <label>Mật khẩu</label>
                            <input id=""password"" type=""password"" class=""form-control"" required>
                        </div>
                        <div class=""text-center"">
                            <button type=""submit"" class=""btn btn-primary""><i class=""fa fa-sign-in""></i> Đăng nhập</button>
                        </div>
                        <div class=""forgot"">
                            ");
                EndContext();
                BeginContext(1938, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67509ddf8cad45c7ac3f5999a9518999", async() => {
                    BeginContext(1978, 14, true);
                    WriteLiteral("Quên mật khẩu?");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1996, 52, true);
                WriteLiteral("\n                        </div>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2055, 603, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""box"">
                    <h1 style=""text-align:center"">Đăng kí</h1>
                    <p class=""lead"">Bạn chưa có tài khoản khách hàng?</p>
                    <p>
                        Tạo tài khoản ngay để mua hàng, theo dõi đơn hàng, lưu
                        danh sách sản phẩm yêu thích, đánh giá cho sản phẩm và nhận thêm
                        nhiều ưu đãi hấp dẫn.
                    </p>
                    <p class=""text-muted"">Nếu bạn gặp khó khăn trong khi tạo tài khoản hãy ");
            EndContext();
            BeginContext(2658, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cf720fc4ad64495a9846627ffcd8d20", async() => {
                BeginContext(2704, 7, true);
                WriteLiteral("Liên hệ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2715, 105, true);
            WriteLiteral(" với chúng tôi. Chúng tôi luôn ở đây để hỗ trợ bạn 24/7</p>\n                    <hr>\n                    ");
            EndContext();
            BeginContext(2820, 972, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ab86b6e82ab411dbf4169cc71e446c3", async() => {
                BeginContext(2870, 915, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""name"">Name</label>
                            <input id=""name"" type=""text"" class=""form-control"" required>
                        </div>
                        <div class=""form-group"">
                            <label for=""email"">Email</label>
                            <input id=""email"" type=""text"" class=""form-control"">
                        </div>
                        <div class=""form-group"">
                            <label for=""password"">Password</label>
                            <input id=""password"" type=""password"" class=""form-control required"">
                        </div>
                        <div class=""text-center"">
                            <button type=""submit"" class=""btn btn-primary""><i class=""fa fa-user-md""></i> Register</button>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3792, 80, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n\n\n\n");
            EndContext();
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
