#pragma checksum "D:\Desktop\infor\Projeto Int\modulo1\ProjetoI4\Views\Pacotes\PacotesDisponiveis.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9feb840e7de629f7552f369310595656e7c95987"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacotes_PacotesDisponiveis), @"mvc.1.0.view", @"/Views/Pacotes/PacotesDisponiveis.cshtml")]
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
#line 1 "D:\Desktop\infor\Projeto Int\modulo1\ProjetoI4\Views\_ViewImports.cshtml"
using ProjetoI4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\infor\Projeto Int\modulo1\ProjetoI4\Views\_ViewImports.cshtml"
using ProjetoI4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9feb840e7de629f7552f369310595656e7c95987", @"/Views/Pacotes/PacotesDisponiveis.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46e88de4cd847bf4afa664578fc576eb404e4c08", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacotes_PacotesDisponiveis : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pacotes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Desktop\infor\Projeto Int\modulo1\ProjetoI4\Views\Pacotes\PacotesDisponiveis.cshtml"
  
    ViewData["Title"] = "Pacotes";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9feb840e7de629f7552f369310595656e7c959874332", async() => {
                WriteLiteral("\r\n    <div class=\"titulo2\">\r\n    <h1>Principais Destinos Expresso União</h1>\r\n    <p>Compre sua passagem de ônibus online.</p>\r\n     </div>\r\n    <main>\r\n        <div >\r\n");
#nullable restore
#line 12 "D:\Desktop\infor\Projeto Int\modulo1\ProjetoI4\Views\Pacotes\PacotesDisponiveis.cshtml"
          foreach (Pacotes p in Model)
         {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br>\r\n            <img class=\"viagens\" height=\"350\" width=\"600\"src=\"https://catracalivre.com.br/wp-content/uploads/2021/04/passagem-de-onibus.jpg\">\r\n            <br>\r\n            <div class=\"viagens\">\r\n           <h6 class=\"textoviagens\">");
#nullable restore
#line 18 "D:\Desktop\infor\Projeto Int\modulo1\ProjetoI4\Views\Pacotes\PacotesDisponiveis.cshtml"
                               Write(p.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n           <p>Saindo de ");
#nullable restore
#line 19 "D:\Desktop\infor\Projeto Int\modulo1\ProjetoI4\Views\Pacotes\PacotesDisponiveis.cshtml"
                   Write(p.Origem);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br>Destino:");
#nullable restore
#line 19 "D:\Desktop\infor\Projeto Int\modulo1\ProjetoI4\Views\Pacotes\PacotesDisponiveis.cshtml"
                                         Write(p.Destino);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>Saída: ");
#nullable restore
#line 19 "D:\Desktop\infor\Projeto Int\modulo1\ProjetoI4\Views\Pacotes\PacotesDisponiveis.cshtml"
                                                              Write(p.Saida);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br><br>valor: <br><b>");
#nullable restore
#line 19 "D:\Desktop\infor\Projeto Int\modulo1\ProjetoI4\Views\Pacotes\PacotesDisponiveis.cshtml"
                                                                                            Write(p.Valor);

#line default
#line hidden
#nullable disable
                WriteLiteral(" R$</b></p>\r\n           <input type=\"submit\" value=\"Comprar\">\r\n          </div>\r\n");
#nullable restore
#line 22 "D:\Desktop\infor\Projeto Int\modulo1\ProjetoI4\Views\Pacotes\PacotesDisponiveis.cshtml"
         }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    </main>\r\n   \r\n <footer class=\"footer2\">\r\n        <div class=\"footer\">\r\n            &copy; 2022 - Passagens Online - ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9feb840e7de629f7552f369310595656e7c959877174", async() => {
                    WriteLiteral("Expresso União");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n</footer>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pacotes>> Html { get; private set; }
    }
}
#pragma warning restore 1591