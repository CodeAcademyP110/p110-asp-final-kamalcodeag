#pragma checksum "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dac822fa661348922f5b8a24e293f97419e25f77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Announcement_ListsItem), @"mvc.1.0.view", @"/Views/Announcement/ListsItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Announcement/ListsItem.cshtml", typeof(AspNetCore.Views_Announcement_ListsItem))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dac822fa661348922f5b8a24e293f97419e25f77", @"/Views/Announcement/ListsItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c383af6eaf3265923f4cd03e23ffb2457c273d81", @"/Views/_ViewImports.cshtml")]
    public class Views_Announcement_ListsItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Announcement>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(22, 218, true);
            WriteLiteral("\r\n\r\n<section>\r\n    <div class=\"wrapper\">\r\n        <div class=\"products s-list-item-bold\">\r\n            <div class=\"product\" style=\"\r\n    display: flex;\r\n    flex-direction: column;\r\n\"><div class=\"product-photos\">\r\n    ");
            EndContext();
            BeginContext(240, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "028f490413b44850a5f6a2c5566fcb16", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 257, "~/img/", 257, 6, true);
#line 11 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
AddHtmlAttributeValue("", 263, Model.Automobile.MainPhotoURL, 263, 30, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(316, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 13 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
     foreach (var photo in Model.Automobile.AutoPhotos)
    {

#line default
#line hidden
            BeginContext(384, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(392, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c7446ace6ae412fa945c6ae821b112f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 409, "~/img/", 409, 6, true);
#line 15 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
AddHtmlAttributeValue("", 415, photo.PhotoURL, 415, 15, false);

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
            BeginContext(453, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"

    }

#line default
#line hidden
            BeginContext(464, 216, true);
            WriteLiteral("    <div class=\"product-photos-thumbnails product-photos-thumbnails_m\" style=\"\r\n    margin-top: 10px;\r\n\"></div>\r\n</div><h3 class=\"product-name product-name-row\" style=\"\r\n    margin-top: 30px;\r\n\">\r\n                   ");
            EndContext();
            BeginContext(681, 33, false);
#line 24 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
              Write(Model.Automobile.Model.Brand.Name);

#line default
#line hidden
            EndContext();
            BeginContext(714, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(717, 27, false);
#line 24 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
                                                  Write(Model.Automobile.Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(744, 21, true);
            WriteLiteral(", <span class=\"nobr\">");
            EndContext();
            BeginContext(766, 22, false);
#line 24 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
                                                                                                   Write(Model.Automobile.Motor);

#line default
#line hidden
            EndContext();
            BeginContext(788, 30, true);
            WriteLiteral(" L</span>, <span class=\"nobr\">");
            EndContext();
            BeginContext(819, 26, false);
#line 24 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
                                                                                                                                                        Write(Model.Automobile.Year.Year);

#line default
#line hidden
            EndContext();
            BeginContext(845, 31, true);
            WriteLiteral(" il</span>, <span class=\"nobr\">");
            EndContext();
            BeginContext(877, 25, false);
#line 24 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
                                                                                                                                                                                                                  Write(Model.Automobile.Distance);

#line default
#line hidden
            EndContext();
            BeginContext(902, 244, true);
            WriteLiteral(" km</span>\r\n                </h3><div class=\"product-header\" style=\"\r\n    display: flex;\r\n    height: 100px;\r\n\">\r\n                         <h3 class=\"product-price\" style=\"\r\n    width: 20%;\r\n    height: 100px;\r\n\">\r\n                             ");
            EndContext();
            BeginContext(1147, 22, false);
#line 33 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
                        Write(Model.Automobile.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1169, 482, true);
            WriteLiteral(@" AZN
                         </h3><div class=""product-statistics""></div>
                </div><div class=""product-body"" style=""
    display: flex;
"">
                    <div class=""product-properties-container"" style=""
    display: flex;
    width: 100%;
    /* height: 100px; */
    /* position: relative; */
    bottom: 50px;
""><ul class=""product-properties""><li class=""product-properties-i""><label for=""ad_region"">Şəhər</label><div class=""product-properties-value"">");
            EndContext();
            BeginContext(1652, 19, false);
#line 44 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
                                                                                                                                       Write(Model.Location.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1671, 213, true);
            WriteLiteral("</div></li>\r\n                        <li class=\"product-properties-i\"><label for=\"ad_make_id\">Marka</label>\r\n                        <div class=\"product-properties-value\"><a target=\"_blank\" href=\"/makes/14-lexus\">");
            EndContext();
            BeginContext(1885, 33, false);
#line 46 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
                                                                                                   Write(Model.Automobile.Model.Brand.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1918, 254, true);
            WriteLiteral("</a></div></li>\r\n                        <li class=\"product-properties-i\"><label for=\"ad_model\">Model</label>\r\n                        <div class=\"product-properties-value\"><a target=\"_blank\" href=\"/autos?q%5Bmake%5D%5B%5D=14&amp;q%5Bmodel%5D%5B%5D=471\">");
            EndContext();
            BeginContext(2173, 27, false);
#line 48 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
                                                                                                                                          Write(Model.Automobile.Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2200, 289, true);
            WriteLiteral(@"</a></div></li>
                        <li class=""product-properties-i""><label for=""ad_reg_year"">Buraxılış ili</label><div class=""product-properties-value""><a target=""_blank"" href=""/autos?q%5Bmake%5D%5B%5D=14&amp;q%5Bmodel%5D%5B%5D=471&amp;q%5Byear_from%5D=2016&amp;q%5Byear_to%5D=2016"">");
            EndContext();
            BeginContext(2490, 26, false);
#line 49 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
                                                                                                                                                                                                                                                                           Write(Model.Automobile.Year.Year);

#line default
#line hidden
            EndContext();
            BeginContext(2516, 146, true);
            WriteLiteral("</a></div></li>\r\n                        <li class=\"product-properties-i\"><label for=\"ad_color\">Rəng</label><div class=\"product-properties-value\">");
            EndContext();
            BeginContext(2663, 27, false);
#line 50 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
                                                                                                                            Write(Model.Automobile.Color.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2690, 162, true);
            WriteLiteral("</div></li>\r\n                        <li class=\"product-properties-i\"><label for=\"ad_engine_volume\">Mühərrikin həcmi</label><div class=\"product-properties-value\">");
            EndContext();
            BeginContext(2853, 22, false);
#line 51 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
                                                                                                                                                Write(Model.Automobile.Motor);

#line default
#line hidden
            EndContext();
            BeginContext(2875, 156, true);
            WriteLiteral(" L</div></li>\r\n                        <li class=\"product-properties-i\"><label for=\"ad_fuel_type\">Yanacaq növü</label><div class=\"product-properties-value\">");
            EndContext();
            BeginContext(3032, 26, false);
#line 52 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
                                                                                                                                        Write(Model.Automobile.Fuel.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3058, 145, true);
            WriteLiteral("</div></li><li class=\"product-properties-i\">\r\n                        <label for=\"ad_mileage\">Yürüş</label><div class=\"product-properties-value\">");
            EndContext();
            BeginContext(3204, 25, false);
#line 53 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
                                                                                              Write(Model.Automobile.Distance);

#line default
#line hidden
            EndContext();
            BeginContext(3229, 392, true);
            WriteLiteral(@" km</div></li>
                        <li class=""product-properties-i""><label for=""ad_transmission"">Sürətlər qutusu</label><div class=""product-properties-value"">Avtomat</div></li>
                        <li class=""product-properties-i product-properties_price"">
                        <label for=""ad_price"">Qiymət</label><div class=""product-properties-value""><div class=""product-price"">");
            EndContext();
            BeginContext(3622, 22, false);
#line 56 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
                                                                                                                        Write(Model.Automobile.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3644, 223, true);
            WriteLiteral(" <span>AZN</span></div></div></li></ul>\r\n                        </div><div class=\"product-description\" style=\"\r\n    /* display: block; */\r\n    width: 100%;\r\n\">\r\n    <h6 class=\"product-text\" style=\"width: 600px;\">\r\n        ");
            EndContext();
            BeginContext(3868, 25, false);
#line 62 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Views\Announcement\ListsItem.cshtml"
   Write(Model.Automobile.FullInfo);

#line default
#line hidden
            EndContext();
            BeginContext(3893, 158, true);
            WriteLiteral("\r\n    </h6>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Announcement> Html { get; private set; }
    }
}
#pragma warning restore 1591
