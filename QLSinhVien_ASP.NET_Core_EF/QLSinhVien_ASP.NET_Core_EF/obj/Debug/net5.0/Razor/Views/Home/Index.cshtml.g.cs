#pragma checksum "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "364cb364a747b022e321007d80215d734f491039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"364cb364a747b022e321007d80215d734f491039", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QLSinhVien_ASP.NET_Core_EF.Models.Khoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo_dhdn1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px;height:75px; object-fit:contain"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Header Area -->
<header class=""header"">
    <!-- Header Inner -->
    <div class=""header-inner"" style=""padding-top: 30px;"">
        <div class=""container"">
            <div class=""inner"">
                <div class=""row"">
                    <div class=""col-lg-3 col-md-3 col-12"">
                        <!-- Start Logo -->
                        <div class=""logo"">
                            <a href=""index.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "364cb364a747b022e321007d80215d734f4910394471", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                        </div>
                        <!-- End Logo -->
                        <!-- Mobile Nav -->
                        <div class=""mobile-nav""></div>
                        <!-- End Mobile Nav -->
                    </div>
                    <div class=""col-lg-7 col-md-9 col-12"">
                        <!-- Main Menu -->
                        <div class=""main-menu"">
                            <nav class=""navigation"">
                                <ul class=""nav menu"">
                                    <li><a href=""/Home/Index"">Trang chủ</a></li>
                                    <li><a href=""/Home/KhoaList"">Khoa </a></li>
                                    <li><a href=""/Home/GVList"">Giáo viên </a></li>
                                    <li><a href=""Home/SVList"">Sinh viên </a></li>
                                    <li><a href=""/Home/LopSHList"">Lớp SH </i></a></li>
                                    <li><a href=""/Home/LopHPList"">Lớp HP</a></li>
  ");
            WriteLiteral(@"                              </ul>
                            </nav>
                        </div>
                        <!--/ End Main Menu -->
                    </div>
                    <div class=""col-lg-2 col-12"">
                        <div class=""get-quote"">
                            <a href=""/Manage/KhoaManage"" class=""btn"">Trang quản lý</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--/ End Header Inner -->
</header>
<!-- End Header Area -->
<!-- Slider Area -->
<section class=""slider"">
    <div class=""hero-slider"">
        <!-- Start Single Slider -->
        <div class=""single-slider"" style=""background-image: url('~/images/slider2.jpg')"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-7"">
                        <div class=""text"">
                            <h1>Đại học SPKT  <span>Đà Nẵng</span> xin chào<span> các");
            WriteLiteral(@" bạn</span></h1>
                            <div class=""button"">
                                <a href=""#"" class=""btn"">Đăng kí lớp học phần</a>
                                <a href=""#"" class=""btn primary"">Tìm hiểu thêm</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Single Slider -->
        <!-- Start Single Slider -->
        <div class=""single-slider"" style=""background-image: url('~/images/slider2.jpg')"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-7"">
                        <div class=""text"">
                            <h1>Đại học SPKT  <span>Đà Nẵng</span> xin chào<span> các bạn</span></h1>
                            <div class=""button"">
                                <a href=""#"" class=""btn"">Đăng kí lớp học phần</a>
                                <a href=""#"" class=""btn primary"">Tìm hiểu th");
            WriteLiteral(@"êm</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Start End Slider -->
        <!-- Start Single Slider -->
        <div class=""single-slider"" style=""background-image: url('~/images/slider2.jpg')"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-7"">
                        <div class=""text"">
                            <h1>Đại học SPKT  <span>Đà Nẵng</span> xin chào<span> các bạn</span></h1>
                            <div class=""button"">
                                <a href=""#"" class=""btn"">Đăng kí lớp học phần</a>
                                <a href=""#"" class=""btn primary"">Tìm hiểu thêm</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Single Slider -->
    </div>
</section>
<!");
            WriteLiteral("--/ End Slider Area -->\r\n<!-- Start Schedule Area -->\r\n<section class=\"schedule\">\r\n    <div class=\"container\">\r\n        <div class=\"schedule-inner\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 115 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Home\Index.cshtml"
                 foreach (var i in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-4 col-md-12 col-12"">
                        <!-- single-schedule -->
                        <div class=""single-schedule last"">
                            <div class=""inner"">
                                <div class=""icon"">
                                    <i class=""icofont-ui-map""></i>
                                </div>
                                <div class=""single-content"">
                                    <span>Tên khoa</span>
                                    <h4>");
#nullable restore
#line 126 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Home\Index.cshtml"
                                   Write(i.TenKhoa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p>");
#nullable restore
#line 127 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Home\Index.cshtml"
                                  Write(i.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5670, "\"", 5677, 0);
            EndWriteAttribute();
            WriteLiteral(">XEM THÊM<i class=\"fa fa-long-arrow-right\"></i></a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 133 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Home\Index.cshtml"
                    if (i.IdKhoa > 2)
                    {
                        break;
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</section>
<!--/End Start schedule Area -->

<!-- Start Blog Area -->
<!-- End Appointment -->
<!-- Start Newsletter Area -->
<section class=""newsletter section"">
    <div class=""container"">
        <div class=""row "">
            <div class=""col-lg-6  col-12"">
                <!-- Start Newsletter Form -->
                <div class=""subscribe-text "">
                    <h6>Sign up for newsletter</h6>
                    <p");
            BeginWriteAttribute("class", " class=\"", 6494, "\"", 6502, 0);
            EndWriteAttribute();
            WriteLiteral(@">Cu qui soleat partiendo urbanitas. Eum aperiri indoctum eu,<br> homero alterum.</p>
                </div>
                <!-- End Newsletter Form -->
            </div>
            <div class=""col-lg-6  col-12"">
                <!-- Start Newsletter Form -->
                <div class=""subscribe-form "">
                    <form action=""mail/mail.php"" method=""get"" target=""_blank"" class=""newsletter-inner"">
                        <input name=""EMAIL"" placeholder=""Your email address"" class=""common-input"" onfocus=""this.placeholder = ''""
                               onblur=""this.placeholder = 'Your email address'""");
            BeginWriteAttribute("required", " required=\"", 7133, "\"", 7144, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""email"">
                        <button class=""btn"">Subscribe</button>
                    </form>
                </div>
                <!-- End Newsletter Form -->
            </div>
        </div>
    </div>
</section>
<!-- /End Newsletter Area -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QLSinhVien_ASP.NET_Core_EF.Models.Khoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
