#pragma checksum "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9db0d3bd164379a2a8ce970fb124501d4c4ab8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowAllProducts), @"mvc.1.0.view", @"/Views/Product/ShowAllProducts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9db0d3bd164379a2a8ce970fb124501d4c4ab8f", @"/Views/Product/ShowAllProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53cc166b53939d635a32dd2feb2e488ffe486903", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowAllProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataAccessLayer.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
  
    ViewData["Title"] = "ShowAllProducts";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Start Page Banner -->
<div class=""page-title-area"">
    <div class=""container"">
        <div class=""page-title-content"">
            <h2>فروشگاه</h2>

            <ul>
                <li><a href=""/"">صفحه اصلی</a></li>
                <li>فروشگاه</li>
            </ul>
        </div>
    </div>
</div>
<!-- End Page Banner -->
<!-- Start Shop Area -->
<section class=""shop-area bg-ffffff pt-50 pb-50"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-12"">
                <aside class=""widget-area"">
                    <div class=""widget widget_search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9db0d3bd164379a2a8ce970fb124501d4c4ab8f7003", async() => {
                WriteLiteral(@"
                            <label>
                                <span class=""screen-reader-text"">جستجو:</span>
                                <input type=""search"" class=""search-field"" placeholder=""جستجو..."" name=""search"">
                            </label>
                            <button type=""submit"">
                                <i class='bx bx-search-alt'></i>
                            </button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"widget widget_categories\">\r\n                        <h3 class=\"widget-title\">دسته بندی ها</h3>\r\n\r\n                        <ul class=\"categories\">\r\n\r\n");
#nullable restore
#line 44 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
                             foreach (var item in ViewData["categories"] as IEnumerable<DataAccessLayer.Models.Category>)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1744, "\"", 1803, 2);
            WriteAttributeValue("", 1751, "/product/ShowProductsOfSomeCategory/", 1751, 36, true);
#nullable restore
#line 47 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 1787, item.CategoryId, 1787, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                                        <i class=\"flaticon-desktop-computer\"></i>\r\n                                        ");
#nullable restore
#line 49 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
                                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 52 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n                <div class=\"widget widget_best-seller-products\">\r\n                    <h3 class=\"widget-title\">پرفروش ترین ها</h3>\r\n\r\n\r\n");
#nullable restore
#line 81 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
                     foreach (var item in ViewData["TopSales"] as IEnumerable<DataAccessLayer.Models.Product>)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <article class=\"item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3517, "\"", 3566, 2);
            WriteAttributeValue("", 3524, "/product/productsinglepage/", 3524, 27, true);
#nullable restore
#line 84 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 3551, item.ProductId, 3551, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"thumb\">\r\n                                <span class=\"fullimage cover bg1\"><img");
            BeginWriteAttribute("src", " src=\"", 3654, "\"", 3689, 3);
            WriteAttributeValue("", 3660, "/images/", 3660, 8, true);
#nullable restore
#line 85 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 3668, item.ProductId, 3668, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3685, ".jpg", 3685, 4, true);
            EndWriteAttribute();
            WriteLiteral("/></span>\r\n                            </a>\r\n                            <div class=\"info\">\r\n                                <h4 class=\"title usmall\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3880, "\"", 3929, 2);
            WriteAttributeValue("", 3887, "/product/productsinglepage/", 3887, 27, true);
#nullable restore
#line 89 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 3914, item.ProductId, 3914, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 89 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h4>\r\n                                <span>");
#nullable restore
#line 91 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
                                 Write(item.CreateDate.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                <ul class=""rating"">
                                    <li><i class='bx bxs-star'></i></li>
                                    <li><i class='bx bxs-star'></i></li>
                                    <li><i class='bx bxs-star'></i></li>
                                    <li><i class='bx bxs-star'></i></li>
                                    <li><i class='bx bxs-star'></i></li>
                                </ul>
                            </div>
                        </article>
");
#nullable restore
#line 101 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>


                </aside>
            </div>

            <div class=""col-lg-8 col-md-12"">
                <div class=""products-filter-options"">
                    <div class=""row align-items-center"">
                        <div class=""col-lg-4 col-md-4"">
                            <div class=""d-lg-flex d-md-flex align-items-center"">

                                <span class=""sub-title d-none d-lg-block d-md-block"">نمایش:</span>

                                <div class=""view-list-row d-none d-lg-block d-md-block"">
                                    <div class=""view-column"">
                                        <a href=""#"" class=""icon-view-two"">
                                            <span></span>
                                            <span></span>
                                        </a>

                                        <a href=""#"" class=""icon-view-three active"">
                                            <span></span>
     ");
            WriteLiteral(@"                                       <span></span>
                                            <span></span>
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class=""col-lg-4 col-md-4"">
                            <p>نمایش 1 - 18 از 100</p>
                        </div>

                        <div class=""col-lg-4 col-md-4"">
                            <div class=""products-ordering-list"" style=""padding:20px"">
                                <select id=""filter"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9db0d3bd164379a2a8ce970fb124501d4c4ab8f16776", async() => {
                WriteLiteral("بر اساس قیمت: گران به ارزان");
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
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9db0d3bd164379a2a8ce970fb124501d4c4ab8f17993", async() => {
                WriteLiteral("بر اساس پر فروش ترین ها");
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
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9db0d3bd164379a2a8ce970fb124501d4c4ab8f19206", async() => {
                WriteLiteral("مرتب سازی پیش فرض");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9db0d3bd164379a2a8ce970fb124501d4c4ab8f20444", async() => {
                WriteLiteral("بر اساس آخرین ها");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9db0d3bd164379a2a8ce970fb124501d4c4ab8f21650", async() => {
                WriteLiteral("بر اساس قیمت: ارزان به گران");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </div>
                            <button onclick=""xx()"" class=""nav-link btn btn-outline-primary"" style=""width:260px;"">جستجو</button>

                        </div>
                    </div>
                </div>
                <hr />
                <br />

                <div id=""products-collections-filter"" class=""row"">
");
#nullable restore
#line 158 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
                     if (ViewBag.catid != null)
                    {

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 163 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 7430, "\"", 7454, 1);
#nullable restore
#line 165 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 7438, item.CategoryId, 7438, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"catid\" />\r\n                        <div class=\"col-lg-4 col-sm-6\">\r\n                            <div class=\"single-shop-products\">\r\n                                <div class=\"shop-products-image\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 7697, "\"", 7746, 2);
            WriteAttributeValue("", 7704, "/product/productsinglepage/", 7704, 27, true);
#nullable restore
#line 169 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 7731, item.ProductId, 7731, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 7752, "\"", 7787, 3);
            WriteAttributeValue("", 7758, "/images/", 7758, 8, true);
#nullable restore
#line 169 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 7766, item.ProductId, 7766, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7783, ".jpg", 7783, 4, true);
            EndWriteAttribute();
            WriteLiteral(@" alt=""image""></a>
                                    <div class=""tag"">جدید</div>
                                    <ul class=""shop-action"">
                                        <li>
                                            <a href=""cart.html"">
                                                <i class=""flaticon-shopping-cart""></i>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""wishlist.html""><i class=""flaticon-heart""></i></a>
                                        </li>
                                        <li>
                                            <a href=""#"" data-bs-toggle=""modal"" data-bs-target=""#productsQuickView""><i class=""flaticon-view""></i></a>
                                        </li>
                                    </ul>
                                </div>

                                <div class=""shop-product");
            WriteLiteral("s-content\">\r\n                                    <h3>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 8909, "\"", 8958, 2);
            WriteAttributeValue("", 8916, "/product/productsinglepage/", 8916, 27, true);
#nullable restore
#line 188 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 8943, item.ProductId, 8943, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 188 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
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
#line 197 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 201 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ShowAllProducts.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



                    <div class=""col-lg-12 col-md-12"">
                        <div class=""pagination-area"">
                            <a href=""#"" class=""prev page-numbers"">
                                <i class='flaticon-right-arrow'></i>
                            </a>
                            <a href=""#"" class=""page-numbers current"" aria-current=""page"">1</a>
                            <span class=""page-numbers"">2</span>
                            <a href=""#"" class=""page-numbers"">3</a>
                            <a href=""#"" class=""page-numbers"">4</a>
                            <a href=""#"" class=""next page-numbers"">
                                <i class='flaticon-left-arrow'></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- End Shop Area -->

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        function ShowProductsOfsingleCategory(id) {
            $.ajax({
                url: ""/product/ShowProductsOfSomeCategory"",
                data: { categoryid: id }

            }).done(function (re) { $(""#products-collections-filter"").fadeOut(800, function () { $(this).html(re).fadeIn(800) }) })
        }


        function xx() {
            $.ajax({
                url: ""/product/filter"",
                data: { test: $('#filter :selected').val()}
            }).done(function (re) { $(""#products-collections-filter"").fadeOut(800, function () { $(this).html(re).toggle(800) }) })

        }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataAccessLayer.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591