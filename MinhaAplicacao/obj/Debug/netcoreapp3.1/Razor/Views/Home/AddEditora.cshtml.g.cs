#pragma checksum "C:\Users\matheus.santana\source\repos\MinhaAplicacao\MinhaAplicacao\Views\Home\AddEditora.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b88320758fbbff371da13372daeeffba817ee7dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddEditora), @"mvc.1.0.view", @"/Views/Home/AddEditora.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b88320758fbbff371da13372daeeffba817ee7dc", @"/Views/Home/AddEditora.cshtml")]
    public class Views_Home_AddEditora : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MinhaAplicacao.Models.Editora>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\matheus.santana\source\repos\MinhaAplicacao\MinhaAplicacao\Views\Home\AddEditora.cshtml"
  
    ViewData["Title"] = "AddEditora";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>AddEditora</h1>

<h4>Editora</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""AddEditora"" asp-controller=""Editoras"" method=""POST"">
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label""></label>
                <input asp-for=""Nome"" class=""form-control"" />
            </div>
            <div class=""form-group"">
                <label asp-for=""Apresentacao"" class=""control-label""></label>
                <input asp-for=""Apresentacao"" class=""form-control"" />
            </div>
            <div class=""form-group"">      
                <input type=""submit"" value=""Criar Editor(a)"" class=""btn btn-default"" />
            </div>           
        </form> 
    </div>
</div>
");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\matheus.santana\source\repos\MinhaAplicacao\MinhaAplicacao\Views\Home\AddEditora.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MinhaAplicacao.Models.Editora> Html { get; private set; }
    }
}
#pragma warning restore 1591
