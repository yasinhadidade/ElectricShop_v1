#pragma checksum "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\SpecialOfferComponent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a212f9ed3ed14e7a3aaabdae60cf61c3b5702b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SpecialOfferComponent), @"mvc.1.0.view", @"/Views/Shared/Components/SpecialOfferComponent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a212f9ed3ed14e7a3aaabdae60cf61c3b5702b2", @"/Views/Shared/Components/SpecialOfferComponent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53cc166b53939d635a32dd2feb2e488ffe486903", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SpecialOfferComponent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataAccessLayer.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\SpecialOfferComponent.cshtml"
 if (Model != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\SpecialOfferComponent.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-4 col-md-6\">\r\n    <div class=\"single-offer-products\">\r\n        <div class=\"offer-products-image\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 251, "\"", 300, 2);
            WriteAttributeValue("", 258, "/product/productsinglepage/", 258, 27, true);
#nullable restore
#line 10 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\SpecialOfferComponent.cshtml"
WriteAttributeValue("", 285, item.ProductId, 285, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 306, "\"", 341, 3);
            WriteAttributeValue("", 312, "/images/", 312, 8, true);
#nullable restore
#line 10 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\SpecialOfferComponent.cshtml"
WriteAttributeValue("", 320, item.ProductId, 320, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 337, ".jpg", 337, 4, true);
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\"></a>\r\n");
            WriteLiteral("        </div>\r\n\r\n        <div class=\"offer-products-content\">\r\n            <h3>\r\n                <a href=\"products-details.html\">");
#nullable restore
#line 16 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\SpecialOfferComponent.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </h3>\r\n            <div class=\"price\">\r\n                <span class=\"new-price\">");
#nullable restore
#line 19 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\SpecialOfferComponent.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <span class=\"old-price\">");
#nullable restore
#line 20 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\SpecialOfferComponent.cshtml"
                                   Write(item.OldPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <ul class=""rating"">
                <li>
                    <i class=""bx bxs-star""></i>
                    <i class=""bx bxs-star""></i>
                    <i class=""bx bxs-star""></i>
                    <i class=""bx bxs-star""></i>
                    <i class=""bx bxs-star""></i>
                </li>
            </ul>
        </div>
    </div>
</div>
");
#nullable restore
#line 34 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\SpecialOfferComponent.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "F:\projects\MyElectricShop\MyElectricShop\Views\Shared\Components\SpecialOfferComponent.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .offer-products-image:hover {\r\n        transform: scale(1.1);\r\n    }\r\n</style>");
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