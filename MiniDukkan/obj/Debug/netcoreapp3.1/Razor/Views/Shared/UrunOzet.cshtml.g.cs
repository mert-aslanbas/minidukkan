#pragma checksum "C:\Users\AydınMutlu\Desktop\Mert\MiniDukkan\MiniDukkan\Views\Shared\UrunOzet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd05470d297a40863a29ad2cddec6468b092543a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_UrunOzet), @"mvc.1.0.view", @"/Views/Shared/UrunOzet.cshtml")]
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
#line 1 "C:\Users\AydınMutlu\Desktop\Mert\MiniDukkan\MiniDukkan\Views\_ViewImports.cshtml"
using MiniDukkan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AydınMutlu\Desktop\Mert\MiniDukkan\MiniDukkan\Views\_ViewImports.cshtml"
using MiniDukkan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AydınMutlu\Desktop\Mert\MiniDukkan\MiniDukkan\Views\_ViewImports.cshtml"
using MiniDukkan.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd05470d297a40863a29ad2cddec6468b092543a", @"/Views/Shared/UrunOzet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0403e221c9229efce0df621982edec945d07f634", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_UrunOzet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Urun>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card card-outline-primary m-1 p-1\">\r\n    <div class=\"bg-faded p-1\">\r\n        <h4>\r\n            ");
#nullable restore
#line 6 "C:\Users\AydınMutlu\Desktop\Mert\MiniDukkan\MiniDukkan\Views\Shared\UrunOzet.cshtml"
       Write(Model.UrunAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\r\n                <small>");
#nullable restore
#line 8 "C:\Users\AydınMutlu\Desktop\Mert\MiniDukkan\MiniDukkan\Views\Shared\UrunOzet.cshtml"
                  Write(Model.Fiyat.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n            </span>\r\n        </h4>\r\n    </div>\r\n    <div class=\"card-text p-1\">");
#nullable restore
#line 12 "C:\Users\AydınMutlu\Desktop\Mert\MiniDukkan\MiniDukkan\Views\Shared\UrunOzet.cshtml"
                          Write(Model.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Urun> Html { get; private set; }
    }
}
#pragma warning restore 1591