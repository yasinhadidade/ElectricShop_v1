#pragma checksum "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\MinerProductComponent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17845b6f834b8859f266edbd788ddf6819c0f021"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MinerProductComponent), @"mvc.1.0.view", @"/Views/Shared/Components/MinerProductComponent.cshtml")]
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
#line 1 "F:\projects\MyElectricShop\MyElectricShop\Views\_ViewImports.cshtml"
using MyElectricShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\projects\MyElectricShop\MyElectricShop\Views\_ViewImports.cshtml"
using MyElectricShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17845b6f834b8859f266edbd788ddf6819c0f021", @"/Views/Shared/Components/MinerProductComponent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53cc166b53939d635a32dd2feb2e488ffe486903", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MinerProductComponent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataAccessLayer.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductModal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bs-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bs-target", new global::Microsoft.AspNetCore.Html.HtmlString("#productsQuickView"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\MinerProductComponent.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-3 col-sm-6\">\r\n        <div class=\"single-bestsellers-products\">\r\n            <div class=\"bestsellers-products-image\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 247, "\"", 296, 2);
            WriteAttributeValue("", 254, "/product/productsinglepage/", 254, 27, true);
#nullable restore
#line 8 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\MinerProductComponent.cshtml"
WriteAttributeValue("", 281, item.ProductId, 281, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 302, "\"", 337, 3);
            WriteAttributeValue("", 308, "/images/", 308, 8, true);
#nullable restore
#line 8 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\MinerProductComponent.cshtml"
WriteAttributeValue("", 316, item.ProductId, 316, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 333, ".jpg", 333, 4, true);
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\"></a>\r\n                <div class=\"tag\">????????</div>\r\n                <ul class=\"bestsellers-action\">\r\n                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 503, "\"", 552, 2);
            WriteAttributeValue("", 510, "/product/productsinglepage/", 510, 27, true);
#nullable restore
#line 12 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\MinerProductComponent.cshtml"
WriteAttributeValue("", 537, item.ProductId, 537, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"flaticon-shopping-cart\"></i>\r\n                        </a>\r\n                    </li>\r\n");
            WriteLiteral("                    <li>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17845b6f834b8859f266edbd788ddf6819c0f0216803", async() => {
                WriteLiteral("<i class=\"flaticon-view\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\MinerProductComponent.cshtml"
                                                                                WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n\r\n            <div class=\"bestsellers-products-content\">\r\n                <h3>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1243, "\"", 1292, 2);
            WriteAttributeValue("", 1250, "/product/productsinglepage/", 1250, 27, true);
#nullable restore
#line 27 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\MinerProductComponent.cshtml"
WriteAttributeValue("", 1277, item.ProductId, 1277, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\MinerProductComponent.cshtml"
                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                </h3>
                <ul class=""rating"">
                    <li><i class='bx bxs-star'></i></li>
                    <li><i class='bx bxs-star'></i></li>
                    <li><i class='bx bxs-star'></i></li>
                    <li><i class='bx bxs-star'></i></li>
                    <li><i class='bx bxs-star'></i></li>
                </ul>
                <span>");
#nullable restore
#line 36 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\MinerProductComponent.cshtml"
                 Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??????????</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 40 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\MinerProductComponent.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataAccessLayer.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
