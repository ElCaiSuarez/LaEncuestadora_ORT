#pragma checksum "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\EncuestaRespondida\Resultado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a95c06fdb26d5e6d941d2a00c6f7ddff0f4aea8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EncuestaRespondida_Resultado), @"mvc.1.0.view", @"/Views/EncuestaRespondida/Resultado.cshtml")]
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
#line 1 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\_ViewImports.cshtml"
using Encuestadora_Identity2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\_ViewImports.cshtml"
using Encuestadora_Identity2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a95c06fdb26d5e6d941d2a00c6f7ddff0f4aea8", @"/Views/EncuestaRespondida/Resultado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e609fcf4661df2429bedf0cd18a9243ea46750c", @"/Views/_ViewImports.cshtml")]
    public class Views_EncuestaRespondida_Resultado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Encuestadora_Identity2.Models.EncuestaRespondida>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\EncuestaRespondida\Resultado.cshtml"
  
    ViewData["Title"] = "Resultado";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Resultado de ");
#nullable restore
#line 8 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\EncuestaRespondida\Resultado.cshtml"
            Write(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    <button title=\"Mis Encuestas\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 270, "\"", 343, 4);
            WriteAttributeValue("", 280, "window.open(\'/Encuesta?userName=", 280, 32, true);
#nullable restore
#line 11 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\EncuestaRespondida\Resultado.cshtml"
WriteAttributeValue("", 312, User.Identity.Name, 312, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 331, "\',", 331, 2, true);
            WriteAttributeValue(" ", 333, "\'_self\');", 334, 10, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-light""><img src=""/img/icono_atras.svg"" class=""img-fluid"" alt=""Atras"" /></button>
</p>
<div id=""container""></div>
<div class=""container-fluid"">
    <section class=""row justify-content-start align-items-center"">
        <table class=""table-responsive"">
            <thead class=""btn btn-success col-12 col-sm-12"">
                <tr class=""col-12 col-sm-12"" style=""display:inline-table"">
                    <th class=""col-4 col-sm-4 text-center"">
                        ");
#nullable restore
#line 20 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\EncuestaRespondida\Resultado.cshtml"
                   Write(Html.DisplayNameFor(model => model.datetimeRespuestaEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"col-4 col-sm-4 text-center\">\r\n                        ");
#nullable restore
#line 23 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\EncuestaRespondida\Resultado.cshtml"
                   Write(Html.DisplayNameFor(model => model.pregunta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"col-4 col-sm-4 text-center\">\r\n                        ");
#nullable restore
#line 26 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\EncuestaRespondida\Resultado.cshtml"
                   Write(Html.DisplayNameFor(model => model.opcionPregunta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody class=\"btn bg-light col-12 col-sm-12\">\r\n");
#nullable restore
#line 31 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\EncuestaRespondida\Resultado.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"col-12 col-sm-12\" style=\"display:inline-table\">\r\n                        <td class=\"col-4 col-sm-4 text-center\">\r\n                            ");
#nullable restore
#line 35 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\EncuestaRespondida\Resultado.cshtml"
                       Write(Html.DisplayFor(modelItem => item.datetimeRespuestaEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-4 col-sm-4 text-center\">\r\n                            ");
#nullable restore
#line 38 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\EncuestaRespondida\Resultado.cshtml"
                       Write(Html.DisplayFor(modelItem => item.pregunta.tituloPregunta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-4 col-sm-4 text-center\">\r\n                            ");
#nullable restore
#line 41 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\EncuestaRespondida\Resultado.cshtml"
                       Write(Html.DisplayFor(modelItem => item.opcionPregunta.tituloOpcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\EncuestaRespondida\Resultado.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </section>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
            <script src=""https://code.highcharts.com/highcharts.js""></script>
            <script src=""https://code.highcharts.com/modules/exporting.js""></script>
            <script src=""https://code.highcharts.com/modules/export-data.js""></script>
            <script src=""https://code.highcharts.com/modules/accessibility.js""></script>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a95c06fdb26d5e6d941d2a00c6f7ddff0f4aea89567", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <script>\r\n        Highcharts.chart(\'container\', {\r\n            chart: {\r\n                type: \'column\'\r\n            },\r\n            title: {\r\n                text: \'Resultado de ");
#nullable restore
#line 64 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\EncuestaRespondida\Resultado.cshtml"
                               Write(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
            },
            xAxis: {
                categories: ['Pregunta Encuesta Vencida PLATA 1', 'Pregunta Encuesta Vencida PLATA 2', 'Pregunta Encuesta Vencida PLATA 3']
            },
            yAxis: {
                min: 0,
                title: {
                    text: 'Cantidad de respuestas por Opcion'
                },
                stackLabels: {
                    enabled: true,
                    style: {
                        fontWeight: 'bold',
                        color: ( // theme
                            Highcharts.defaultOptions.title.style &&
                            Highcharts.defaultOptions.title.style.color
                        ) || 'gray',
                        textOutline: 'none'
                    }
                }
            },
            legend: {
                align: 'right',
                x: -30,
                verticalAlign: 'top',
                y: 25,
                floating: true,
                backgro");
                WriteLiteral(@"undColor:
                    Highcharts.defaultOptions.legend.backgroundColor || 'white',
                borderColor: '#CCC',
                borderWidth: 1,
                shadow: false
            },
            tooltip: {
                headerFormat: '<b>{point.x}</b><br/>',
                pointFormat: '{series.name}: {point.y}<br/>Total: {point.stackTotal}'
            },
            plotOptions: {
                column: {
                    stacking: 'normal',
                    dataLabels: {
                        enabled: true
                    }
                }
            },
            series: [{
                name: 'Opcion 1',
                data: [1, 0, 0]
            }, {
                name: 'Opcion 2',
                data: [2, 1, 1]
            }, {
                name: 'Opcion 3',
                data: [0, 2, 1]
            }, {
                name: 'Opcion 4',
                data: [0, 0, 2]
            }]
        });

            </script>");
                WriteLiteral("\r\n        ");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Encuestadora_Identity2.Models.EncuestaRespondida>> Html { get; private set; }
    }
}
#pragma warning restore 1591
