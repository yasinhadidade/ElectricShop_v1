#pragma checksum "F:\projects\MyElectricShop\MyElectricShop\Views\Content\ShowAllContents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02b603366172fd6ae8eb3e6c208b3bb6ac8a42bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_ShowAllContents), @"mvc.1.0.view", @"/Views/Content/ShowAllContents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02b603366172fd6ae8eb3e6c208b3bb6ac8a42bc", @"/Views/Content/ShowAllContents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53cc166b53939d635a32dd2feb2e488ffe486903", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_ShowAllContents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\projects\MyElectricShop\MyElectricShop\Views\Content\ShowAllContents.cshtml"
  
    ViewData["Title"] = "ShowAllContents";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Start Page Banner -->
<div class=""page-title-area"">
    <div class=""container"">
        <div class=""page-title-content"">
            <h2>وبلاگ تمام عرض</h2>

            <ul>
                <li><a href=""index.html"">صفحه اصلی</a></li>
                <li>وبلاگ تمام عرض</li>
            </ul>
        </div>
    </div>
</div>
<!-- End Page Banner -->
<!-- Start Blog Area -->
<section class=""blog-area bg-color bg-ffffff pt-50 pb-50"">
    <div class=""container-fluid"">
        <div class=""row"">

");
#nullable restore
#line 24 "F:\projects\MyElectricShop\MyElectricShop\Views\Content\ShowAllContents.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6\">\r\n                    <div class=\"single-blog\">\r\n                        <div class=\"blog-image\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 806, "\"", 855, 2);
            WriteAttributeValue("", 813, "/content/contentsinglepage/", 813, 27, true);
#nullable restore
#line 29 "F:\projects\MyElectricShop\MyElectricShop\Views\Content\ShowAllContents.cshtml"
WriteAttributeValue("", 840, item.Contentid, 840, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 861, "\"", 902, 3);
            WriteAttributeValue("", 867, "/ContentImage/", 867, 14, true);
#nullable restore
#line 29 "F:\projects\MyElectricShop\MyElectricShop\Views\Content\ShowAllContents.cshtml"
WriteAttributeValue("", 881, item.Contentid, 881, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 898, ".jpg", 898, 4, true);
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\"></a>\r\n                        </div>\r\n\r\n                        <div class=\"blog-content\">\r\n                            <span>");
#nullable restore
#line 33 "F:\projects\MyElectricShop\MyElectricShop\Views\Content\ShowAllContents.cshtml"
                             Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <h3>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1130, "\"", 1179, 2);
            WriteAttributeValue("", 1137, "/content/contentsinglepage/", 1137, 27, true);
#nullable restore
#line 35 "F:\projects\MyElectricShop\MyElectricShop\Views\Content\ShowAllContents.cshtml"
WriteAttributeValue("", 1164, item.Contentid, 1164, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "F:\projects\MyElectricShop\MyElectricShop\Views\Content\ShowAllContents.cshtml"
                                                                                Write(item.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </h3>
                            <div class=""post-meta"">
                                <a href=""#"">مدیر</a> / 20 دی 1398
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 43 "F:\projects\MyElectricShop\MyElectricShop\Views\Content\ShowAllContents.cshtml"

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
                    <a href=""#"" class=""page-numbers"">1</a>
                    <span class=""page-numbers current"" aria-current=""page"">2</span>
                    <a href=""#"" class=""page-numbers"">3</a>
                    <a href=""#"" class=""page-numbers"">4</a>
                    <a href=""#"" class=""next page-numbers"">
                        <i class='flaticon-left-arrow'></i>
                    </a>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- End Blog Area -->
");
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
