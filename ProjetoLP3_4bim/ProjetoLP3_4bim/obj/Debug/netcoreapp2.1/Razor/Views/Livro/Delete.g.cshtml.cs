#pragma checksum "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44f3a359aef5bdde9e0c7e5d2b5281eef881a0a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livro_Delete), @"mvc.1.0.view", @"/Views/Livro/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Livro/Delete.cshtml", typeof(AspNetCore.Views_Livro_Delete))]
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
#line 1 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\_ViewImports.cshtml"
using ProjetoLP3_4bim;

#line default
#line hidden
#line 2 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\_ViewImports.cshtml"
using ProjetoLP3_4bim.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44f3a359aef5bdde9e0c7e5d2b5281eef881a0a5", @"/Views/Livro/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b8dc96480b75957b1c736924afc93930cad3663", @"/Views/_ViewImports.cshtml")]
    public class Views_Livro_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoLP3_4bim.Models.Livro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
  
    ViewData["Title"] = "Excluir";

#line default
#line hidden
            BeginContext(82, 173, true);
            WriteLiteral("\r\n<h2>Excluir</h2>\r\n\r\n<h3>Tens certeza que deseja excluir o registro?</h3>\r\n<div>\r\n    <h4>Livro</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(256, 47, false);
#line 15 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TituloLivro));

#line default
#line hidden
            EndContext();
            BeginContext(303, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(347, 43, false);
#line 18 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TituloLivro));

#line default
#line hidden
            EndContext();
            BeginContext(390, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(434, 55, false);
#line 21 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataLancamentoLivro));

#line default
#line hidden
            EndContext();
            BeginContext(489, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(533, 51, false);
#line 24 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataLancamentoLivro));

#line default
#line hidden
            EndContext();
            BeginContext(584, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(628, 51, false);
#line 27 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.QtdPaginasLivro));

#line default
#line hidden
            EndContext();
            BeginContext(679, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(723, 47, false);
#line 30 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayFor(model => model.QtdPaginasLivro));

#line default
#line hidden
            EndContext();
            BeginContext(770, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(814, 46, false);
#line 33 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrecoLivro));

#line default
#line hidden
            EndContext();
            BeginContext(860, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(904, 42, false);
#line 36 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrecoLivro));

#line default
#line hidden
            EndContext();
            BeginContext(946, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(990, 48, false);
#line 39 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SinopseLivro));

#line default
#line hidden
            EndContext();
            BeginContext(1038, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1082, 44, false);
#line 42 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SinopseLivro));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1170, 58, false);
#line 45 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AutorIdAutorNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1272, 65, false);
#line 48 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AutorIdAutorNavigation.EmailAutor));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1381, 62, false);
#line 51 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EditoraIdEditoraNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1487, 71, false);
#line 54 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EditoraIdEditoraNavigation.EmailEditora));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1602, 70, false);
#line 57 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GeneroLivroIdGeneroLivroNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1716, 82, false);
#line 60 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GeneroLivroIdGeneroLivroNavigation.NomeGeneroLivro));

#line default
#line hidden
            EndContext();
            BeginContext(1798, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1836, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "258be1845eef464aaa4bab3209663657", async() => {
                BeginContext(1862, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1872, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "134ce235d0e24fa996e6fd93b1379d48", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "C:\Users\IFSP\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdLivro);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1913, 85, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Excluir\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1998, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77f18ca150d74d7c8eaec33c2abee96e", async() => {
                    BeginContext(2020, 17, true);
                    WriteLiteral("Voltar para Lista");
                    EndContext();
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
                EndContext();
                BeginContext(2041, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2054, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoLP3_4bim.Models.Livro> Html { get; private set; }
    }
}
#pragma warning restore 1591
