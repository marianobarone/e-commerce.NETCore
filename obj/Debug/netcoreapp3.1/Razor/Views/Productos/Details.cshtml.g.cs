#pragma checksum "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a39b1dd931acebe01a71c9e41a9cc70d5870836"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Details), @"mvc.1.0.view", @"/Views/Productos/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a39b1dd931acebe01a71c9e41a9cc70d5870836", @"/Views/Productos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5d6ab96abc25e495dab0ed48ff78a8b23d9123", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BENT1C.Grupo1.Models.Producto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Producto</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrecioVigente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrecioVigente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Activo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Activo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Categoria.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a39b1dd931acebe01a71c9e41a9cc70d58708369262", async() => {
                WriteLiteral("Edit");
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
#line 52 "F:\ORT\2do CUATRIMESTRE - 2020\06 - PROGRAMACION EN NUEVAS TECNOLOGIAS 1\TRABAJO FINAL\2020-2-BENT1C-1\BENT1C.Grupo1\Views\Productos\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a39b1dd931acebe01a71c9e41a9cc70d587083611472", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
