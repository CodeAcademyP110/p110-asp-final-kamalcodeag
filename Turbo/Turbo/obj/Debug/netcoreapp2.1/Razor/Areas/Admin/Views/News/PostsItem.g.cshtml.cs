#pragma checksum "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\News\PostsItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38fcc7416d9edcc7daad9bb2c23ffc4643bc9cae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_PostsItem), @"mvc.1.0.view", @"/Areas/Admin/Views/News/PostsItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/News/PostsItem.cshtml", typeof(AspNetCore.Areas_Admin_Views_News_PostsItem))]
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
#line 1 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\_ViewImports.cshtml"
using Turbo;

#line default
#line hidden
#line 2 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\_ViewImports.cshtml"
using Turbo.Models;

#line default
#line hidden
#line 3 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\_ViewImports.cshtml"
using Turbo.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38fcc7416d9edcc7daad9bb2c23ffc4643bc9cae", @"/Areas/Admin/Views/News/PostsItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c383af6eaf3265923f4cd03e23ffb2457c273d81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_News_PostsItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsPost>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\News\PostsItem.cshtml"
  
    ViewData["Title"] = "PostsItem";

#line default
#line hidden
            BeginContext(65, 256, true);
            WriteLiteral(@"


    <section>
        <div class=""wrapper"">
            <div class=""products"">
                <div class=""row"">
                    <div class=""col-12 mb-3"">
                        <div class=""s-title-holder"">
                            <h3>");
            EndContext();
            BeginContext(322, 11, false);
#line 15 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\News\PostsItem.cshtml"
                           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(333, 191, true);
            WriteLiteral("</h3>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-12\">\r\n                        <div class=\"s-photo-holder\">\r\n                            ");
            EndContext();
            BeginContext(524, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8c2f79cd4194d3da80692747f502964", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 534, "~/img/", 534, 6, true);
#line 20 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\News\PostsItem.cshtml"
AddHtmlAttributeValue("", 540, Model.PhotoURL, 540, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(564, 219, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-12 mt-3\">\r\n                        <div class=\"s-info-holder\">\r\n                            <h6 style=\"font-weight:300;\">");
            EndContext();
            BeginContext(784, 17, false);
#line 25 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\News\PostsItem.cshtml"
                                                    Write(Model.MainArticle);

#line default
#line hidden
            EndContext();
            BeginContext(801, 126, true);
            WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"s-date-holder\">\r\n                            <span>");
            EndContext();
            BeginContext(928, 37, false);
#line 28 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\News\PostsItem.cshtml"
                             Write(Model.PublishDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(965, 186, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"clear\"></div>\r\n        </div>\r\n    </section>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsPost> Html { get; private set; }
    }
}
#pragma warning restore 1591
