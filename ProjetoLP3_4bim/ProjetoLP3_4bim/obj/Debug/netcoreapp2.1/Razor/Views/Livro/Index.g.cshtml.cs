#pragma checksum "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "252d776128c59d41ac7c7b48582c9d744241cca7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livro_Index), @"mvc.1.0.view", @"/Views/Livro/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Livro/Index.cshtml", typeof(AspNetCore.Views_Livro_Index))]
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
#line 1 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\_ViewImports.cshtml"
using ProjetoLP3_4bim;

#line default
#line hidden
#line 2 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\_ViewImports.cshtml"
using ProjetoLP3_4bim.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"252d776128c59d41ac7c7b48582c9d744241cca7", @"/Views/Livro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b8dc96480b75957b1c736924afc93930cad3663", @"/Views/_ViewImports.cshtml")]
    public class Views_Livro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoLP3_4bim.Models.Livro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
  
    ViewData["Title"] = "Lista";

#line default
#line hidden
            BeginContext(93, 29, true);
            WriteLiteral("\r\n<h2>Lista</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(122, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66222129206444b38435e7b202f15c13", async() => {
                BeginContext(145, 14, true);
                WriteLiteral("Cadastrar novo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(163, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(256, 47, false);
#line 16 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TituloLivro));

#line default
#line hidden
            EndContext();
            BeginContext(303, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(359, 55, false);
#line 19 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataLancamentoLivro));

#line default
#line hidden
            EndContext();
            BeginContext(414, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(470, 51, false);
#line 22 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QtdPaginasLivro));

#line default
#line hidden
            EndContext();
            BeginContext(521, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(577, 46, false);
#line 25 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrecoLivro));

#line default
#line hidden
            EndContext();
            BeginContext(623, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(679, 48, false);
#line 28 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SinopseLivro));

#line default
#line hidden
            EndContext();
            BeginContext(727, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(783, 58, false);
#line 31 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AutorIdAutorNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(841, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(897, 62, false);
#line 34 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EditoraIdEditoraNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(959, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1015, 70, false);
#line 37 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GeneroLivroIdGeneroLivroNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1203, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1252, 46, false);
#line 46 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TituloLivro));

#line default
#line hidden
            EndContext();
            BeginContext(1298, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1354, 54, false);
#line 49 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataLancamentoLivro));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1464, 50, false);
#line 52 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QtdPaginasLivro));

#line default
#line hidden
            EndContext();
            BeginContext(1514, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1570, 45, false);
#line 55 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrecoLivro));

#line default
#line hidden
            EndContext();
            BeginContext(1615, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1671, 47, false);
#line 58 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SinopseLivro));

#line default
#line hidden
            EndContext();
            BeginContext(1718, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1774, 68, false);
#line 61 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AutorIdAutorNavigation.EmailAutor));

#line default
#line hidden
            EndContext();
            BeginContext(1842, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1898, 74, false);
#line 64 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EditoraIdEditoraNavigation.EmailEditora));

#line default
#line hidden
            EndContext();
            BeginContext(1972, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2028, 85, false);
#line 67 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GeneroLivroIdGeneroLivroNavigation.NomeGeneroLivro));

#line default
#line hidden
            EndContext();
            BeginContext(2113, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2168, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b98f1636a23d4f3b837a8f6212d03ed2", async() => {
                BeginContext(2218, 6, true);
                WriteLiteral("Editar");
                EndContext();
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
#line 70 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
                                       WriteLiteral(item.IdLivro);

#line default
#line hidden
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
            EndContext();
            BeginContext(2228, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2248, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3997106922f9441c9ee4cd56e10390cf", async() => {
                BeginContext(2301, 8, true);
                WriteLiteral("Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
                                          WriteLiteral(item.IdLivro);

#line default
#line hidden
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
            EndContext();
            BeginContext(2313, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2333, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5673f5c3f9584739a2328afad135e960", async() => {
                BeginContext(2385, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
                                         WriteLiteral(item.IdLivro);

#line default
#line hidden
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
            EndContext();
            BeginContext(2396, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 75 "F:\LP3_PROJETO\LP3_PROJETO\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2435, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoLP3_4bim.Models.Livro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
