#pragma checksum "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Paisajes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31fda3c48dbe584496c397a43e4baaf06411fe3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paisajes_Details), @"mvc.1.0.view", @"/Views/Paisajes/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31fda3c48dbe584496c397a43e4baaf06411fe3a", @"/Views/Paisajes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452092a2b150edbfced4ade32e8314a857e70e73", @"/Views/_ViewImports.cshtml")]
    public class Views_Paisajes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Turismo.Models.PaisajeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Paisajes\Details.cshtml"
  
    ViewData["Title"] = "Detalles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31fda3c48dbe584496c397a43e4baaf06411fe3a3603", async() => {
                WriteLiteral("<i class=\"fas fa-arrow-left\"></i> Volver");
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
            WriteLiteral("\r\n\r\n<h4>Detalles</h4>\r\n<hr />\r\n<div class=\"container\">\r\n    <div class=\"col-md-4\">\r\n        <div class=\"row\">\r\n            <dt class=\"col-md-2\">\r\n                ");
#nullable restore
#line 15 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Paisajes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.paisModel.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-md-10\">\r\n                ");
#nullable restore
#line 18 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Paisajes\Details.cshtml"
           Write(Html.DisplayFor(model => model.paisModel.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-md-2\">\r\n                ");
#nullable restore
#line 21 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Paisajes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.provinciaModel.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-md-10\">\r\n                ");
#nullable restore
#line 24 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Paisajes\Details.cshtml"
           Write(Html.DisplayFor(model => model.provinciaModel.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-md-2\">\r\n                ");
#nullable restore
#line 27 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Paisajes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ciudadModel.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-md-10\">\r\n                ");
#nullable restore
#line 30 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Paisajes\Details.cshtml"
           Write(Html.DisplayFor(model => model.ciudadModel.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-md-2\">\r\n                ");
#nullable restore
#line 33 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Paisajes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Lugar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-md-10\">\r\n                ");
#nullable restore
#line 36 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Paisajes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Lugar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 42 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Paisajes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-10\"> \r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1452, "\"", 1481, 2);
            WriteAttributeValue("", 1458, "/Image/", 1458, 7, true);
#nullable restore
#line 45 "C:\Users\usuario\Documents\dotnet\Paisajes\Views\Paisajes\Details.cshtml"
WriteAttributeValue("", 1465, Model.ImageName, 1465, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\"");
            BeginWriteAttribute("alt", " alt=\"", 1494, "\"", 1500, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </dd>\r\n    </div>\r\n</div>  \r\n  ");
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
