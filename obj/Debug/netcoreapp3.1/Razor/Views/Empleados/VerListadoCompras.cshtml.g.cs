#pragma checksum "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3705c74b02a01d1f2c61b0ead109dbc8de5e638b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_VerListadoCompras), @"mvc.1.0.view", @"/Views/Empleados/VerListadoCompras.cshtml")]
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
#line 1 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\_ViewImports.cshtml"
using BENT1C.Grupo1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\_ViewImports.cshtml"
using BENT1C.Grupo1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3705c74b02a01d1f2c61b0ead109dbc8de5e638b", @"/Views/Empleados/VerListadoCompras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5d6ab96abc25e495dab0ed48ff78a8b23d9123", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_VerListadoCompras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BENT1C.Grupo1.Models.Compra>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"
  
    ViewData["Title"] = "Index";
    var i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de Compras Mensuales</h1>\r\n\r\n<hr />\r\n\r\n<div class=\"lista-compras\">\r\n");
#nullable restore
#line 13 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"
     foreach (var compra in Model)
    {
        i++;



#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div id=""accordion"">
            <div class=""card form-group"">
                <div class=""card-header"" id=""headingOne"">
                    <h5 class=""mb-0"">
                        <button class=""btn btn-link col-lg-12 collapsed"" data-toggle=""collapse"" data-target=""#lista_");
#nullable restore
#line 22 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"
                                                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 561, "\"", 591, 2);
            WriteAttributeValue("", 577, "collapseOne_", 577, 12, true);
#nullable restore
#line 22 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"
WriteAttributeValue("", 589, i, 589, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"float-left\">\r\n                                <h5>Cliente: ");
#nullable restore
#line 24 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"
                                        Write(Html.DisplayFor(c => compra.Cliente.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"
                                                                                     Write(Html.DisplayFor(c => compra.Cliente.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                            <div class=\"float-right\">\r\n                                <h5>Total: $");
#nullable restore
#line 27 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"
                                       Write(Html.DisplayFor(c => compra.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                            </div>\r\n                        </button>\r\n                    </h5>\r\n                </div>\r\n\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 1114, "\"", 1127, 2);
            WriteAttributeValue("", 1119, "lista_", 1119, 6, true);
#nullable restore
#line 33 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"
WriteAttributeValue("", 1125, i, 1125, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1145, "\"", 1176, 2);
            WriteAttributeValue("", 1163, "headingOne_", 1163, 11, true);
#nullable restore
#line 33 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"
WriteAttributeValue("", 1174, i, 1174, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""card-body"">
                        <div>
                            <table class=""table"">
                                <thead class=""thead-dark"">
                                    <tr>
                                        <th>Producto</th>
                                        <th>Cantidad</th>
                                        <th>Precio</th>
                                    </tr>
                                </thead>
");
#nullable restore
#line 44 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"
                                 foreach (var item in compra.Carrito.CarritoItems)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 47 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"
                                       Write(Html.DisplayFor(p => item.Producto.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 48 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"
                                       Write(Html.DisplayFor(p => item.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 49 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"
                                       Write(Html.DisplayFor(p => item.Producto.PrecioVigente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 51 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 59 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Empleados\VerListadoCompras.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BENT1C.Grupo1.Models.Compra>> Html { get; private set; }
    }
}
#pragma warning restore 1591
