#pragma checksum "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\ShowOrderOfUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b72dd49c3699a12c10213cedaccfad4dd3b2dd34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_FinallyOrders_ShowOrderOfUser), @"mvc.1.0.view", @"/Areas/Admin/Views/FinallyOrders/ShowOrderOfUser.cshtml")]
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
#line 1 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\_ViewImports.cshtml"
using MyElectricShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\_ViewImports.cshtml"
using MyElectricShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72dd49c3699a12c10213cedaccfad4dd3b2dd34", @"/Areas/Admin/Views/FinallyOrders/ShowOrderOfUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53cc166b53939d635a32dd2feb2e488ffe486903", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_FinallyOrders_ShowOrderOfUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataAccessLayer.Models.OrderDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\ShowOrderOfUser.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>ریز فاکتور مشتری : ");
#nullable restore
#line 5 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\ShowOrderOfUser.cshtml"
                      Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
    <table class=""table table-bordered"" style=""text-align:center"">
        <thead>
            <tr>
                <th scope=""col"">محصول</th>
                <th scope=""col"">نام کالا</th>
                <th scope=""col"">قیمت واحد</th>
                <th scope=""col"">تعداد کالا</th>
                <th scope=""col"">مجموع</th>
                <th scope=""col""></th>

            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 20 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\ShowOrderOfUser.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr id=\"orderdetail\">\r\n                    <td class=\"product-thumbnail\">\r\n                        <a><i class=\'bx bx-x\'></i></a>\r\n\r\n                        <a href=\"#\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 837, "\"", 880, 3);
            WriteAttributeValue("", 843, "/images/", 843, 8, true);
#nullable restore
#line 27 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\ShowOrderOfUser.cshtml"
WriteAttributeValue("", 851, item.product.ProductId, 851, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 876, ".jpg", 876, 4, true);
            EndWriteAttribute();
            WriteLiteral(" alt=\"item\" style=\"max-width:120px\">\r\n                        </a>\r\n                    </td>\r\n\r\n\r\n                    <td class=\"product-name\">\r\n                        <a href=\"products-details.html\">");
#nullable restore
#line 33 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\ShowOrderOfUser.cshtml"
                                                   Write(item.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </td>\r\n\r\n                    <td class=\"product-price\">\r\n                        <span class=\"unit-amount\">");
#nullable restore
#line 37 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\ShowOrderOfUser.cshtml"
                                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n\r\n                    <td class=\"product-quantity\">\r\n                        <div class=\"input-counter\">\r\n");
            WriteLiteral("                            <span class=\"unit-amount\">");
#nullable restore
#line 43 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\ShowOrderOfUser.cshtml"
                                                 Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                        </div>\r\n                    </td>\r\n\r\n\r\n                    <td class=\"product-subtotal\">\r\n                        <span class=\"subtotal-amount\">");
#nullable restore
#line 50 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\ShowOrderOfUser.cshtml"
                                                  Write(item.Count*item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                    <td><button id=\"closee\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1937, "\"", 1979, 3);
            WriteAttributeValue("", 1947, "closeorderdetail(", 1947, 17, true);
#nullable restore
#line 52 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\ShowOrderOfUser.cshtml"
WriteAttributeValue("", 1964, item.DetailId, 1964, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1978, ")", 1978, 1, true);
            EndWriteAttribute();
            WriteLiteral(">در صورت ارسال موفقیت آمیز محصول،لطفا ریز فاکتور را ببندید</button></td>\r\n                </tr>\r\n");
#nullable restore
#line 54 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\ShowOrderOfUser.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n\r\n    </table>\r\n    <div class=\"alert alert-success\"> جمع کل خرید :");
#nullable restore
#line 60 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\ShowOrderOfUser.cshtml"
                                              Write(Model.Sum(i => i.Count * i.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</div>\r\n");
#nullable restore
#line 61 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\ShowOrderOfUser.cshtml"
                                                                                               


}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert-danger \"> ریز فاکتوری یافت نشد</div>\r\n");
#nullable restore
#line 68 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\ShowOrderOfUser.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataAccessLayer.Models.OrderDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
