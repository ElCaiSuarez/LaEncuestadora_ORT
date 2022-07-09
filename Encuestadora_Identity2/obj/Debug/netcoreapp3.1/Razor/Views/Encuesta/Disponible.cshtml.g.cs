#pragma checksum "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d5222a450c7d49c29368bd0a4752b4b12a86328"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Encuesta_Disponible), @"mvc.1.0.view", @"/Views/Encuesta/Disponible.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d5222a450c7d49c29368bd0a4752b4b12a86328", @"/Views/Encuesta/Disponible.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e609fcf4661df2429bedf0cd18a9243ea46750c", @"/Views/_ViewImports.cshtml")]
    public class Views_Encuesta_Disponible : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Encuestadora_Identity2.Models.Encuesta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
  
    ViewData["Title"] = "Disponibles";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Encuestas Disponibles</h1>\r\n\r\n<p>\r\n");
            WriteLiteral(@"    <button type=""button"" onclick=""window.open('/Identity/Account/Manage', '_self');"" class=""btn btn-secondary"">Volver a Mi Perfil</button>
</p>
<table>
    <thead class=""btn btn-primary col-12"" >
        <tr class=""col-12"" style=""display:inline-table"">
            <th class=""col-2 text-center"">
                Nombre
            </th>
            <th class=""col-2  text-center"">
                Publicacion
            </th>
            <th class=""col-2  text-center"">
                Vencimiento
            </th>
            <th class=""col-2  text-center"">
                Preguntas
            </th>
            <th class=""col-2  text-center"">
                Puntos
            </th>
            <th class=""col-2  text-center""></th>
        </tr>
    </thead>
    <tbody class=""btn bg-light col-12"">
");
#nullable restore
#line 37 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
         foreach (var item in Model)
        {
            //VALIDO QUE CADA ENCUESTA NO ESTE VENCIDA Y TENGA PREGUNTAS
            if (/*item.datetimeVencimientoEncuesta > DateTime.Now && */item.preguntas.Count > 0)
            {
                var encuestaCompleta = true;
                var i = 0;
                var preguntas = item.preguntas.ToList();
                //VALIDO QUE CADA PREGUNTA TENGA OPCIONES
                while (i < preguntas.Count && encuestaCompleta)
                {
                    if (preguntas[i].opciones.Count <= 0)
                    {
                        encuestaCompleta = false;
                    }
                    else
                    {
                        i++;
                    }
                }
                //SI ESTA COMPLETA MUESTRO LA ENCUESTA
                if (encuestaCompleta)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"col-12\"  style=\"display:inline-table\">\r\n                        <td class=\"col-2 text-center\">\r\n                            ");
#nullable restore
#line 63 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                       Write(Html.DisplayFor(modelItem => item.tituloEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-2 text-center\">\r\n                            ");
#nullable restore
#line 66 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                       Write(Html.DisplayFor(modelItem => item.datetimeCreacionEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-2 text-center\">\r\n                            ");
#nullable restore
#line 69 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                       Write(Html.DisplayFor(modelItem => item.datetimeVencimientoEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <th class=\"col-2 text-center\">\r\n");
            WriteLiteral("                            ");
#nullable restore
#line 73 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                       Write(item.preguntas.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n");
#nullable restore
#line 75 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                         if (item.puntosEncuesta == PuntosEncuesta.ENCUESTA_ORO)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"col-2\">\r\n                                <p class=\"btn btn-warning text-black-50 font-weight-bold\" style=\"display:inline\">");
#nullable restore
#line 78 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                                                                                                            Write(Html.DisplayFor(modelItem => item.puntosEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n");
#nullable restore
#line 80 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                        }
                        else if (item.puntosEncuesta == PuntosEncuesta.ENCUESTA_PLATA)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"col-2\">\r\n                                <p class=\"btn btn-primary\" style=\"display:inline\">");
#nullable restore
#line 84 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                                                                             Write(Html.DisplayFor(modelItem => item.puntosEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n");
#nullable restore
#line 86 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"col-2\">\r\n                                ");
#nullable restore
#line 90 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                           Write(Html.DisplayFor(modelItem => item.puntosEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 92 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"col-2\">\r\n");
            WriteLiteral("                            <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4108, "\"", 4239, 6);
            WriteAttributeValue("", 4118, "window.open(\'/EncuestaRespondida/ResponderPreguntas?EncuestaId=", 4118, 63, true);
#nullable restore
#line 95 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
WriteAttributeValue("", 4181, item.EncuestaId, 4181, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4197, "&&userName=", 4197, 11, true);
#nullable restore
#line 95 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
WriteAttributeValue("", 4208, User.Identity.Name, 4208, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4227, "\',", 4227, 2, true);
            WriteAttributeValue(" ", 4229, "\'_self\');", 4230, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Responder</button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 98 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Disponible.cshtml"
                }

            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Encuestadora_Identity2.Models.Encuesta>> Html { get; private set; }
    }
}
#pragma warning restore 1591