#pragma checksum "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\LopSHManage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cd0a051a4d26a592739601f897914be6994c8f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_LopSHManage), @"mvc.1.0.view", @"/Views/Manage/LopSHManage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cd0a051a4d26a592739601f897914be6994c8f1", @"/Views/Manage/LopSHManage.cshtml")]
    public class Views_Manage_LopSHManage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QLSinhVien_ASP.NET_Core_EF.ViewModels.LopSHViewModels>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo_dhdn1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px;height:75px; object-fit:contain"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/section-img.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\LopSHManage.cshtml"
  
    ViewData["Title"] = "LopSHManage";
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2cd0a051a4d26a592739601f897914be6994c8f14931", async() => {
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
                                    <li class=""active""><a href=""#"">Trang chủ</a></li>
                                    <li><a href=""#"">Giới thiệu </a></li>
                                    <li><a href=""/Home/ChuNhaXe"">Nhà xe </a></li>
                                    <li><a href=""Home/QLLichTrinh"">Chuyến xe </a></li>
                                    <li><a href=""/Home/TaiXeInfor"">Tài xế </a></li>
                                    <li><a href=""contact.html"">Liên hệ</a></li>
     ");
            WriteLiteral(@"                           </ul>
                            </nav>
                        </div>
                        <!--/ End Main Menu -->
                    </div>
                    <div class=""col-lg-2 col-12"">
                        <div class=""get-quote"">
                            <a href=""/Home/LoginPage"" class=""btn"">Đăng nhập</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--/ End Header Inner -->
</header>
<!-- End Header Area -->
<section class=""Feautes section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title"" style=""margin-top:50px"">
                    <h2>Danh sách lớp sinh hoạt</h2>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2cd0a051a4d26a592739601f897914be6994c8f18057", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        <div class=""row"" style=""justify-content: end;"">
            <div style=""margin-right: 15px;"">
                <form action=""/Home/ChuNhaXeSearch"">
                    <input name=""s"" type=""text"" placeholder=""Tìm kiếm"" style=""padding: 10px; width: 400px;"">
                </form>
            </div>
        </div>
    </div>
</section>
<!-- Single News -->

<section class=""news-single section"">
    <div class=""container"" style=""max-width: 2000px; "">
        <div class=""row"">
            <div class=""col-lg-2 col-12"">
                <div class=""main-sidebar"">
                    <div class=""single-widget category"">
                        <h3 class=""title"">Quản lý</h3>
                        <ul class=""categor-list"">
                            <li><a href=""/Manage/AddLopSh"">Thêm lớp sinh hoạt</a></li>
                        </ul>
                    </div>
                </div>
            </div>

            <div ");
            WriteLiteral(@"class=""col-lg-10 col-12"">
                <div class=""main-sidebar"">
                    <div class=""single-widget category"">
                        <table>
                            <tr>
                                <th>Tên lớp</th>
                                <th>Mô tả</th>
                                <th>Giáo viên chủ nhiệm</th>
                                <th>Số lượng sinh viên</th>
                                <th></th>

                            </tr>
");
#nullable restore
#line 100 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\LopSHManage.cshtml"
                             foreach (var i in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 103 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\LopSHManage.cshtml"
                                   Write(i.TenLopSh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 104 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\LopSHManage.cshtml"
                                   Write(i.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 105 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\LopSHManage.cshtml"
                                   Write(i.TenGiaoVien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 106 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\LopSHManage.cshtml"
                                   Write(i.SLSinhVien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4562, "\"", 4600, 2);
            WriteAttributeValue("", 4569, "/Manage/EditLopSH?id=", 4569, 21, true);
#nullable restore
#line 108 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\LopSHManage.cshtml"
WriteAttributeValue("", 4590, i.IdLopSh, 4590, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a> |\r\n                                        <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4664, "\"", 4699, 3);
            WriteAttributeValue("", 4674, "confirmDelete(", 4674, 14, true);
#nullable restore
#line 109 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\LopSHManage.cshtml"
WriteAttributeValue("", 4688, i.IdLopSh, 4688, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4698, ")", 4698, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 113 "E:\Document\C#_Saver\QLSinhVien_BTCK_Csharp\QLSinhVien_ASP.NET_Core_EF\QLSinhVien_ASP.NET_Core_EF\Views\Manage\LopSHManage.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>

</section>
<script>



    function confirmDelete(id) {
        var result = confirm(""Bạn có muốn xóa lớp này không?"");
        if (result) {
            window.location.href = ""/Manage/DeleteLopSH?id="" + id;
        }
    }


</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QLSinhVien_ASP.NET_Core_EF.ViewModels.LopSHViewModels>> Html { get; private set; }
    }
}
#pragma warning restore 1591
