#pragma checksum "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cbea62e610592431dbebb6d32e4893fe6789789"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductSinglePage), @"mvc.1.0.view", @"/Views/Product/ProductSinglePage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cbea62e610592431dbebb6d32e4893fe6789789", @"/Views/Product/ProductSinglePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53cc166b53939d635a32dd2feb2e488ffe486903", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductSinglePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccessLayer.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <!-- Start Page Banner -->
<div class=""page-title-area"">
    <div class=""container"">
        <div class=""page-title-content"">
            <h2>???????????? ??????????????</h2>

            <ul>
                <li><a href=""index.html"">???????? ????????</a></li>
                <li>???????????? ??????????????</li>
            </ul>
        </div>
    </div>
</div>
<!-- End Page Banner -->
<!-- Start Products Details Area -->
<section class=""products-details-area ptb-50"">
    <div class=""container"">
        <div class=""products-details-desc"">
            <div class=""row align-items-center"">
                <div class=""col-lg-6 col-md-6"">
                    <div class=""main-products-image"">

                        <div class=""slider slider-for"">
                            <div><img");
            BeginWriteAttribute("src", " src=\"", 823, "\"", 859, 3);
            WriteAttributeValue("", 829, "/images/", 829, 8, true);
#nullable restore
#line 25 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
WriteAttributeValue("", 837, Model.ProductId, 837, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 855, ".jpg", 855, 4, true);
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\"></div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-lg-6 col-md-6\">\r\n                    <div class=\"product-content content-two\">\r\n                        <h3>");
#nullable restore
#line 33 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                        <div class=""product-review"">
                            <div class=""rating"">
                                <i class='bx bxs-star'></i>
                                <i class='bx bxs-star'></i>
                                <i class='bx bxs-star'></i>
                                <i class='bx bxs-star'></i>
                                <i class='bx bxs-star'></i>
                            </div>
                        </div>

                        <div class=""price"">
                            <span class=""old-price"">???????? ????????????</span>
                            <span class=""new-price"">");
#nullable restore
#line 47 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
                                               Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                        <p>???????? ???????????? ???????????? ?????? ?? ?????? ???? ???? ???? ???? ????????. ???????? ???????????? ?????????????????? ???????? ???????? ??????. ???????? ???????????? ???????????? ?????? ?? ?????? ???? ???? ???? ???? ????????. ???????? ???????????? ?????????????????? ???????? ???????? ??????. ???????? ???????????? ???????????? ?????? ?? ?????? ???? ???? ???? ???? ????????. ???????? ???????????? ?????????????????? ???????? ???????? ??????.</p>

                        <ul class=""products-info"">
                            <li>
                                <span>??????????:</span>
");
#nullable restore
#line 54 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
                                 if (Model.IsExist == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<b>???? ??????????</b>");
#nullable restore
#line 55 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
                                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b>????????</b>");
#nullable restore
#line 57 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </li>
                        </ul>

                        <div class=""products-color-switch"">
                            <p class=""available-color"">
                                <span>??????</span> :
                                <a href=""#"" style=""background: #a53c43;""></a>
                                <a href=""#"" style=""background: #192861;""></a>
                                <a href=""#"" style=""background: #c58a84;""></a>
                                <a href=""#"" style=""background: #ecc305;""></a>
                                <a href=""#"" style=""background: #000000;""></a>
                                <a href=""#"" style=""background: #808080;""></a>
                            </p>
                        </div>

                        <div class=""product-quantities"">
                            <span>??????????:</span>

                            <div class=""input-counter"">
                                <span class=""minus-btn"">
                    ");
            WriteLiteral(@"                <i class='bx bx-minus'></i>
                                </span>
                                <input type=""text"" value=""1"" id=""count"">


                                <span class=""plus-btn"">
                                    <i class='bx bx-plus'></i>
                                </span>
                            </div>
                        </div>
");
#nullable restore
#line 88 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""product-add-to-cart"">
                                <a onclick=""addtocart()"" class=""default-btn"">
                                    <i class=""flaticon-shopping-cart""></i>
                                    ???????????? ?????? ????????
                                    <span></span>
                                </a>
                                <input type=""hidden"" id=""proid""");
            BeginWriteAttribute("value", " value=\"", 4382, "\"", 4406, 1);
#nullable restore
#line 96 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
WriteAttributeValue("", 4390, Model.ProductId, 4390, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                            </div>\r\n");
#nullable restore
#line 99 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""alert alert-info"">
                                <h6>???????? ???????????? ?????????? ???? ?????? ???????? ?????????? ???????? ???? ???????? ???????? ?????? ???????? ?????? ???????????? ?????? ????????</h6>
                                <h6 style=""color:darkred"">
                                    <a class=""link-primary"" href=""/account/login"">???????? ???? ?????? ????????????</a>
                                </h6>
                            </div>
");
#nullable restore
#line 108 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        <div class=""products-share"">
                            <ul class=""social"">
                                <li><span>???????????? ??????????:</span></li>
                                <li>
                                    <a href=""#"" target=""_blank""><i class='bx bxl-facebook'></i></a>
                                </li>
                                <li>
                                    <a href=""#"" target=""_blank""><i class='bx bxl-twitter'></i></a>
                                </li>
                                <li>
                                    <a href=""#"" target=""_blank""><i class='bx bxl-linkedin'></i></a>
                                </li>
                                <li>
                                    <a href=""#"" target=""_blank""><i class='bx bxl-instagram'></i></a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div");
            WriteLiteral(@">
        </div>
        <div class=""products-details-tabs"">
            <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                <li class=""nav-item""><a class=""nav-link active"" id=""description-tab"" data-bs-toggle=""tab"" href=""#description"" role=""tab"" aria-controls=""description"">?????? ??????????</a></li>
                <li class=""nav-item""><a class=""nav-link"" id=""reviews-tab"" data-bs-toggle=""tab"" href=""#reviews"" role=""tab"" aria-controls=""reviews"">????????????????</a></li>
                <li class=""nav-item""><a class=""nav-link"" id=""information-tab"" data-bs-toggle=""tab"" href=""#information"" role=""tab"" aria-controls=""information"">?????????????? ????????</a></li>
            </ul>
            <div class=""tab-content"" id=""myTabContent"">
                <div class=""tab-pane fade show active"" id=""description"" role=""tabpanel"">
                    <h2>???????? ??????</h2>

                    <p>");
#nullable restore
#line 142 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                </div>

                <div class=""tab-pane fade"" id=""reviews"" role=""tabpanel"">
                    <div class=""products-reviews"">
                        <h3>??????????</h3>

                        <div class=""row"">
                            <div class=""side"">
                                <div>5 ??????????</div>
                            </div>
                            <div class=""middle"">
                                <div class=""bar-container"">
                                    <div class=""bar-5""></div>
                                </div>
                            </div>
                            <div class=""side right"">
                                <div>70%</div>
                            </div>
                            <div class=""side"">
                                <div>4 ??????????</div>
                            </div>
                            <div class=""middle"">
                                <div class=""bar-container"">
        ");
            WriteLiteral(@"                            <div class=""bar-4""></div>
                                </div>
                            </div>
                            <div class=""side right"">
                                <div>20%</div>
                            </div>
                            <div class=""side"">
                                <div>3 ??????????</div>
                            </div>
                            <div class=""middle"">
                                <div class=""bar-container"">
                                    <div class=""bar-3""></div>
                                </div>
                            </div>
                            <div class=""side right"">
                                <div>5%</div>
                            </div>
                            <div class=""side"">
                                <div>2 ??????????</div>
                            </div>
                            <div class=""middle"">
                                <div class=""ba");
            WriteLiteral(@"r-container"">
                                    <div class=""bar-2""></div>
                                </div>
                            </div>
                            <div class=""side right"">
                                <div>3%</div>
                            </div>
                            <div class=""side"">
                                <div>1 ??????????</div>
                            </div>
                            <div class=""middle"">
                                <div class=""bar-container"">
                                    <div class=""bar-1""></div>
                                </div>
                            </div>
                            <div class=""side right"">
                                <div>2%</div>
                            </div>
                        </div>
                    </div>

                    <div class=""products-review-form"">
                        <h3>?????????? ??????????????</h3>

                        <div class=""review");
            WriteLiteral(@"-title"">
                            <div class=""rating"">
                                <i class='bx bxs-star'></i>
                                <i class='bx bxs-star'></i>
                                <i class='bx bxs-star'></i>
                                <i class='bx bxs-star'></i>
                                <i class='bx bxs-star'></i>
                            </div>

                            <a href=""#"" class=""default-btn"">
                                ?????? ??????????????
                                <span></span>
                            </a>
                        </div>

                        <div class=""review-comments"" id=""coment"">
");
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0cbea62e610592431dbebb6d32e4893fe678978917614", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <div class=\"review-form\">\r\n                            <h3>?????? ??????????</h3>\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cbea62e610592431dbebb6d32e4893fe678978918945", async() => {
                WriteLiteral("\r\n                                <div class=\"row\">\r\n                                    <input type=\"hidden\" id=\"productid\"");
                BeginWriteAttribute("value", " value=\"", 12065, "\"", 12089, 1);
#nullable restore
#line 254 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
WriteAttributeValue("", 12073, Model.ProductId, 12073, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                    <div class=""col-lg-6 col-md-6"">
                                        <div class=""form-group"">
                                            <input type=""text"" id=""name"" name=""name"" placeholder=""?????? ??????"" class=""form-control"">
                                        </div>
                                    </div>

                                    <div class=""col-lg-6 col-md-6"">
                                        <div class=""form-group"">
                                            <input type=""email"" id=""email"" name=""email"" placeholder=""???????? ?????????? ??????"" class=""form-control"">
                                        </div>
                                    </div>

                                    <div class=""col-lg-12 col-md-12"">
                                        <div class=""form-group"">
                                            <textarea name=""review-body"" id=""review-body"" cols=""30"" rows=""6"" placeholder=""?????? ?????? ???? ??????????????"" class=""form-");
                WriteLiteral(@"control""></textarea>
                                        </div>
                                    </div>

                                    <div class=""col-lg-12 col-md-12"">
                                        <a class=""default-btn"" onclick=""addcomment()"">
                                            ?????????? ??????
                                        </a>
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
                    </div>
                </div>

                <div class=""tab-pane fade show"" id=""information"" role=""tabpanel"">
                    <ul class=""information-list"">
                        <li>????????: <span> ?????????? ?? ?????????? ?????????? ?? ?????????? ?????????? ?? ???????????? 9 ????????</span></li>
                        <li>????????: <a href=""tel:+15143214567"">021-12345678</a></li>
                        <li>??????????: <a href=""mailto:hello@ejon.com"">hello@ejon.com</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- End Products Details Area -->
<!-- Start Arrivals Products Area -->
<section class=""arrivals-products-area pt-50 pb-20"">
    <div class=""container"">
        <div class=""section-title"">
            <h2>?????????????? ??????????</h2>
        </div>

        <div class=""row"">
");
#nullable restore
#line 304 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
             foreach (var item in ViewData["relatedproducts"] as IEnumerable<DataAccessLayer.Models.Product>)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-sm-6\">\r\n                    <div class=\"single-arrivals-products\">\r\n                        <div class=\"arrivals-products-image\">\r\n                            <a href=\"products-details.html\"><img");
            BeginWriteAttribute("src", " src=\"", 14860, "\"", 14895, 3);
            WriteAttributeValue("", 14866, "/images/", 14866, 8, true);
#nullable restore
#line 309 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
WriteAttributeValue("", 14874, item.ProductId, 14874, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 14891, ".jpg", 14891, 4, true);
            EndWriteAttribute();
            WriteLiteral(@" alt=""image""></a>
                            <div class=""tag"">????????</div>
                            <ul class=""arrivals-action"">
                                <li>
                                    <a href=""cart.html"">
                                        <i class=""flaticon-shopping-cart""></i>
                                    </a>
                                </li>
                                <li>
                                    <a href=""wishlist.html"">
                                        <i class=""flaticon-heart""></i>
                                    </a>
                                </li>
                                <li>
                                    <a href=""#"" data-bs-toggle=""modal"" data-bs-target=""#productsQuickView"">
                                        <i class=""flaticon-view""></i>
                                    </a>
                                </li>
                            </ul>
                        </div>
              ");
            WriteLiteral("          <div class=\"arrivals-products-content\">\r\n                            <h3>\r\n                                <a href=\"products-details.html\">");
#nullable restore
#line 331 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
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
#line 340 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"
                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 344 "F:\projects\MyElectricShop\MyElectricShop\Views\Product\ProductSinglePage.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<!-- End Arrivals Products Area -->\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        function addtocart() {
            $.ajax({
                url: ""/product/AddToCart"",
                data: {
                    productid: $(""#proid"").val(),
                    count: $(""#count"").val()
                },
                type: 'Get',
                success: function () { window.location.href = '/product/showcart' }

            })
        }

        function addcomment() {
            $.ajax({
                url: ""/product/AddComment"",
                type: 'Get',
                data: {
                    productid: $(""#productid"").val(),
                    name: $(""#name"").val(),
                    email: $(""#email"").val(),
                    text: $(""#review-body"").val()
                },
                success: function (re) { $(""#name"").val(""""); $(""#email"").val(""""); $(""#review-body"").val("""");$(""#coment"").html(re) }
            })
        }



    </script>


");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccessLayer.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
