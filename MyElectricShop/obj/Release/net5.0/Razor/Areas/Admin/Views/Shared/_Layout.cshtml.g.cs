#pragma checksum "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b82bfefc32f488d92e6b5fdf670b4269fa2b8e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b82bfefc32f488d92e6b5fdf670b4269fa2b8e0", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53cc166b53939d635a32dd2feb2e488ffe486903", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<!--\r\nThis is a starter template page. Use this page to start your new project from\r\nscratch. This page gets rid of all links and provides the needed markup only.\r\n-->\r\n<html lang=\"en\" dir=\"rtl\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b82bfefc32f488d92e6b5fdf670b4269fa2b8e03891", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta http-equiv=""x-ua-compatible"" content=""ie=edge"">


    <!-- Font Awesome Icons -->
    <link rel=""stylesheet"" href=""/Admin/plugins/font-awesome/css/font-awesome.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""/Admin/dist/css/adminlte.min.css"">
    <!-- Google Font: Source Sans Pro -->
    <link href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700"" rel=""stylesheet"">

    <!-- bootstrap rtl -->
    <link rel=""stylesheet"" href=""/Admin/dist/css/bootstrap-rtl.min.css"">
    <!-- template rtl version -->
    <link rel=""stylesheet"" href=""/Admin/dist/css/custom-style.css"">


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b82bfefc32f488d92e6b5fdf670b4269fa2b8e05632", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">
        <!-- Navbar -->
        
        <!-- /.navbar -->
        <!-- Main Sidebar Container -->
        <aside class=""main-sidebar sidebar-dark-primary elevation-4"">
            <!-- Brand Logo -->
            <a href=""index3.html"" class=""brand-link"">
                <img src=""/Admin/dist/img/AdminLTELogo.png"" alt=""AdminLTE Logo"" class=""brand-image img-circle elevation-3""
                     style=""opacity: .8"">
                <span class=""brand-text font-weight-light"">پنل مدیریت</span>
            </a>

            <!-- Sidebar -->
            <div class=""sidebar"">
                <div>
                    <!-- Sidebar user panel (optional) -->
                    <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">
                      
                        <div class=""info"">
                            <a href=""#"" class=""d-block"">");
#nullable restore
#line 48 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                   Write(ViewBag.email);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
                        </div>
                    </div>

                    <!-- Sidebar Menu -->
                    <nav class=""mt-2"">
                        <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
                            <!-- Add icons to the links using the .nav-icon class
         with font-awesome or any other icon font library -->
                            <li class=""nav-item has-treeview menu-open"">
                                <a href=""#"" class=""nav-link active"">
                                    <i class=""nav-icon fa fa-dashboard""></i>
                                    <p>
                                        صفحات شروع
                                        <i class=""right fa fa-angle-left""></i>
                                    </p>
                                </a>
                                <ul class=""nav nav-treeview"">
                                    <li class=""nav-item");
                WriteLiteral(@""">
                                        <a href=""/Admin/categories/index"" class=""nav-link"">
                                            <i class=""fa fa-circle-o nav-icon""></i>
                                            <p>مدیریت گروه بندی فروشگاه</p>
                                        </a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a href=""/Admin/products/index"" class=""nav-link"">
                                            <i class=""fa fa-circle-o nav-icon""></i>
                                            <p>مدیریت محصولات فروشگاه</p>
                                        </a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a href=""/Admin/contents/index"" class=""nav-link"">
                                            <i class=""fa fa-circle-o nav-icon""></i>
                                          ");
                WriteLiteral(@"  <p>مدیریت محتوای سایت</p>
                                        </a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a href=""/Admin/users/index"" class=""nav-link"">
                                            <i class=""fa fa-circle-o nav-icon""></i>
                                            <p>مدیریت کاربران سایت</p>
                                        </a>
                                    </li>
                                </ul>
                            </li>
                            <li class=""nav-item"">
                                <a href=""/Admin/FinallyOrders/index"" class=""nav-link"">
                                    <i class=""nav-icon fa fa-th""></i>
                                    <p>
                                        سفارشات ثبت شده
                                        <span class=""right badge badge-danger"">جدید</span>
                                    </p");
                WriteLiteral(@">
                                </a>
                            </li>
                            <li class=""footer nav-item"" style=""position:fixed;bottom:50px"">
                                <a href=""/"" class=""nav-link"">
                                    <i class=""fa fa-circle-o nav-icon""></i>
                                    <p>
                                        خروج
                                    </p>
                                </a>
                            </li>
                        </ul>
                    </nav>
                    <!-- /.sidebar-menu -->
                </div>
            </div>
            <!-- /.sidebar -->
        </aside>

        <!-- Content Wrapper. Contains page content -->
        <div class=""content-wrapper"">
            <!-- Content Header (Page header) -->
            
            <!-- /.content-header -->
            <!-- Main content -->
            <div class=""content"">
                <div class=""container-fluid");
                WriteLiteral("\">\r\n                    ");
#nullable restore
#line 125 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                    <!-- /.row -->
                </div><!-- /.container-fluid -->
            </div>
            <!-- /.content -->
        </div>
        <!-- /.content-wrapper -->
        <!-- Control Sidebar -->
        <aside class=""control-sidebar control-sidebar-dark"">
            <!-- Control sidebar content goes here -->
            <div class=""p-3"">
                <h5>Title</h5>
                <p>Sidebar content</p>
            </div>
        </aside>
        <!-- /.control-sidebar -->
        <!-- Main Footer -->
        <footer class=""main-footer"">
            <!-- To the right -->
            <div class=""float-right d-none d-sm-inline"">
                Anything you want
            </div>
            <!-- Default to the left -->
        </footer>
    </div>
    <!-- ./wrapper -->
    <!-- REQUIRED SCRIPTS -->
    <!-- jQuery -->
    <script src=""/Admin/plugins/jquery/jquery.min.js""></script>
    <!-- Bootstrap 4 -->
    <script src=""/Admin//Admin/plugins/bootst");
                WriteLiteral("rap/js/bootstrap.bundle.min.js\"></script>\r\n    <!-- AdminLTE App -->\r\n    <script src=\"/Admin/dist/js/adminlte.min.js\"></script>\r\n    ");
#nullable restore
#line 159 "F:\projects\MyElectricShop\MyElectricShop\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
