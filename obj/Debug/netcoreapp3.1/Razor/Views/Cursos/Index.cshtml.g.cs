#pragma checksum "C:\Users\Admin\source\repos\SistemaAc\SistemaAc\Views\Cursos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bac5dfc8b858f6a89cf92b935861198fe30421db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cursos_Index), @"mvc.1.0.view", @"/Views/Cursos/Index.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\SistemaAc\SistemaAc\Views\_ViewImports.cshtml"
using SistemaAc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\SistemaAc\SistemaAc\Views\_ViewImports.cshtml"
using SistemaAc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac5dfc8b858f6a89cf92b935861198fe30421db", @"/Views/Cursos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bfd5b6b7da574f84f4f7520d50b319ecbee3386", @"/Views/_ViewImports.cshtml")]
    public class Views_Cursos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaAc.Models.Curso>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\SistemaAc\SistemaAc\Views\Cursos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>

<p>
    <a data-toggle=""modal"" onclick=""restablecer();"" data-target=""#modalCS"" class=""btn btn-info"">Crear Curso</a>
</p>

<div class=""form-group"">

    <div class=""col-md-6"">
        <input id=""filtrar"" name=""filtrar"" placeholder=""Buscar"" onkeyup=""filtrarCurso(1,'nombre')"" class=""form-control"" />

    </div>


</div>


<table class=""table"">
    <thead>
        <tr>
            <th>
                <a href=""#"" onclick='filtrarCurso(1,""nombre"")'>Nombre</a>
            </th>
            <th>
                <a href=""#"" onclick='filtrarCurso(1,""des"")'>Descripcion</a>
            </th>
            <th>
                <a href=""#"" onclick='filtrarCurso(1,""creditos"")'>Creditos</a>
            </th>
            <th>
                <a href=""#"" onclick='filtrarCurso(1,""horas"")'>Horas</a>
            </th>
            <th>
                <a href=""#"" onclick='filtrarCurso(1,""costo"")'>Costo</a>
            </th>
            <th>
                <a href=""#"" onclick='f");
            WriteLiteral(@"iltrarCurso(1,""estado"")'>Estado</a>
            </th>
            <th>
                <a href=""#"" onclick='filtrarCurso(1,""categoria"")'>Categoria</a>
            </th>
            <th>
                Opciones
            </th>
        </tr>
    </thead>
    <tbody id=""resultSearch""></tbody>
</table>
<div id=""paginado"">

</div>


<div class=""modal fade"" id=""modalCS"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <h4 class=""modal-title"" id=""myModalLabel"">Agregar curso</h4>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac5dfc8b858f6a89cf92b935861198fe30421db6184", async() => {
                WriteLiteral(@"
                    <div class=""form-horizontal"">
                        <div class=""form-group"">
                            <label for=""Nombre"" class=""col-md-2 control-label"">Nombre</label>
                            <div class=""col-md-10"">
                                <input for=""Nombre"" id=""Nombre"" placeholder=""Nombre"" name=""Nombre"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""Descripcion"" class=""col-md-2 control-label"">Descripcion</label>
                            <div class=""col-md-10"">
                                <input for=""Descripcion"" id=""Descripcion"" placeholder=""Descripcion"" name=""Descripcion"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""Creditos"" class=""col-md-2 control-label"">Creditos</label>
            ");
                WriteLiteral(@"                <div class=""col-md-10"">
                                <input for=""Creditos"" id=""Creditos"" placeholder=""Creditos"" name=""Creditos"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""Horas"" class=""col-md-2 control-label"">Horas</label>
                            <div class=""col-md-10"">
                                <input for=""Horas"" id=""Horas"" placeholder=""Horas"" name=""Horas"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""Costo"" class=""col-md-2 control-label"">Costo</label>
                            <div class=""col-md-10"">
                                <input for=""Costo"" id=""Costo"" placeholder=""Costo"" name=""Costo"" class=""form-control"" />
                            </div>
                        </div>
               ");
                WriteLiteral(@"         <div class=""form-group"">
                            <label for=""Estado"" class=""col-md-2 control-label"">Estado</label>
                            <div class=""checkbox"">
                                <label>
                                    <input type=""checkbox"" for=""Estado"" id=""Estado"" name=""Estado"" />
                                </label>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""Categoria"" class=""col-md-2 control-label"">Categoria</label>
                            <div class=""col-md-10"">
                                <select id='CategoriaCursos' class=""form-control"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac5dfc8b858f6a89cf92b935861198fe30421db9436", async() => {
                    WriteLiteral("Seleccione un curso");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                </select>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                    <label id=\"mensaje\" class=\"col-md-2 control-label\"></label>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" onclick=""agregarCurso()"" class=""btn btn-primary"">Guardar</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""ModalEstadoCurso"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Actualizar estado</h4>
            </div>
            <div class=""modal-body"">
                <h3 id=""titleCurso"" class=""modal-title""></h3>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                <button type=""button"" onclick=""editarEstadoCurso1()"" class=""btn btn-primary"">Aceptar</button>
            </div>
        </div><!-- /.");
            WriteLiteral("modal-content -->\r\n    </div><!-- /.modal-dialog -->\r\n</div><!-- /.modal -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaAc.Models.Curso>> Html { get; private set; }
    }
}
#pragma warning restore 1591
