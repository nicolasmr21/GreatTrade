#pragma checksum "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63490242e3f889c42e77812163d1433ad7d9a204"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ranking_Index), @"mvc.1.0.view", @"/Views/Ranking/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ranking/Index.cshtml", typeof(AspNetCore.Views_Ranking_Index))]
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
#line 1 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\_ViewImports.cshtml"
using GreatTrade;

#line default
#line hidden
#line 2 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\_ViewImports.cshtml"
using GreatTrade.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63490242e3f889c42e77812163d1433ad7d9a204", @"/Views/Ranking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69353d5a56d9084aabfee9212e305412563df20", @"/Views/_ViewImports.cshtml")]
    public class Views_Ranking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<IGrouping<GreatTrade.Models.Enum.TypeCountries, GreatTrade.Models.User>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
  
    ViewData["Title"] = "Ranking";
    Layout = "~/Views/Shared/ProfileLayout.cshtml";

#line default
#line hidden
            BeginContext(188, 1836, true);
            WriteLiteral(@"
<h2>Index</h2>

<section class=""section single-wrap"">
    <div class=""container"">
        <div class=""page-title"">
            <div class=""row"">
                <div class=""col-sx-12 text-center"">
                    <h3>Ranking de ventas</h3>
                    <div class=""bread"">
                        <ol class=""breadcrumb"">
                            <li><a href=""#"">Home</a></li>
                            <li class=""active"">Forum</li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
        <div class=""content-top"">
            <div class=""row"">
                <div class=""col-sx-6 col-sm-6"">
                    <div class=""custommenu hidden-xs"">
                        <a id=""showLeft"" href=""#"" title="""" class=""bt-menu-trigger""><i class=""fa fa-bars""></i> <img src=""upload/fav.png"" alt=""""></a>
                    </div>
                </div>
                <div class=""col-sm-6 col-xs-12 cen-xs text-right"">
   ");
            WriteLiteral(@"                 <ul class=""list-inline social"">
                        <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-dribbble""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-behance""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-pinterest""></i></a></li>
                    </ul>
                </div>
            </div><!-- end row -->
        </div><!-- end content top -->
        <div class=""content-before"">
            <div class=""row"">
                <div class=""col-md-12 col-sx-12 cen-xs"">
                    ");
            EndContext();
            BeginContext(2024, 966, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9789e926c5b24250b3766e52785bbece", async() => {
                BeginContext(2047, 222, true);
                WriteLiteral("\r\n                        <div class=\"input-prepend\">\r\n                            <div class=\"btn-group\">\r\n                                <select name=\"orderby\" class=\"selectpicker\">\r\n                                    ");
                EndContext();
                BeginContext(2269, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4789b27e9aae4436b3c746d7b280a7e0", async() => {
                    BeginContext(2277, 13, true);
                    WriteLiteral("All Platforms");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2299, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2337, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f783dcfabd6044308b6a14a08a810e0c", async() => {
                    BeginContext(2345, 8, true);
                    WriteLiteral("IOS Apps");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2362, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2400, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa799f4196484342a1beebc2560523fd", async() => {
                    BeginContext(2408, 12, true);
                    WriteLiteral("Android Apps");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2429, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2467, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d769ea6b92a4c3b98e349ae07ad4507", async() => {
                    BeginContext(2475, 7, true);
                    WriteLiteral("UI Kits");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2491, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2529, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aee0cc331a940c2bd2797b589fcb1fd", async() => {
                    BeginContext(2537, 14, true);
                    WriteLiteral("Site Templates");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2560, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2598, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0597e07144e4f4e88e65acad2eee8aa", async() => {
                    BeginContext(2606, 16, true);
                    WriteLiteral("WordPress Themes");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2631, 352, true);
                WriteLiteral(@"
                                </select>
                            </div>
                            <input type=""text"" class=""form-control"" placeholder=""Search anything here."">
                            <button class=""btn btn-primary"" tabindex=""-1""><i class=""fa fa-search""></i></button>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2990, 1554, true);
            WriteLiteral(@"
                </div>
                <div class=""col-md-6 text-right hidden-xs"">

                </div>
            </div><!-- end row -->
        </div><!-- end content before -->
        <div class=""content boxs"">
            <div class=""row"">
                <div class=""col-md-12 col-sm-12"">
                    <div class=""page-content"">
                        <div id=""bbpress-forums"">
                            <div class=""table-responsive"">
                                <ul class=""bbp-forums"">


                                    <li class=""bbp-body"">
                                        <ul class=""forum type-forum status-publish hentry loop-item-0 odd bbp-forum-status-open bbp-forum-visibility-publish"">
                                            <table class=""table table-striped"">
                                                <caption> Ranking de ventas globers</caption>
                                                <thead>
                                          ");
            WriteLiteral(@"          <tr>
                                                        <th scope=""col"">Posición</th>
                                                        <th scope=""col"">Nombre</th>
                                                        <th scope=""col"">Pais</th>
                                                        <th scope=""col"">Ventas</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
");
            EndContext();
#line 90 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                     foreach(var item in Model)
                                                    {

#line default
#line hidden
            BeginContext(4680, 130, true);
            WriteLiteral("                                                    <tr>\r\n                                                        <th scope=\"row\">");
            EndContext();
            BeginContext(4811, 17, false);
#line 93 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                                   Write(ViewData["count"]);

#line default
#line hidden
            EndContext();
            BeginContext(4828, 67, true);
            WriteLiteral("</th>\r\n                                                        <td>");
            EndContext();
            BeginContext(4896, 32, false);
#line 94 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                       Write(item.FirstOrDefault().FullName());

#line default
#line hidden
            EndContext();
            BeginContext(4928, 67, true);
            WriteLiteral("</td>\r\n                                                        <td>");
            EndContext();
            BeginContext(4996, 29, false);
#line 95 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                       Write(item.FirstOrDefault().Country);

#line default
#line hidden
            EndContext();
            BeginContext(5025, 69, true);
            WriteLiteral("</td>\r\n                                                        <td>\r\n");
            EndContext();
#line 97 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                             if (item.FirstOrDefault().SalesTransactions != null)
                                                            {
                                                                

#line default
#line hidden
            BeginContext(5337, 47, false);
#line 99 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                           Write(item.FirstOrDefault().SalesTransactions.Count());

#line default
#line hidden
            EndContext();
#line 99 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                                                                                
                                                            }

#line default
#line hidden
            BeginContext(5449, 122, true);
            WriteLiteral("                                                        </td>\r\n                                                    </tr>\r\n");
            EndContext();
#line 103 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"


                                                     }

#line default
#line hidden
            BeginContext(5631, 548, true);
            WriteLiteral(@"                                                    </tbody>
                                            </table>

                                        </ul><!-- end bbp forums -->
                                    </li>
                                </ul><!-- .forums-directory -->
                            </div>
                        </div> <!-- /bbpress -->
                    </div>
                </div><!-- end col -->
            </div><!-- end row -->
        </div><!-- end content -->
    </div>
</section>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<IGrouping<GreatTrade.Models.Enum.TypeCountries, GreatTrade.Models.User>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
