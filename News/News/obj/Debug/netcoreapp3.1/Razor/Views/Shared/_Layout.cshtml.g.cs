#pragma checksum "D:\Programming\News\News\News\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dab2eba47502e5009a84ea399f59cbbfc2318a31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Programming\News\News\News\Views\_ViewImports.cshtml"
using News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\News\News\News\Views\_ViewImports.cshtml"
using News.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programming\News\News\News\Views\_ViewImports.cshtml"
using News.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dab2eba47502e5009a84ea399f59cbbfc2318a31", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c92fd0bad12c1bda5956e9226816dbf0857901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_GroupsInMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoggedInUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html class=\"no-js\" dir=\"rtl\" lang=\"fa-IR\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dab2eba47502e5009a84ea399f59cbbfc2318a315388", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <title> سایت خبری برنامه نویسان </title>\r\n    <base");
                BeginWriteAttribute("href", " href=\"", 153, "\"", 160, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""googlebot"" content=""index,follow"">
    <meta name=""robots"" content=""noodp,noydir"">
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/bootstrap.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/bootstrap-rtl.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/font-awesome.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/owl.carousel.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/style.css"">
    <script src=""/js/jquery.min.js""></script>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dab2eba47502e5009a84ea399f59cbbfc2318a317374", async() => {
                WriteLiteral(@"
    <script src=""js/modernizr.js""></script>

    <!-- Top Menu -->
    <div class=""top-menu"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 col-sm-6 col-xs-5"">
                    <ul>
                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1182, "\"", 1189, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-home\"></i></a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1258, "\"", 1265, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-question-circle\"></i></a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1345, "\"", 1352, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-envelope""></i></a></li>
                    </ul>
                </div>
                <div class=""col-md-6 col-sm-6 col-xs-7"">
                    <span>امروز : 18/08/1395</span>
                </div>
            </div>
        </div>
    </div>
    <!-- End Top Menu -->
    <!-- header -->
    <header class=""main-header"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 col-sm-6 col-xs-12"">
                    <a");
                BeginWriteAttribute("href", " href=\"", 1856, "\"", 1863, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"logo\"><img src=\"img/logo.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1901, "\"", 1907, 0);
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1908, "\"", 1916, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                    <div class=\"left-side\">\r\n                        <h1><a");
                BeginWriteAttribute("href", " href=\"", 1999, "\"", 2006, 0);
                EndWriteAttribute();
                WriteLiteral(@">سایت خبری برنامه نویسان</a></h1>
                        <h2> پایگاه اطلاع رسانی و خبری</h2>
                    </div>
                    <div class=""clearfix""></div>
                </div>
                <div class=""col-md-6 col-sm-6 col-xs-12"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dab2eba47502e5009a84ea399f59cbbfc2318a3110028", async() => {
                    WriteLiteral("\r\n                        <input class=\"border-radius\" name=\"q\" type=\"text\" placeholder=\" جستجو کنید ... \">\r\n                        <button><i class=\"fa fa-search\"></i></button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n    <!-- End Header -->\r\n    <!-- menu -->\r\n    <nav class=\"main-menu\">\r\n        <div class=\"container\">\r\n            <span><i class=\"fa fa-th-list\"></i></span>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dab2eba47502e5009a84ea399f59cbbfc2318a3112191", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </nav>\r\n    <!-- End menu -->\r\n\r\n    <div class=\"container margin-top-30\">\r\n        <div class=\"row\">\r\n\r\n            <aside class=\"col-md-4 col-sm-12 col-xs-12 pull-right\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dab2eba47502e5009a84ea399f59cbbfc2318a3113600", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
#nullable restore
#line 76 "D:\Programming\News\News\News\Views\Shared\_Layout.cshtml"
           Write(await Component.InvokeAsync("ShowGroups"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <!-- most views news -->\r\n                ");
#nullable restore
#line 78 "D:\Programming\News\News\News\Views\Shared\_Layout.cshtml"
           Write(await Component.InvokeAsync("ShowTopPages"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <!-- end most views news -->\r\n            </aside>\r\n\r\n\r\n            <div class=\"col-md-8 col-sm-12 col-xs-12 \">\r\n\r\n                ");
#nullable restore
#line 85 "D:\Programming\News\News\News\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

            </div>


        </div>
    </div>

    <footer>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 col-sm-12 col-xs-12"">
                    <section class=""access-links"">
                        <header> دسترسی سریع </header>
                        <ul>
                            <li><a");
                BeginWriteAttribute("href", " href=\"", 3771, "\"", 3778, 0);
                EndWriteAttribute();
                WriteLiteral("> صفحه اصلی </a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 3836, "\"", 3843, 0);
                EndWriteAttribute();
                WriteLiteral("> قوانین سایت  </a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 3904, "\"", 3911, 0);
                EndWriteAttribute();
                WriteLiteral("> راهنمای سایت  </a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 3973, "\"", 3980, 0);
                EndWriteAttribute();
                WriteLiteral("> پیوندهای سایت </a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4042, "\"", 4049, 0);
                EndWriteAttribute();
                WriteLiteral("> صفحه اصلی </a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4107, "\"", 4114, 0);
                EndWriteAttribute();
                WriteLiteral("> قوانین سایت  </a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4175, "\"", 4182, 0);
                EndWriteAttribute();
                WriteLiteral("> صفحه اصلی </a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4240, "\"", 4247, 0);
                EndWriteAttribute();
                WriteLiteral("> قوانین سایت  </a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4308, "\"", 4315, 0);
                EndWriteAttribute();
                WriteLiteral(@"> راهنمای سایت  </a></li>
                        </ul>
                    </section>
                </div>
                <div class=""col-md-5 col-md-offset-1 col-sm-12 col-xs-12"">
                    <div class=""socials"">
                        <span> شبکه های اجتماعی  سایت</span>
                        <a");
                BeginWriteAttribute("href", " href=\"", 4637, "\"", 4644, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-facebook\"></i></a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4708, "\"", 4715, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-twitter\"></i></a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4778, "\"", 4785, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-paper-plane\"></i></a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4852, "\"", 4859, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-google-plus""></i></a>
                        <div class=""clearfix""></div>
                    </div>
                    <p>
                        تمامی حقوق مادی و معنوی این طرح متعلق به آموزشگاه برنامه نویسان می باشد و کپی برداری از این طرح غیر اخلاقی می باشد.
                    </p>
                </div>
            </div>
        </div>
    </footer>

    <script src=""/js/bootstrap.min.js""></script>
    <script src=""/js/owl.carousel.js""></script>
    <script src=""/js/script.js""></script>
    ");
#nullable restore
#line 132 "D:\Programming\News\News\News\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
