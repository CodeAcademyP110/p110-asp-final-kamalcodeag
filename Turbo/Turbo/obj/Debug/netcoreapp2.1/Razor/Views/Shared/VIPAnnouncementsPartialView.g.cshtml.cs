#pragma checksum "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Shared\VIPAnnouncementsPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c153a85c6efedfbf997a5baacc716cd74e68342"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_VIPAnnouncementsPartialView), @"mvc.1.0.view", @"/Views/Shared/VIPAnnouncementsPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/VIPAnnouncementsPartialView.cshtml", typeof(AspNetCore.Views_Shared_VIPAnnouncementsPartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c153a85c6efedfbf997a5baacc716cd74e68342", @"/Views/Shared/VIPAnnouncementsPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c383af6eaf3265923f4cd03e23ffb2457c273d81", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_VIPAnnouncementsPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
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
            BeginContext(15, 72, true);
            WriteLiteral("\r\n<section>\r\n    <div class=\"wrapper\">\r\n        <div class=\"products\">\r\n");
            EndContext();
#line 6 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Shared\VIPAnnouncementsPartialView.cshtml"
             foreach (var announce in Model.VIPAnnouncements)
            {

#line default
#line hidden
            BeginContext(165, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(181, 1609, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baeb37e89b444010a20bec5db038855b", async() => {
                BeginContext(265, 193, true);
                WriteLiteral("\r\n                    <div class=\"productBorder\">\r\n                        <div class=\"onliCar\">\r\n                            <i class=\"far fa-heart likeIcon\"></i>\r\n                            ");
                EndContext();
                BeginContext(458, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "da736d27b6b3405098d5a2c90d1bf473", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 468, "~/img/", 468, 6, true);
#line 12 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Shared\VIPAnnouncementsPartialView.cshtml"
AddHtmlAttributeValue("", 474, announce.Automobile.MainPhotoURL, 474, 33, false);

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
                BeginContext(516, 90, true);
                WriteLiteral("\r\n                            <div class=\"productPrice\">\r\n                                ");
                EndContext();
                BeginContext(607, 25, false);
#line 14 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Shared\VIPAnnouncementsPartialView.cshtml"
                           Write(announce.Automobile.Price);

#line default
#line hidden
                EndContext();
                BeginContext(632, 162, true);
                WriteLiteral(" <span>AZN</span>\r\n                            </div>\r\n                            <div class=\"productsInfo\">\r\n                                <p class=\"carName\">");
                EndContext();
                BeginContext(795, 36, false);
#line 17 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Shared\VIPAnnouncementsPartialView.cshtml"
                                              Write(announce.Automobile.Model.Brand.Name);

#line default
#line hidden
                EndContext();
                BeginContext(831, 2, true);
                WriteLiteral("  ");
                EndContext();
                BeginContext(834, 30, false);
#line 17 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Shared\VIPAnnouncementsPartialView.cshtml"
                                                                                     Write(announce.Automobile.Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(864, 155, true);
                WriteLiteral("</p>\r\n                                <div class=\"carInfo\">\r\n                                    <p class=\"year\">\r\n                                        ");
                EndContext();
                BeginContext(1020, 44, false);
#line 20 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Shared\VIPAnnouncementsPartialView.cshtml"
                                   Write(announce.Automobile.Year.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(1064, 199, true);
                WriteLiteral(" il\r\n\r\n                                        <span></span>\r\n                                    </p>\r\n                                    <p class=\"engin\">\r\n                                        ");
                EndContext();
                BeginContext(1264, 25, false);
#line 25 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Shared\VIPAnnouncementsPartialView.cshtml"
                                   Write(announce.Automobile.Motor);

#line default
#line hidden
                EndContext();
                BeginContext(1289, 151, true);
                WriteLiteral(" L\r\n                                        <span></span>\r\n                                    </p>\r\n                                    <p class=\"km\">");
                EndContext();
                BeginContext(1441, 28, false);
#line 28 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Shared\VIPAnnouncementsPartialView.cshtml"
                                             Write(announce.Automobile.Distance);

#line default
#line hidden
                EndContext();
                BeginContext(1469, 104, true);
                WriteLiteral(" km </p>\r\n                                </div>\r\n                                <div class=\"enterDay\">");
                EndContext();
                BeginContext(1574, 22, false);
#line 30 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Shared\VIPAnnouncementsPartialView.cshtml"
                                                 Write(announce.Location.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1596, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(1599, 40, false);
#line 30 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Shared\VIPAnnouncementsPartialView.cshtml"
                                                                          Write(announce.PublishDate.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(1639, 147, true);
                WriteLiteral(" <i class=\"fas fa-gem\"></i></div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
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
#line 8 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Shared\VIPAnnouncementsPartialView.cshtml"
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
            BeginContext(1790, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Shared\VIPAnnouncementsPartialView.cshtml"
            }

#line default
#line hidden
            BeginContext(1807, 75, true);
            WriteLiteral("        </div>\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
