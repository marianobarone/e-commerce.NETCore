#pragma checksum "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cda5b8a94f7ae6e9aa0c7a69ed2bc6cd35fa1c6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_VerProducto), @"mvc.1.0.view", @"/Views/Productos/VerProducto.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cda5b8a94f7ae6e9aa0c7a69ed2bc6cd35fa1c6e", @"/Views/Productos/VerProducto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5d6ab96abc25e495dab0ed48ff78a8b23d9123", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_VerProducto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BENT1C.Grupo1.Models.Producto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carritos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AgregarProducto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row col-md-12"">

        <div class=""col-md-8"">
            <div id=""carouselExampleControls"" class=""carousel slide card"" data-ride=""carousel"">
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"">
");
#nullable restore
#line 14 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
                         if (Model.Foto != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img class=\"d-block\"");
            BeginWriteAttribute("src", " src=\"", 501, "\"", 518, 1);
#nullable restore
#line 16 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
WriteAttributeValue("", 507, Model.Foto, 507, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" height=\"100%\">\r\n");
#nullable restore
#line 17 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img class=\"img-thumbnail rounded\" src=\"/img/caja.jpg\" width=\"100%\" height=\"100%\">\r\n");
#nullable restore
#line 21 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-4\">\r\n\r\n            <h2>");
#nullable restore
#line 29 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
           Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n            <br />\r\n\r\n            <div>\r\n                <h4> ");
#nullable restore
#line 34 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
                Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n            </div>\r\n\r\n            <br />\r\n\r\n            <div>\r\n                <h4>$ ");
#nullable restore
#line 40 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
                 Write(Html.DisplayFor(model => model.PrecioVigente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n\r\n            <br />\r\n\r\n");
#nullable restore
#line 45 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
             if (Model.Activo)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cda5b8a94f7ae6e9aa0c7a69ed2bc6cd35fa1c6e8305", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"productoId\"");
                BeginWriteAttribute("value", " value=\"", 1440, "\"", 1457, 1);
#nullable restore
#line 48 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
WriteAttributeValue("", 1448, Model.Id, 1448, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

                    <div class=""form-group row"">
                        <div class=""col-md-4 d-flex align-items-center"">
                            <label for=""cantidad"" class=""col-form-label cantidad"">Cantidad</label>
                        </div>


                        <div class=""input-group col-md-6"">
                            <div class=""input-group-prepend"">
                                <button onclick=""disminuirCantProducto('cantProductos')"" type=""button"" class=""btn btn-secondary"">
                                    <i class=""fas fa-minus""></i>
                                </button>
                            </div>

                            <input class=""quantity text-center col-lg-5 col-md-5 col-xs-5 col-5"" min=""0"" name=""cantidad"" value=""1"" type=""number"" id=""cantProductos"">

                            <div class=""input-group-append"">
                                <button onclick=""aumentarCantProducto('cantProductos')"" type=""button"" class=""btn btn-secondary");
                WriteLiteral("\">\r\n                                    <i class=\"fas fa-plus\"></i>\r\n                                </button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 72 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-group\">\r\n                            <button type=\"submit\" value=\"Comprar\" class=\"btn btn-primary col-md-12\" onclick=\"aumentar()\">Agregar al carrito</button>\r\n                        </div>\r\n");
#nullable restore
#line 77 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-group\">\r\n                            <button title=\"Debe estar logueado en el sistema\" type=\"submit\" value=\"Comprar\" class=\"btn btn-primary\" disabled>Agregar al carrito</button>\r\n                        </div>\r\n");
#nullable restore
#line 83 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 85 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert-danger card\">\r\n                    <h5 class=\"card-header text-uppercase text-center\">Publicacion pausada</h5>\r\n                </div>\r\n");
#nullable restore
#line 91 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\VerProducto.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BENT1C.Grupo1.Models.Producto> Html { get; private set; }
    }
}
#pragma warning restore 1591
