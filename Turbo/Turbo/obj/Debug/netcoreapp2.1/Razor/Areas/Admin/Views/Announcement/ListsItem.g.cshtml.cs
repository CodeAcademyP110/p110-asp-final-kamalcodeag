#pragma checksum "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af7a6ce29d4d5301f3ed2db06119c41d6994d565"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Announcement_ListsItem), @"mvc.1.0.view", @"/Areas/Admin/Views/Announcement/ListsItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Announcement/ListsItem.cshtml", typeof(AspNetCore.Areas_Admin_Views_Announcement_ListsItem))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7a6ce29d4d5301f3ed2db06119c41d6994d565", @"/Areas/Admin/Views/Announcement/ListsItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c383af6eaf3265923f4cd03e23ffb2457c273d81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Announcement_ListsItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Announcement>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(21, 252, true);
            WriteLiteral("\r\n\r\n<section>\r\n    <div class=\"wrapper\">\r\n        <div class=\"products s-list-item-bold\">\r\n            <div class=\"product\" style=\"\r\n    display: flex;\r\n    flex-direction: column;\r\n\">\r\n                <div class=\"product-photos\">\r\n                    ");
            EndContext();
            BeginContext(273, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "73f4b84f69824d1bb7b814207d1bde4d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 290, "~/img/", 290, 6, true);
#line 12 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
AddHtmlAttributeValue("", 296, Model.Automobile.MainPhotoURL, 296, 30, false);

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
            BeginContext(349, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 14 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                     foreach (var photo in Model.Automobile.AutoPhotos)
                    {

#line default
#line hidden
            BeginContext(449, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(473, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "501248fb926645079b7af983cab1a4e3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 490, "~/img/", 490, 6, true);
#line 16 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
AddHtmlAttributeValue("", 496, photo.PhotoURL, 496, 15, false);

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
            BeginContext(534, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"

                    }

#line default
#line hidden
            BeginContext(561, 245, true);
            WriteLiteral("                    <div class=\"product-photos-thumbnails product-photos-thumbnails_m\" style=\"\r\n    margin-top: 10px;\r\n\"></div>\r\n                </div><h3 class=\"product-name product-name-row\" style=\"\r\n    margin-top: 30px;\r\n\">\r\n                ");
            EndContext();
            BeginContext(808, 41, false);
#line 25 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
            Write(Model.IsVIP == true ? "VIP elan - " : " ");

#line default
#line hidden
            EndContext();
            BeginContext(850, 5, true);
            WriteLiteral("     ");
            EndContext();
            BeginContext(856, 33, false);
#line 25 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                                                            Write(Model.Automobile.Model.Brand.Name);

#line default
#line hidden
            EndContext();
            BeginContext(889, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(892, 27, false);
#line 25 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                                                                                                Write(Model.Automobile.Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(919, 21, true);
            WriteLiteral(", <span class=\"nobr\">");
            EndContext();
            BeginContext(941, 22, false);
#line 25 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                                                                                                                                                 Write(Model.Automobile.Motor);

#line default
#line hidden
            EndContext();
            BeginContext(963, 30, true);
            WriteLiteral(" L</span>, <span class=\"nobr\">");
            EndContext();
            BeginContext(994, 26, false);
#line 25 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                                                                                                                                                                                                      Write(Model.Automobile.Year.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1020, 31, true);
            WriteLiteral(" il</span>, <span class=\"nobr\">");
            EndContext();
            BeginContext(1052, 25, false);
#line 25 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                                                                                                                                                                                                                                                                Write(Model.Automobile.Distance);

#line default
#line hidden
            EndContext();
            BeginContext(1077, 234, true);
            WriteLiteral(" km</span>\r\n                </h3><div class=\"product-header\" style=\"\r\n    display: flex;\r\n    height: 100px;\r\n\">\r\n                    <h3 class=\"product-price\" style=\"\r\n    width: 20%;\r\n    height: 100px;\r\n\">\r\n                        ");
            EndContext();
            BeginContext(1312, 22, false);
#line 34 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                   Write(Model.Automobile.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1334, 533, true);
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
"">
                        <ul class=""product-properties"">
                            <li class=""product-properties-i""><label for=""ad_region"">Şəhər</label><div class=""product-properties-value"">");
            EndContext();
            BeginContext(1868, 19, false);
#line 47 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                                                                                                                                  Write(Model.Location.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1887, 259, true);
            WriteLiteral(@"</div></li>
                            <li class=""product-properties-i"">
                                <label for=""ad_make_id"">Marka</label>
                                <div class=""product-properties-value""><a target=""_blank"" href=""/makes/14-lexus"">");
            EndContext();
            BeginContext(2147, 33, false);
#line 50 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                                                                                                           Write(Model.Automobile.Model.Brand.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2180, 330, true);
            WriteLiteral(@"</a></div>
                            </li>
                            <li class=""product-properties-i"">
                                <label for=""ad_model"">Model</label>
                                <div class=""product-properties-value""><a target=""_blank"" href=""/autos?q%5Bmake%5D%5B%5D=14&amp;q%5Bmodel%5D%5B%5D=471"">");
            EndContext();
            BeginContext(2511, 27, false);
#line 54 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                                                                                                                                                  Write(Model.Automobile.Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2538, 323, true);
            WriteLiteral(@"</a></div>
                            </li>
                            <li class=""product-properties-i""><label for=""ad_reg_year"">Buraxılış ili</label><div class=""product-properties-value""><a target=""_blank"" href=""/autos?q%5Bmake%5D%5B%5D=14&amp;q%5Bmodel%5D%5B%5D=471&amp;q%5Byear_from%5D=2016&amp;q%5Byear_to%5D=2016"">");
            EndContext();
            BeginContext(2862, 26, false);
#line 56 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                                                                                                                                                                                                                                                                               Write(Model.Automobile.Year.Year);

#line default
#line hidden
            EndContext();
            BeginContext(2888, 150, true);
            WriteLiteral("</a></div></li>\r\n                            <li class=\"product-properties-i\"><label for=\"ad_color\">Rəng</label><div class=\"product-properties-value\">");
            EndContext();
            BeginContext(3039, 27, false);
#line 57 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                                                                                                                                Write(Model.Automobile.Color.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3066, 166, true);
            WriteLiteral("</div></li>\r\n                            <li class=\"product-properties-i\"><label for=\"ad_engine_volume\">Mühərrikin həcmi</label><div class=\"product-properties-value\">");
            EndContext();
            BeginContext(3233, 22, false);
#line 58 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                                                                                                                                                    Write(Model.Automobile.Motor);

#line default
#line hidden
            EndContext();
            BeginContext(3255, 160, true);
            WriteLiteral(" L</div></li>\r\n                            <li class=\"product-properties-i\"><label for=\"ad_fuel_type\">Yanacaq növü</label><div class=\"product-properties-value\">");
            EndContext();
            BeginContext(3416, 26, false);
#line 59 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                                                                                                                                            Write(Model.Automobile.Fuel.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3442, 183, true);
            WriteLiteral("</div></li>\r\n                            <li class=\"product-properties-i\">\r\n                                <label for=\"ad_mileage\">Yürüş</label><div class=\"product-properties-value\">");
            EndContext();
            BeginContext(3626, 25, false);
#line 61 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                                                                                                      Write(Model.Automobile.Distance);

#line default
#line hidden
            EndContext();
            BeginContext(3651, 438, true);
            WriteLiteral(@" km</div>
                            </li>
                            <li class=""product-properties-i""><label for=""ad_transmission"">Sürətlər qutusu</label><div class=""product-properties-value"">Avtomat</div></li>
                            <li class=""product-properties-i product-properties_price"">
                                <label for=""ad_price"">Qiymət</label><div class=""product-properties-value""><div class=""product-price"">");
            EndContext();
            BeginContext(4090, 22, false);
#line 65 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
                                                                                                                                Write(Model.Automobile.Price);

#line default
#line hidden
            EndContext();
            BeginContext(4112, 275, true);
            WriteLiteral(@" <span>AZN</span></div></div>
                            </li>
                        </ul>
                    </div><div class=""product-description"" style=""
    /* display: block; */
    width: 100%;
"">
    <h6 class=""product-text"" style=""width: 600px;"">
        ");
            EndContext();
            BeginContext(4388, 25, false);
#line 73 "D:\Programming\Other\ASP.NET Core\06.08.2019(FINAL PROJECT)\Turbo\Turbo\Areas\Admin\Views\Announcement\ListsItem.cshtml"
   Write(Model.Automobile.FullInfo);

#line default
#line hidden
            EndContext();
            BeginContext(4413, 151, true);
            WriteLiteral("\r\n    </h6>\r\n    <p></p>\r\n</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n</section>");
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
