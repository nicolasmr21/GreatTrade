<<<<<<< HEAD
#pragma checksum "D:\Repositorios\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "698999724276424e008a5d20394fec0aa1aa7172"
=======
#pragma checksum "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "698999724276424e008a5d20394fec0aa1aa7172"
>>>>>>> origin/master
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ItemPublication), @"mvc.1.0.view", @"/Views/Shared/ItemPublication.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ItemPublication.cshtml", typeof(AspNetCore.Views_Shared_ItemPublication))]
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
<<<<<<< HEAD
#line 1 "D:\Repositorios\GreatTrade\GreatTrade\Views\_ViewImports.cshtml"
=======
#line 1 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\_ViewImports.cshtml"
>>>>>>> origin/master
using GreatTrade;

#line default
#line hidden
<<<<<<< HEAD
#line 2 "D:\Repositorios\GreatTrade\GreatTrade\Views\_ViewImports.cshtml"
=======
#line 2 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\_ViewImports.cshtml"
>>>>>>> origin/master
using GreatTrade.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698999724276424e008a5d20394fec0aa1aa7172", @"/Views/Shared/ItemPublication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69353d5a56d9084aabfee9212e305412563df20", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ItemPublication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Publication>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 101, true);
            WriteLiteral("<div class=\"col-md-3 col-sm-6\">\r\n    <div class=\"item-box\">\r\n        <div class=\"item-media entry\">\r\n");
            EndContext();
<<<<<<< HEAD
#line 5 "D:\Repositorios\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
=======
#line 5 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
>>>>>>> origin/master
             if (Model.Product != null)
            {
                

#line default
#line hidden
<<<<<<< HEAD
#line 7 "D:\Repositorios\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
=======
#line 7 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
>>>>>>> origin/master
                 if (Model.Product.Photos != null)
                {

#line default
#line hidden
            BeginContext(248, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 272, "\"", 322, 1);
<<<<<<< HEAD
#line 9 "D:\Repositorios\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
=======
#line 9 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
>>>>>>> origin/master
WriteAttributeValue("", 278, Model.Product.Photos.FirstOrDefault().Route, 278, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(323, 35, true);
            WriteLiteral(" alt=\"\" class=\"img-responsive\" />\r\n");
            EndContext();
<<<<<<< HEAD
#line 10 "D:\Repositorios\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
=======
#line 10 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
>>>>>>> origin/master
                }

#line default
#line hidden
            BeginContext(377, 105, true);
            WriteLiteral("                <div class=\"theme__button\">\r\n                    <p><a href=\"single-item.html\" title=\"\">$");
            EndContext();
            BeginContext(483, 19, false);
<<<<<<< HEAD
#line 12 "D:\Repositorios\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
=======
#line 12 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
>>>>>>> origin/master
                                                       Write(Model.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(502, 34, true);
            WriteLiteral("</a></p>\r\n                </div>\r\n");
            EndContext();
<<<<<<< HEAD
#line 14 "D:\Repositorios\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
=======
#line 14 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
>>>>>>> origin/master
            }

#line default
#line hidden
            BeginContext(551, 56, true);
            WriteLiteral("\r\n        </div><!-- end item-media -->\r\n        <div>\r\n");
            EndContext();
<<<<<<< HEAD
#line 18 "D:\Repositorios\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
=======
#line 18 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
>>>>>>> origin/master
             if (Model.Product != null)
            {

#line default
#line hidden
            BeginContext(663, 47, true);
            WriteLiteral("                <h4><a href=\"single-item.html\">");
            EndContext();
            BeginContext(711, 19, false);
<<<<<<< HEAD
#line 20 "D:\Repositorios\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
=======
#line 20 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
>>>>>>> origin/master
                                          Write(Model.Product.Title);

#line default
#line hidden
            EndContext();
            BeginContext(730, 36, true);
            WriteLiteral("</a></h4>\r\n                <small>\r\n");
            EndContext();
<<<<<<< HEAD
#line 22 "D:\Repositorios\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
=======
#line 22 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
>>>>>>> origin/master
                     if (Model.Views != null)
                    {

#line default
#line hidden
            BeginContext(836, 106, true);
            WriteLiteral("                        <a href=\"single-item.html\">\r\n                            <i class=\"fa fa-eye\"></i>");
            EndContext();
            BeginContext(943, 19, false);
<<<<<<< HEAD
#line 25 "D:\Repositorios\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
=======
#line 25 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
>>>>>>> origin/master
                                                Write(Model.Views.Count());

#line default
#line hidden
            EndContext();
            BeginContext(962, 32, true);
            WriteLiteral("\r\n                        </a>\r\n");
            EndContext();
<<<<<<< HEAD
#line 27 "D:\Repositorios\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
=======
#line 27 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
>>>>>>> origin/master
                    }
                    else {

#line default
#line hidden
            BeginContext(1045, 139, true);
            WriteLiteral("                        <a href=\"single-item.html\">\r\n                            <i class=\"fa fa-eye\"></i>0\r\n                        </a>\r\n");
            EndContext();
<<<<<<< HEAD
#line 32 "D:\Repositorios\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
=======
#line 32 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
>>>>>>> origin/master
                    }

#line default
#line hidden
            BeginContext(1207, 26, true);
            WriteLiteral("                </small>\r\n");
            EndContext();
<<<<<<< HEAD
#line 34 "D:\Repositorios\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
=======
#line 34 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Shared\ItemPublication.cshtml"
>>>>>>> origin/master
            }

#line default
#line hidden
            BeginContext(1248, 169, true);
            WriteLiteral("            <small><a href=\"single-item.html\"><i class=\"fa fa-comment-o\"></i> 12</a></small>\r\n            </div>\r\n    </div><!-- end item-box -->\r\n</div><!-- end col -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Publication> Html { get; private set; }
    }
}
#pragma warning restore 1591
