#pragma checksum "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\AddSV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f52fcc1753111682717d3eaf6d5d0194509b42a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_AddSV), @"mvc.1.0.view", @"/Views/Manage/AddSV.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f52fcc1753111682717d3eaf6d5d0194509b42a", @"/Views/Manage/AddSV.cshtml")]
    public class Views_Manage_AddSV : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<QLSinhVien_ASP.NET_Core_EF.Models.Khoa>, List<QLSinhVien_ASP.NET_Core_EF.Models.LopSh>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo-benxe.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:133px;height:60px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\AddSV.cshtml"
  
    ViewData["Title"] = "AddSV";
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f52fcc1753111682717d3eaf6d5d0194509b42a4542", async() => {
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
                                    <li ><a href=""/Home/GVList"">Giáo viên </a></li>
                                    <li><a href=""/Home/SVList"">Sinh viên </a></li>
                                    <li><a href=""#"">Lớp sinh hoạt </a></li>
                                    <li><a href=""LopHPList"">Lớp HP</a></li>
                 ");
            WriteLiteral(@"               </ul>
                            </nav>
                        </div>
                        <!--/ End Main Menu -->
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--/ End Header Inner -->
</header>
<!-- End Header Area -->
<section class=""contact-us section"">
    <div class=""container"">
        <div class=""inner"">
            <div class=""row"" style=""justify-content: center; padding-bottom: 300px;"">
                <div class=""col-lg-8"">
                    <div class=""contact-us-form"">
                        <h2>Thêm sinh viên</h2>
                        <!-- Form -->
                        <form class=""form"" method=""post"" action=""/Manage/AddSV"">
                            <div class=""row"">

                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label>Tên sinh viên</label>
                                   ");
            WriteLiteral("     <input type=\"text\" name=\"tensv\"");
            BeginWriteAttribute("required", " required=\"", 2793, "\"", 2804, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label>Ngày sinh</label>
                                        <input type=""date"" name=""ngaysinh""");
            BeginWriteAttribute("required", " required=\"", 3150, "\"", 3161, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label>SDT</label>
                                        <input type=""text"" name=""sdt""");
            BeginWriteAttribute("required", " required=\"", 3498, "\"", 3509, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label>Email</label>
                                        <input type=""text"" name=""email""");
            BeginWriteAttribute("required", " required=\"", 3848, "\"", 3859, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">

                                        <select name=""idkhoa"">
");
#nullable restore
#line 88 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\AddSV.cshtml"
                                             foreach (var item in Model.Item1)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <option");
            BeginWriteAttribute("value", " value=\"", 4313, "\"", 4333, 1);
#nullable restore
#line 90 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\AddSV.cshtml"
WriteAttributeValue("", 4321, item.IdKhoa, 4321, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 90 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\AddSV.cshtml"
                                                                        Write(item.TenKhoa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 91 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\AddSV.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </select>
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">

                                        <select name=""idlopsh"">
");
#nullable restore
#line 99 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\AddSV.cshtml"
                                             foreach (var item in Model.Item2)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <option");
            BeginWriteAttribute("value", " value=\"", 4908, "\"", 4929, 1);
#nullable restore
#line 101 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\AddSV.cshtml"
WriteAttributeValue("", 4916, item.IdLopSh, 4916, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 101 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\AddSV.cshtml"
                                                                         Write(item.TenLopSh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 102 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\AddSV.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </select>
                                    </div>
                                </div>
                                <div class=""col-12"">
                                    <div class=""form-group login-btn"">
                                        <button class=""btn"" type=""submit"">Thêm mới</button>
                                    </div>

                                </div>
                            </div>
                        </form>
                        <!--/ End Form -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<QLSinhVien_ASP.NET_Core_EF.Models.Khoa>, List<QLSinhVien_ASP.NET_Core_EF.Models.LopSh>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
