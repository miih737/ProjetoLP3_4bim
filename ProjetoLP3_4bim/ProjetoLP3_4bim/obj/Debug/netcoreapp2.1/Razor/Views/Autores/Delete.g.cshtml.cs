#pragma checksum "C:\Users\luciz\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Autores\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c959fa3f7ff010035eed66fe44d851fb8be8d7a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autores_Delete), @"mvc.1.0.view", @"/Views/Autores/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Autores/Delete.cshtml", typeof(AspNetCore.Views_Autores_Delete))]
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
#line 1 "C:\Users\luciz\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\_ViewImports.cshtml"
using ProjetoLP3_4bim;

#line default
#line hidden
#line 2 "C:\Users\luciz\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\_ViewImports.cshtml"
using ProjetoLP3_4bim.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c959fa3f7ff010035eed66fe44d851fb8be8d7a8", @"/Views/Autores/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b8dc96480b75957b1c736924afc93930cad3663", @"/Views/_ViewImports.cshtml")]
    public class Views_Autores_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoLP3_4bim.Models.Autor>
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
#line 3 "C:\Users\luciz\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Autores\Delete.cshtml"
  
    ViewData["Title"] = "Excluir";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 220, true);
            WriteLiteral("\r\n<h2>Excluir</h2>\r\n\r\n<h3>Tens certeza que deseja excluir o registro?</h3>\r\n<div>\r\n    <h4>Autor</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Nome\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(350, 41, false);
#line 19 "C:\Users\luciz\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Autores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NomeAutor));

#line default
#line hidden
            EndContext();
            BeginContext(391, 104, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Data de Nascimento\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(496, 45, false);
#line 25 "C:\Users\luciz\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Autores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataNascAutor));

#line default
#line hidden
            EndContext();
            BeginContext(541, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Nacionalidade\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(641, 50, false);
#line 31 "C:\Users\luciz\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Autores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NacionalidadeAutor));

#line default
#line hidden
            EndContext();
            BeginContext(691, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Telefone\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(786, 40, false);
#line 37 "C:\Users\luciz\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Autores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TelAutor));

#line default
#line hidden
            EndContext();
            BeginContext(826, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            E-mail\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(919, 42, false);
#line 43 "C:\Users\luciz\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Autores\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmailAutor));

#line default
#line hidden
            EndContext();
            BeginContext(961, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(999, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2aab42791a842bdb53d9eb4433b9a3f", async() => {
                BeginContext(1025, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1035, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec609172afca47b0bbecda68ce14b9af", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 48 "C:\Users\luciz\Desktop\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Autores\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdAutor);

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
                BeginContext(1076, 85, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Excluir\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1161, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "549c7f134f77471b97b091d80a911a79", async() => {
                    BeginContext(1183, 17, true);
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
                BeginContext(1204, 6, true);
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
            BeginContext(1217, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoLP3_4bim.Models.Autor> Html { get; private set; }
    }
}
#pragma warning restore 1591
