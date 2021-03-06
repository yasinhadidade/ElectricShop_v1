#pragma checksum "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4de986763a61ff1af7e0645e95b44706f139b300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_FinallyOrders_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/FinallyOrders/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de986763a61ff1af7e0645e95b44706f139b300", @"/Areas/Admin/Views/FinallyOrders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53cc166b53939d635a32dd2feb2e488ffe486903", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_FinallyOrders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataAccessLayer.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n    <div class=\"alert alert-primary\"><h4>مدیریت سفارشات جدید</h4></div>\r\n    <br />\r\n    <hr />\r\n    <table class=\"table\">\r\n        <thead");
            BeginWriteAttribute("class", " class=\"", 213, "\"", 221, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <tr>
                <th>نام و نام خانوادگی</th>
                <th>شماره همراه</th>
                <th>ایمیل</th>
                <th>آدرس ارسال محصول</th>
                <th>تاریخ ثبت سفارش</th>
                <th>مشاهده سفارش</th>
                <th></th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\Index.cshtml"
                   Write(item.Fulllname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\Index.cshtml"
                   Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\Index.cshtml"
                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\Index.cshtml"
                   Write(item.order.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button class=\"btn btn-primary\" id=\"ShowOrder\"");
            BeginWriteAttribute("onclick", " onclick=\"", 973, "\"", 1006, 3);
            WriteAttributeValue("", 983, "ShowOrder(", 983, 10, true);
#nullable restore
#line 31 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\Index.cshtml"
WriteAttributeValue("", 993, item.UserId, 993, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1005, ")", 1005, 1, true);
            EndWriteAttribute();
            WriteLiteral(">مشاهده سفارش</button>\r\n                    </td>\r\n                    <td><button class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1113, "\"", 1146, 3);
            WriteAttributeValue("", 1123, "openorder(", 1123, 10, true);
#nullable restore
#line 33 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\Index.cshtml"
WriteAttributeValue("", 1133, item.UserId, 1133, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1145, ")", 1145, 1, true);
            EndWriteAttribute();
            WriteLiteral(">در صورت تکمیل اماده سازی سفارش، کلیک کنید</button></td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 36 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\FinallyOrders\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <hr style=\"color:deeppink\" />\r\n    <hr style=\"color:deeppink\" />\r\n\r\n\r\n    <div id=\"or\">\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

        <script>

            function ShowOrder(pid) {
                $.ajax({
                    url: ""/Admin/finallyOrders/ShowOrderOfUser"",
                    data: { id: pid }

                }).done(function (re) { $(""#or"").html(re); })
            }

            function openorder(id) {
                $.ajax({
                    url: ""/Admin/finallyorders/OpenOrder"",
                    data: { userid: id }

                }).done(function (re) { alert(re); location.reload(true) })
            }


            function closeorderdetail(id) {
                $.ajax({
                    url: ""/Admin/finallyorders/finishorderdetail"",
                    data: { detailid: id }

                }).done(function (re) { alert(re) })
            };


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataAccessLayer.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
