#pragma checksum "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb3312dbc8d681b1f246fe915250dd75dae46bb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowCart), @"mvc.1.0.view", @"/Views/Product/ShowCart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb3312dbc8d681b1f246fe915250dd75dae46bb8", @"/Views/Product/ShowCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53cc166b53939d635a32dd2feb2e488ffe486903", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccessLayer.Models.Order>
    {
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
#nullable restore
#line 2 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowCart.cshtml"
  
//ViewData["Title"] = "ShowCart";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Start Page Banner -->
<div class=""page-title-area"">
    <div class=""container"">
        <div class=""page-title-content"">
            <h2>?????? ????????</h2>

            <ul>
                <li><a href=""index.html"">???????? ????????</a></li>
                <li>?????? ????????</li>
            </ul>
        </div>
    </div>
</div>
<!-- End Page Banner -->
<!-- Start Cart Area -->
");
#nullable restore
#line 21 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowCart.cshtml"
 if (Model !=null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"cart-area ptb-50\" >\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-9 col-md-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb3312dbc8d681b1f246fe915250dd75dae46bb84214", async() => {
                WriteLiteral(@"
                        <div class=""cart-table table-responsive"">
                            <table class=""table table-hover"">
                                <thead class=""table-primary"">
                                    <tr>
                                        <th scope=""col"">??????????</th>
                                        <th scope=""col"">?????? ????????</th>
                                        <th scope=""col"">???????? ????????</th>
                                        <th scope=""col"">?????????? ????????</th>
                                        <th scope=""col"">??????????</th>
                                    </tr>
                                </thead>

                                <tbody>
");
#nullable restore
#line 41 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowCart.cshtml"
                                     foreach (var item in Model.orderDetails)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td class=\"product-thumbnail\">\r\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 1664, "\"", 1705, 2);
                WriteAttributeValue("", 1671, "/product/RemoveCart/", 1671, 20, true);
#nullable restore
#line 45 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowCart.cshtml"
WriteAttributeValue("", 1691, item.DetailId, 1691, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"remove\"><i class=\'bx bx-x\'></i></a>\r\n\r\n                                            <a href=\"#\">\r\n                                                <img");
                BeginWriteAttribute("src", " src=\"", 1863, "\"", 1906, 3);
                WriteAttributeValue("", 1869, "/images/", 1869, 8, true);
#nullable restore
#line 48 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowCart.cshtml"
WriteAttributeValue("", 1877, item.product.ProductId, 1877, 25, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1902, ".jpg", 1902, 4, true);
                EndWriteAttribute();
                WriteLiteral(@" alt=""item"" style=""max-width:120px"">
                                            </a>
                                        </td>


                                        <td class=""product-name"">
                                            <a href=""products-details.html"">");
#nullable restore
#line 54 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowCart.cshtml"
                                                                       Write(item.product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                        </td>\r\n\r\n                                        <td class=\"product-price\">\r\n                                            <span class=\"unit-amount\">");
#nullable restore
#line 58 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowCart.cshtml"
                                                                 Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                        </td>\r\n\r\n                                        <td class=\"product-quantity\">\r\n                                            <div class=\"input-counter\">\r\n");
                WriteLiteral("                                                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2791, "\"", 2810, 1);
#nullable restore
#line 64 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowCart.cshtml"
WriteAttributeValue("", 2799, item.Count, 2799, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"count\"/>\r\n");
                WriteLiteral(@"                                            </div>
                                        </td>
                                        

                                        <td class=""product-subtotal"">
                                            <span class=""subtotal-amount"">");
#nullable restore
#line 71 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowCart.cshtml"
                                                                      Write(item.Count*item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 74 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowCart.cshtml"
                                    

                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </tbody>
                            </table>
                            
                        </div>

                        <div class=""cart-buttons"">
                            <div class=""row align-items-center"">
                                <div class=""col-lg-7 col-sm-7 col-md-7"">
                                    <div class=""shopping-coupon-code"">
                                        <input type=""text"" class=""form-control"" placeholder=""???? ??????????"" name=""coupon-code"" id=""coupon-code"">
                                        <button type=""submit"">?????????? ????</button>
                                    </div>
                                </div>

                               
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>

                <div class=""col-lg-3 col-md-12"">
                    <div class=""cart-totals"">
                        <h3>?????????? ?????? ????????</h3>

                        <ul>
                            <li>?????????????????? ???????? <span>***</span></li>
                            <li>?????????? ?????? <span>***</span></li>
                            <li>?????????? ???????? <span>***</span></li>
                            <li>?????????? ?????????????? <span>");
#nullable restore
#line 106 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowCart.cshtml"
                                               Write(Model.orderDetails.Sum(s => s.Count * s.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>

                        </ul>

                        <a href=""#"" class=""default-btn"">
                            ?????????? ????????????
                            <span></span>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </section>
");
#nullable restore
#line 119 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowCart.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">?????? ?????????????? ????????????</div>\r\n");
#nullable restore
#line 124 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowCart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- End Cart Area -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccessLayer.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
