#pragma checksum "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3b603447562887cb4e27e7f6f11a895ecddcf6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Listagem), @"mvc.1.0.view", @"/Views/Emprestimo/Listagem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b603447562887cb4e27e7f6f11a895ecddcf6a", @"/Views/Emprestimo/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac979cfa6f9c2014e1ebeda333546c494974b6fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Emprestimo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Livro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Empréstimos";
    string classe = "";
     
    
    int FiltroPorPag = Int32.Parse(ViewData["livrosPorPagina"].ToString());
    int PaginaAtual = Int32.Parse(ViewData["PaginaAtual"].ToString());
    int NumLivroPorPag = (Model.Count < FiltroPorPag ? Model.Count : FiltroPorPag);
     
    int NumTotalDePag = 0;
     if(NumLivroPorPag > 0)
    { 
        NumTotalDePag = Model.Count / NumLivroPorPag + (Model.Count % NumLivroPorPag==0 ? 0 : 1); 
    }
   

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-12\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3b603447562887cb4e27e7f6f11a895ecddcf6a5661", async() => {
                WriteLiteral("\n        <div class=\"form-group mb-2\">\n            <select name=\"TipoFiltro\" class=\"form-control\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3b603447562887cb4e27e7f6f11a895ecddcf6a6039", async() => {
                    WriteLiteral("Usuário");
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
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3b603447562887cb4e27e7f6f11a895ecddcf6a7277", async() => {
                    WriteLiteral("Livro");
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
                WriteLiteral(@"
            </select>
        </div>
        <div class=""form-group mb-2 mx-sm-3"">
            <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
        </div>

         <div>
                <select name=""itensPorPagina"" id=""itensPorPagina"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3b603447562887cb4e27e7f6f11a895ecddcf6a8802", async() => {
                    WriteLiteral("Livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3b603447562887cb4e27e7f6f11a895ecddcf6a10043", async() => {
                    WriteLiteral(" Todos");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
                      WriteLiteral(Model.Count);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    \n                </select>\n            </div>\n\n        <button type=\"submit\" class=\"btn btn-primary mb-2\">Pesquisar</button>\n\n         <div id=\"SeletorPaginas\">\n");
#nullable restore
#line 43 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
                 for (int i = 1; i <= NumTotalDePag; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span><a");
                BeginWriteAttribute("href", " href=\"", 1498, "\"", 1540, 2);
                WriteAttributeValue("", 1505, "/Emprestimo/Listagem?PaginaAtual=", 1505, 33, true);
#nullable restore
#line 45 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 1538, i, 1538, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
#nullable restore
#line 45 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
                                                                    Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(",</a></span>\n");
#nullable restore
#line 46 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n \n");
#nullable restore
#line 55 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
  if (Model.Count != 0)
        {
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table  class=""table table-striped""> 
                        <thead>
                            <tr><th>Id</th>
                            <th>Usuario</th>
                            <th>Data Empréstimo</th>
                            <th>Data Devolução</th>
                            <th>Tituo do Livro</th>
                            <th>Autor</th>
                            <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            alerta de emprestimo atrazado
                        
                                                
");
#nullable restore
#line 73 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
                                                 for(int i = (PaginaAtual-1) * NumLivroPorPag; i < (NumLivroPorPag * PaginaAtual < Model.Count ? NumLivroPorPag * PaginaAtual : Model.Count); i++)
                                                {
                                                    if(System.DateTime.Compare(System.DateTime.Now,Model[i].DataDevolucao)>0){
                                                    classe="text-danger";
                                                    }else{classe="";}
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr");
            BeginWriteAttribute("class", " class=\"", 2977, "\"", 2992, 1);
#nullable restore
#line 79 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 2985, classe, 2985, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                <td>");
#nullable restore
#line 80 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
                                               Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 81 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
                                               Write(Model[i].NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 82 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
                                               Write(Model[i].DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 83 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
                                               Write(Model[i].DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 84 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
                                               Write(Model[i].Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 85 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
                                               Write(Model[i].Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td><a");
            BeginWriteAttribute("href", " href=\"", 3566, "\"", 3604, 2);
            WriteAttributeValue("", 3573, "/Emprestimo/Edicao/", 3573, 19, true);
#nullable restore
#line 86 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 3592, Model[i].Id, 3592, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\n                                            </tr>\n");
#nullable restore
#line 88 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
                                                    
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                \n\n                            \n                        </tbody>\n                    </table>\n");
#nullable restore
#line 95 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
        }  
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <strong class=\"text-center\">Nenhum registro encontrado</strong>\n");
#nullable restore
#line 99 "C:\Users\Vanessa\Downloads\bibiotecaAtv2JairoCesar-master\Views\Emprestimo\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591