#pragma checksum "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Home\Detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aa783c4a7760d7e32ad657fee9b2a972bd189b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detalles), @"mvc.1.0.view", @"/Views/Home/Detalles.cshtml")]
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
#line 1 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\_ViewImports.cshtml"
using Paisajes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\_ViewImports.cshtml"
using Paisajes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aa783c4a7760d7e32ad657fee9b2a972bd189b0", @"/Views/Home/Detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452092a2b150edbfced4ade32e8314a857e70e73", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detalles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Turismo.Models.PaisajeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Home\Detalles.cshtml"
  
    ViewData["Title"] = "Detalles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .contenedor{\r\n        background-color: rgba(0, 0, 0, 0.6);\r\n    }\r\n</style>\r\n\r\n<div class=\"container\">\r\n   <h2><u class=\"text-white\">Lugar: ");
#nullable restore
#line 13 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Home\Detalles.cshtml"
                               Write(Model.Lugar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></h2> \r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4 img-container\">\r\n        <div class=\"img-big img-responsive\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 393, "\"", 422, 2);
            WriteAttributeValue("", 399, "/Image/", 399, 7, true);
#nullable restore
#line 19 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Home\Detalles.cshtml"
WriteAttributeValue("", 406, Model.ImageName, 406, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\">\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-8 text-white\" >\r\n        <div class=\"row\">            \r\n        <div class=\"col-md-6\">\r\n            <h4>PAIS: ");
#nullable restore
#line 25 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Home\Detalles.cshtml"
                 Write(Model.paisModel.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <h6>PROVINCIA: ");
#nullable restore
#line 26 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Home\Detalles.cshtml"
                      Write(Model.provinciaModel.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6>CIUDAD: ");
#nullable restore
#line 27 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Home\Detalles.cshtml"
                   Write(Model.ciudadModel.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 28 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Home\Detalles.cshtml"
             for (int i = 0; i < @Model.Valoracion; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <i class=\"fas fa-star text-warning\"></i>\r\n");
#nullable restore
#line 31 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Home\Detalles.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-2 d-flex justify-content-end\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 994, "\"", 1033, 2);
            WriteAttributeValue("", 1000, "/Image/", 1000, 7, true);
#nullable restore
#line 34 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Home\Detalles.cshtml"
WriteAttributeValue("", 1007, Model.paisModel.ImageName, 1007, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"150\"");
            BeginWriteAttribute("alt", " alt=\"", 1059, "\"", 1065, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-rounded"">
        </div> 
        </div>
    </div>
</div>
<div class=""conteiner text-white"">
    <div class=""row"">
        <div class=""col-md-6"">
            <h5>
                Descripción del lugar:
            </h5>
            <h6>
                ");
#nullable restore
#line 46 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Home\Detalles.cshtml"
           Write(Model.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h6>\r\n        </div>\r\n        <div class=\"col-md-6 d-flex justify-content-center\">\r\n            <iframe");
            BeginWriteAttribute("src", " src=\"", 1480, "\"", 1502, 1);
#nullable restore
#line 50 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Home\Detalles.cshtml"
WriteAttributeValue("", 1486, Model.Direccion, 1486, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"responsive-iframe\" width=\"500\" height=\"350\" frameborder=\"0\"></iframe>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Turismo.Models.PaisajeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591