#pragma checksum "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/Projects/Allocate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23ab6ec66bdc7cde9a326a293022b5fed8a4d2b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoIgnis.Pages.Projects.Pages_Projects_Allocate), @"mvc.1.0.razor-page", @"/Pages/Projects/Allocate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Projects/Allocate.cshtml", typeof(ProyectoIgnis.Pages.Projects.Pages_Projects_Allocate), null)]
namespace ProyectoIgnis.Pages.Projects
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/_ViewImports.cshtml"
using ProyectoIgnis;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ab6ec66bdc7cde9a326a293022b5fed8a4d2b6", @"/Pages/Projects/Allocate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1213032042a9fd4b3c311f823ea2e17474b93b3e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Projects_Allocate : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/Projects/Allocate.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(97, 145, true);
            WriteLiteral("\n<h1>Asignar tecnico</h1>\n\n<div>\n    <h4>Tecnico</h4>\n    <hr />\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(243, 68, false);
#line 17 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/Projects/Allocate.cshtml"
           Write(Html.DisplayNameFor(model => model.Technician.FirstOrDefault().Name));

#line default
#line hidden
            EndContext();
            BeginContext(311, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(364, 72, false);
#line 20 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/Projects/Allocate.cshtml"
           Write(Html.DisplayNameFor(model => model.Technician.FirstOrDefault().LastName));

#line default
#line hidden
            EndContext();
            BeginContext(436, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(489, 69, false);
#line 23 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/Projects/Allocate.cshtml"
           Write(Html.DisplayNameFor(model => model.Technician.FirstOrDefault().Level));

#line default
#line hidden
            EndContext();
            BeginContext(558, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(611, 68, false);
#line 26 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/Projects/Allocate.cshtml"
           Write(Html.DisplayNameFor(model => model.Technician.FirstOrDefault().Role));

#line default
#line hidden
            EndContext();
            BeginContext(679, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 32 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/Projects/Allocate.cshtml"
 foreach (var item in Model.Technician)
{

#line default
#line hidden
            BeginContext(801, 50, true);
            WriteLiteral("            <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(852, 39, false);
#line 36 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/Projects/Allocate.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(891, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(944, 43, false);
#line 39 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/Projects/Allocate.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(987, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1040, 40, false);
#line 42 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/Projects/Allocate.cshtml"
           Write(Html.DisplayFor(modelItem => item.Level));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1133, 39, false);
#line 45 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/Projects/Allocate.cshtml"
           Write(Html.DisplayFor(modelItem => item.Role));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 48, true);
            WriteLiteral("\n            </td>\n            <td>\n            ");
            EndContext();
            BeginContext(1220, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ab6ec66bdc7cde9a326a293022b5fed8a4d2b68673", async() => {
                BeginContext(1240, 17, true);
                WriteLiteral("\n                ");
                EndContext();
                BeginContext(1257, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "23ab6ec66bdc7cde9a326a293022b5fed8a4d2b69066", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 49 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/Projects/Allocate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Project);

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
                BeginContext(1296, 91, true);
                WriteLiteral("\n                <input type=\"submit\" value=\"Select\" class=\"btn btn-danger\" />\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1394, 40, true);
            WriteLiteral("\n            </td>   \n            </tr>\n");
            EndContext();
#line 54 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/Projects/Allocate.cshtml"
}

#line default
#line hidden
            BeginContext(1436, 33, true);
            WriteLiteral("    </tbody>\n</table>\n\n<div>\n    ");
            EndContext();
            BeginContext(1469, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ab6ec66bdc7cde9a326a293022b5fed8a4d2b612539", async() => {
                BeginContext(1491, 17, true);
                WriteLiteral("Volver a la lista");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1512, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1539, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 63 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/Projects/Allocate.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoIgnis.Pages.Projects.AllocateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoIgnis.Pages.Projects.AllocateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoIgnis.Pages.Projects.AllocateModel>)PageContext?.ViewData;
        public ProyectoIgnis.Pages.Projects.AllocateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
