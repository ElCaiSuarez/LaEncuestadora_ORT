#pragma checksum "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e24676c7edd0398150b655c609006462402ac198"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Encuesta_Index), @"mvc.1.0.view", @"/Views/Encuesta/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e24676c7edd0398150b655c609006462402ac198", @"/Views/Encuesta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e609fcf4661df2429bedf0cd18a9243ea46750c", @"/Views/_ViewImports.cshtml")]
    public class Views_Encuesta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Encuestadora_Identity2.Models.Encuesta>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
  
    ViewData["Title"] = "Encuestas";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Mis Encuestas</h1>\r\n\r\n<p>\r\n    <a class=\"btn-link\"");
            BeginWriteAttribute("href", " href=\"", 210, "\"", 262, 2);
            WriteAttributeValue("", 217, "/Encuesta/Create?userName=", 217, 26, true);
#nullable restore
#line 11 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
WriteAttributeValue("", 243, User.Identity.Name, 243, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Crear Encuesta</a> |\r\n    <a class=\"btn-link\" href=\"/Identity/Account/Manage\">Volver a Mi Perfil</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.tituloEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.datetimeCreacionEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.datetimeVencimientoEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                <b>Preguntas</b>\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.puntosEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.tituloEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.datetimeCreacionEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.datetimeVencimientoEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <th>\r\n");
            WriteLiteral("                Preguntas\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.puntosEncuesta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e24676c7edd0398150b655c609006462402ac1988360", async() => {
                WriteLiteral("Ver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
                                          WriteLiteral(item.EncuestaId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1722, "\"", 1792, 4);
            WriteAttributeValue("", 1729, "/Encuesta/Edit?id=", 1729, 18, true);
#nullable restore
#line 56 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
WriteAttributeValue("", 1747, item.EncuestaId, 1747, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1763, "&userName=", 1763, 10, true);
#nullable restore
#line 56 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
WriteAttributeValue("", 1773, User.Identity.Name, 1773, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a> |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e24676c7edd0398150b655c609006462402ac19811425", async() => {
                WriteLiteral("Borrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
                                         WriteLiteral(item.EncuestaId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\sj011105\source\repos\Solucion_Encuestadora_Identity2\Encuestadora_Identity2\Views\Encuesta\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
