#pragma checksum "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8728ee5837077f3e1fecde60c3675fe31627a13e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPhams_Details), @"mvc.1.0.view", @"/Views/SanPhams/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SanPhams/Details.cshtml", typeof(AspNetCore.Views_SanPhams_Details))]
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
#line 1 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\_ViewImports.cshtml"
using Cosmetic;

#line default
#line hidden
#line 2 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\_ViewImports.cshtml"
using Cosmetic.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8728ee5837077f3e1fecde60c3675fe31627a13e", @"/Views/SanPhams/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45e46a70e22261359788c4d073dc157268b599e9", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPhams_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cosmetic.Models.SanPham>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(129, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>SanPham</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(251, 41, false);
#line 15 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(292, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(336, 37, false);
#line 18 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayFor(model => model.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(373, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(417, 44, false);
#line 21 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TenAlias));

#line default
#line hidden
            EndContext();
            BeginContext(461, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(505, 40, false);
#line 24 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayFor(model => model.TenAlias));

#line default
#line hidden
            EndContext();
            BeginContext(545, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(589, 40, false);
#line 27 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(629, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(673, 36, false);
#line 30 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(709, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(753, 42, false);
#line 33 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(795, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(839, 38, false);
#line 36 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(877, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(921, 40, false);
#line 39 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(961, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1005, 36, false);
#line 42 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1085, 41, false);
#line 45 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinh2));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1170, 37, false);
#line 48 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hinh2));

#line default
#line hidden
            EndContext();
            BeginContext(1207, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1251, 41, false);
#line 51 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GiaCu));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1336, 37, false);
#line 54 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayFor(model => model.GiaCu));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1417, 52, false);
#line 57 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaLoaiNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1513, 55, false);
#line 60 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaLoaiNavigation.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1612, 51, false);
#line 63 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaNccNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1663, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1707, 53, false);
#line 66 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaNccNavigation.MaNcc));

#line default
#line hidden
            EndContext();
            BeginContext(1760, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1807, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4197ad44a384afa8832820e8fec9721", async() => {
                BeginContext(1855, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 71 "D:\GitHub\CosmeticOrder_Agile\Cosmetic\Cosmetic\Views\SanPhams\Details.cshtml"
                           WriteLiteral(Model.MaSp);

#line default
#line hidden
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
            EndContext();
            BeginContext(1863, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1871, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f446eacd8d472fb6d731d4da4754c5", async() => {
                BeginContext(1893, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1909, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cosmetic.Models.SanPham> Html { get; private set; }
    }
}
#pragma warning restore 1591
