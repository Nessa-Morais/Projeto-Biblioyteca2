#pragma checksum "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80dfaad39c6dd28c6c2a21e7fdcef2a90d81dd2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livro_Listagem), @"mvc.1.0.view", @"/Views/Livro/Listagem.cshtml")]
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
#line 1 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80dfaad39c6dd28c6c2a21e7fdcef2a90d81dd2b", @"/Views/Livro/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac979cfa6f9c2014e1ebeda333546c494974b6fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Livro_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Livro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "t", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "a", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Livro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Listagem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Listagem de Livros</h2>\n<h4>");
#nullable restore
#line 6 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
Write(ViewData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n\n\n             <div class=\"row\">\n            <div class=\"col-md-12\"> \n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80dfaad39c6dd28c6c2a21e7fdcef2a90d81dd2b5424", async() => {
                WriteLiteral(@"
                
                
                    
                   
                   <div class=""form-group mb-2 mx-sm-3"">
                    <p style=""float:left; margin-right:10px;"">Pesquisar: <input type=""text"" name=""q"" /></p>
                    </div>

                    <div class=""form-group mb-2"">
                    <p>Ordenação:
                        <select name=""ordem"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80dfaad39c6dd28c6c2a21e7fdcef2a90d81dd2b6118", async() => {
                    WriteLiteral("Título");
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
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80dfaad39c6dd28c6c2a21e7fdcef2a90d81dd2b7367", async() => {
                    WriteLiteral("Autor");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </select>\n                         <input type=\"submit\" value=\"buscar\" />\n                    </p>\n                   </div>\n\n                   \n                \n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n           </div>\n</div>\n\n\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n");
#nullable restore
#line 41 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
 if (Model.Count != 0)
{



#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-striped"">

        <thead>
            <tr>
                <th>Id</th>
                <th>Titulo</th>
                <th>Autor</th>
                <th>Ano</th>
            </tr>
        </thead>
        
        
               
        <tbody>
");
#nullable restore
#line 59 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
              foreach (Livro l in Model)
            {
           

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 63 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
                   Write(l.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 64 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
                   Write(l.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 65 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
                   Write(l.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 66 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
                   Write(l.Ano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1664, "\"", 1693, 2);
            WriteAttributeValue("", 1671, "/Livro/Edicao?id=", 1671, 17, true);
#nullable restore
#line 68 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
WriteAttributeValue("", 1688, l.Id, 1688, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\n                        \n                    </td>\n                </tr>\n");
#nullable restore
#line 72 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n        \n            \n\n    </table>\n");
#nullable restore
#line 80 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
    for(int i = 1; i <=(int)ViewData["quantpaginas"];i++){ // paginação cria os links para as pginas 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 1965, "\"", 1992, 2);
            WriteAttributeValue("", 1972, "/Livro/Listagem?p=", 1972, 18, true);
#nullable restore
#line 81 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
WriteAttributeValue("", 1990, i, 1990, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >");
#nullable restore
#line 81 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</a>\n");
#nullable restore
#line 82 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
     
    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("     <strong class=\"text-center\">Nenhum registro encontrado</strong>\n");
#nullable restore
#line 86 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Livro\Listagem.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Livro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
