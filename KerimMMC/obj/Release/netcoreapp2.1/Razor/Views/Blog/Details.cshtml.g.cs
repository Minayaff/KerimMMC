#pragma checksum "C:\Users\Mina\Desktop\KerimMMCLang\KerimMMC\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c3c82b7435ae75ef25cfe7a996802f769af9015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Details.cshtml", typeof(AspNetCore.Views_Blog_Details))]
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
#line 1 "C:\Users\Mina\Desktop\KerimMMCLang\KerimMMC\Views\_ViewImports.cshtml"
using KerimMMC;

#line default
#line hidden
#line 2 "C:\Users\Mina\Desktop\KerimMMCLang\KerimMMC\Views\_ViewImports.cshtml"
using KerimMMC.Models;

#line default
#line hidden
#line 3 "C:\Users\Mina\Desktop\KerimMMCLang\KerimMMC\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 4 "C:\Users\Mina\Desktop\KerimMMCLang\KerimMMC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c3c82b7435ae75ef25cfe7a996802f769af9015", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0368538f49051c9112b20c3ad58fce8c1004f976", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KerimMMC.Models.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Mina\Desktop\KerimMMCLang\KerimMMC\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(133, 553, true);
            WriteLiteral(@"
<!--    Main Area Start   -->
<main>
    <!--    Breadcrumb Area Start   -->
    <section class=""breadcrumb-area pt-180 pb-180 pb-md-150 pt-md-150 pb-xs-100 pt-xs-100"" data-overlay=""dark""
             data-opacity=""9"" style=""background-image: url(/images/bg/breadcrumb-bg-1.jpg)"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-lg-8 text-center"">
                    <div class=""breadcrumb-content"">
                        <h3 class=""title"">
                            ");
            EndContext();
            BeginContext(687, 23, false);
#line 18 "C:\Users\Mina\Desktop\KerimMMCLang\KerimMMC\Views\Blog\Details.cshtml"
                       Write(SharedLocalizer["blog"]);

#line default
#line hidden
            EndContext();
            BeginContext(710, 95, true);
            WriteLiteral("\r\n                        </h3>\r\n                        <ul>\r\n                            <li>");
            EndContext();
            BeginContext(805, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1466c8756223477ab1537e9f023eee9b", async() => {
                BeginContext(851, 27, false);
#line 21 "C:\Users\Mina\Desktop\KerimMMCLang\KerimMMC\Views\Blog\Details.cshtml"
                                                                        Write(SharedLocalizer["mainPage"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(882, 88, true);
            WriteLiteral("</li>\r\n                            <li class=\"active\">\r\n                                ");
            EndContext();
            BeginContext(971, 23, false);
#line 23 "C:\Users\Mina\Desktop\KerimMMCLang\KerimMMC\Views\Blog\Details.cshtml"
                           Write(SharedLocalizer["blog"]);

#line default
#line hidden
            EndContext();
            BeginContext(994, 653, true);
            WriteLiteral(@"
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--    Breadcrumb Area Start   -->
    <!--    Team Area Start   -->
    <div class=""blog-area pt-120 pb-40 pt-md-80 pt-xs-80"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-12 col-lg-12	"">
                    <div class=""blog-box-wrapper"">
                        <div class=""blog-single-details"">
                            <div class=""blog-box-thumb"" style=""text-align: center;"">
                                ");
            EndContext();
            BeginContext(1647, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "240bed0772964952bbd6a69bbe1d2a98", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1657, "~/images/blog/", 1657, 14, true);
#line 40 "C:\Users\Mina\Desktop\KerimMMCLang\KerimMMC\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 1671, Model.Image, 1671, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1698, 285, true);
            WriteLiteral(@"
                            </div>
                            <div class=""blog-box-details"">
                                <div class=""blog-box-meta"">
                                    <div class=""blog-meta-date"">
                                        <a href=""blog.html"">");
            EndContext();
            BeginContext(1984, 37, false);
#line 45 "C:\Users\Mina\Desktop\KerimMMCLang\KerimMMC\Views\Blog\Details.cshtml"
                                                       Write(Model.CreatedDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2021, 429, true);
            WriteLiteral(@"</a>
                                    </div>
                                    <div class=""blog-meta-user"">
                                        <a><i class=""fal fa-user""></i> BY ADMIN</a>
                                    </div>
                                </div>
                                <div class=""blog-box-title"">
                                    <h3>
                                        ");
            EndContext();
            BeginContext(2451, 14, false);
#line 53 "C:\Users\Mina\Desktop\KerimMMCLang\KerimMMC\Views\Blog\Details.cshtml"
                                   Write(Model.HeadText);

#line default
#line hidden
            EndContext();
            BeginContext(2465, 230, true);
            WriteLiteral("\r\n                                    </h3>\r\n                                </div>\r\n                                <div class=\"blog-box-content\">\r\n                                    <p>\r\n                                        ");
            EndContext();
            BeginContext(2696, 10, false);
#line 58 "C:\Users\Mina\Desktop\KerimMMCLang\KerimMMC\Views\Blog\Details.cshtml"
                                   Write(Model.Text);

#line default
#line hidden
            EndContext();
            BeginContext(2706, 327, true);
            WriteLiteral(@"
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--    Team Area End    -->

</main>
<!--    Main Area End    -->
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<SharedResources> SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KerimMMC.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
