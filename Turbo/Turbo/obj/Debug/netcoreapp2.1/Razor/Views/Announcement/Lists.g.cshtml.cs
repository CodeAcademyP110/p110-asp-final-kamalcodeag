#pragma checksum "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\Lists.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a6b43186e358a28895c9f6160f0978310409bea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Announcement_Lists), @"mvc.1.0.view", @"/Views/Announcement/Lists.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Announcement/Lists.cshtml", typeof(AspNetCore.Views_Announcement_Lists))]
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
#line 1 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\_ViewImports.cshtml"
using Turbo;

#line default
#line hidden
#line 2 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\_ViewImports.cshtml"
using Turbo.Models;

#line default
#line hidden
#line 3 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\_ViewImports.cshtml"
using Turbo.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a6b43186e358a28895c9f6160f0978310409bea", @"/Views/Announcement/Lists.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c383af6eaf3265923f4cd03e23ffb2457c273d81", @"/Views/_ViewImports.cshtml")]
    public class Views_Announcement_Lists : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Announcement>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Announcement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListsItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 84, true);
            WriteLiteral("\r\n    <section>\r\n        <div class=\"wrapper\">\r\n            <div class=\"products\">\r\n");
            EndContext();
#line 6 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\Lists.cshtml"
                 foreach (var announce in Model)
                {

#line default
#line hidden
            BeginContext(188, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(208, 1709, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63081c67fdbb47ee8131752a97efdafe", async() => {
                BeginContext(292, 209, true);
                WriteLiteral("\r\n                        <div class=\"productBorder\">\r\n                            <div class=\"onliCar\">\r\n                                <i class=\"far fa-heart likeIcon\"></i>\r\n                                ");
                EndContext();
                BeginContext(501, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e1082c91d80e4c4bb73fabe51b3fce8f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 511, "~/img/", 511, 6, true);
#line 12 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\Lists.cshtml"
AddHtmlAttributeValue("", 517, announce.Automobile.MainPhotoURL, 517, 33, false);

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
                BeginContext(559, 98, true);
                WriteLiteral("\r\n                                <div class=\"productPrice\">\r\n                                    ");
                EndContext();
                BeginContext(658, 25, false);
#line 14 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\Lists.cshtml"
                               Write(announce.Automobile.Price);

#line default
#line hidden
                EndContext();
                BeginContext(683, 174, true);
                WriteLiteral(" <span>AZN</span>\r\n                                </div>\r\n                                <div class=\"productsInfo\">\r\n                                    <p class=\"carName\">");
                EndContext();
                BeginContext(858, 36, false);
#line 17 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\Lists.cshtml"
                                                  Write(announce.Automobile.Model.Brand.Name);

#line default
#line hidden
                EndContext();
                BeginContext(894, 2, true);
                WriteLiteral("  ");
                EndContext();
                BeginContext(897, 30, false);
#line 17 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\Lists.cshtml"
                                                                                         Write(announce.Automobile.Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(927, 167, true);
                WriteLiteral("</p>\r\n                                    <div class=\"carInfo\">\r\n                                        <p class=\"year\">\r\n                                            ");
                EndContext();
                BeginContext(1095, 44, false);
#line 20 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\Lists.cshtml"
                                       Write(announce.Automobile.Year.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(1139, 215, true);
                WriteLiteral(" il\r\n\r\n                                            <span></span>\r\n                                        </p>\r\n                                        <p class=\"engin\">\r\n                                            ");
                EndContext();
                BeginContext(1355, 25, false);
#line 25 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\Lists.cshtml"
                                       Write(announce.Automobile.Motor);

#line default
#line hidden
                EndContext();
                BeginContext(1380, 163, true);
                WriteLiteral(" L\r\n                                            <span></span>\r\n                                        </p>\r\n                                        <p class=\"km\">");
                EndContext();
                BeginContext(1544, 28, false);
#line 28 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\Lists.cshtml"
                                                 Write(announce.Automobile.Distance);

#line default
#line hidden
                EndContext();
                BeginContext(1572, 112, true);
                WriteLiteral(" km </p>\r\n                                    </div>\r\n                                    <div class=\"enterDay\">");
                EndContext();
                BeginContext(1685, 22, false);
#line 30 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\Lists.cshtml"
                                                     Write(announce.Location.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1707, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(1710, 40, false);
#line 30 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\Lists.cshtml"
                                                                              Write(announce.PublishDate.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(1750, 163, true);
                WriteLiteral(" <i class=\"fas fa-gem\"></i></div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 8 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\Lists.cshtml"
                                                                              WriteLiteral(announce.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1917, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\Lists.cshtml"
                }

#line default
#line hidden
            BeginContext(1938, 89, true);
            WriteLiteral("            </div>\r\n            <div class=\"clear\"></div>\r\n        </div>\r\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Announcement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
