#pragma checksum "C:\Users\Aluno\Desktop\projetos\CadastroClientes\CadastroClientes\Views\Contato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "029b9d6e3039656cecd0f7f85fbb162232af94ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.view", @"/Views/Contato/Index.cshtml")]
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
#line 1 "C:\Users\Aluno\Desktop\projetos\CadastroClientes\CadastroClientes\Views\_ViewImports.cshtml"
using CadastroClientes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aluno\Desktop\projetos\CadastroClientes\CadastroClientes\Views\_ViewImports.cshtml"
using CadastroClientes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"029b9d6e3039656cecd0f7f85fbb162232af94ad", @"/Views/Contato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f63b3ca325a091ae1aa055db5a24b0368a87562", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Aluno\Desktop\projetos\CadastroClientes\CadastroClientes\Views\Contato\Index.cshtml"
  
    ViewData["Title"] = "Lista de Clientes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>LISTAGEM DE CLIENTES</h1>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Nome</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Telefone</th>
            <th scope=""col"">Opcões</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">1</th>
            <td>Mark</td>
            <td>Otto@email.com</td>
            <td>(11)94134-5820</td>
        </tr>
    </tbody>
</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
