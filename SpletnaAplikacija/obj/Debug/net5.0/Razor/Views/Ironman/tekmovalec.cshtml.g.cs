#pragma checksum "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0f11e6aade59d1d419fa0f66e9139ed10c7c11a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ironman_tekmovalec), @"mvc.1.0.view", @"/Views/Ironman/tekmovalec.cshtml")]
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
#line 1 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\_ViewImports.cshtml"
using SpletnaAplik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\_ViewImports.cshtml"
using SpletnaAplik.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0f11e6aade59d1d419fa0f66e9139ed10c7c11a", @"/Views/Ironman/tekmovalec.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a7373b091159a47460c57fbf1d7c9d7c0323996", @"/Views/_ViewImports.cshtml")]
    public class Views_Ironman_tekmovalec : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SpletnaAplik.Models.ironman>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">


<h1>Ironman Iskani Tekmovalec</h1>
<br/>
<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">
                ");
#nullable restore
#line 16 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 19 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 22 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.genderRank));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 25 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.divRank));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 28 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.overallRank));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 31 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.bib));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 34 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.division));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 37 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 40 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.state));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 43 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 46 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.profession));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 49 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 52 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.swim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th scope=\"col\">\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 55 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.swimDistance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 58 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.t1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 61 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.bike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 64 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.bikeDistance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 67 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.t2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 70 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.run));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 73 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.runDistance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 76 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayNameFor(model => model.overall));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            WriteLiteral("        <tr>\r\n            <td  scope=\"row\">\r\n                ");
#nullable restore
#line 85 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.genderRank));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.divRank));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.overallRank));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.bib));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.division));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.state));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 115 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.profession));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 118 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 121 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.swim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.swimDistance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.t1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 130 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.bike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 133 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.bikeDistance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 136 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.t2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 139 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.run));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 142 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.runDistance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 145 "C:\Users\zan\source\repos\UporabVmesnik\SpletnaAplik\Views\Ironman\tekmovalec.cshtml"
           Write(Html.DisplayFor(modelItem => Model.overall));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpletnaAplik.Models.ironman> Html { get; private set; }
    }
}
#pragma warning restore 1591
