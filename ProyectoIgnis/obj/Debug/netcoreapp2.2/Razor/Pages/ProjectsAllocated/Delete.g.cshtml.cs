#pragma checksum "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dee08c2d926c1face70238d64567bad1920cbbeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoIgnis.Pages.ProjectsAllocated.Pages_ProjectsAllocated_Delete), @"mvc.1.0.razor-page", @"/Pages/ProjectsAllocated/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ProjectsAllocated/Delete.cshtml", typeof(ProyectoIgnis.Pages.ProjectsAllocated.Pages_ProjectsAllocated_Delete), null)]
namespace ProyectoIgnis.Pages.ProjectsAllocated
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dee08c2d926c1face70238d64567bad1920cbbeb", @"/Pages/ProjectsAllocated/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1213032042a9fd4b3c311f823ea2e17474b93b3e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ProjectsAllocated_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(109, 177, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ProjectAllocated</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(287, 61, false);
#line 16 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectAllocated.HourLoad));

#line default
#line hidden
            EndContext();
            BeginContext(348, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(392, 57, false);
#line 19 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProjectAllocated.HourLoad));

#line default
#line hidden
            EndContext();
            BeginContext(449, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(493, 64, false);
#line 22 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectAllocated.Description));

#line default
#line hidden
            EndContext();
            BeginContext(557, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(601, 60, false);
#line 25 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProjectAllocated.Description));

#line default
#line hidden
            EndContext();
            BeginContext(661, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(705, 59, false);
#line 28 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectAllocated.Client));

#line default
#line hidden
            EndContext();
            BeginContext(764, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(808, 55, false);
#line 31 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProjectAllocated.Client));

#line default
#line hidden
            EndContext();
            BeginContext(863, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(907, 57, false);
#line 34 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectAllocated.Role));

#line default
#line hidden
            EndContext();
            BeginContext(964, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1008, 53, false);
#line 37 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProjectAllocated.Role));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1105, 58, false);
#line 40 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectAllocated.Level));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1207, 54, false);
#line 43 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProjectAllocated.Level));

#line default
#line hidden
            EndContext();
            BeginContext(1261, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1299, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dee08c2d926c1face70238d64567bad1920cbbeb9310", async() => {
                BeginContext(1319, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1329, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dee08c2d926c1face70238d64567bad1920cbbeb9697", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 48 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProjectAllocated.ID);

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
                BeginContext(1382, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1466, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dee08c2d926c1face70238d64567bad1920cbbeb11622", async() => {
                    BeginContext(1488, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1504, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1517, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoIgnis.Pages.ProjectsAllocated.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoIgnis.Pages.ProjectsAllocated.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoIgnis.Pages.ProjectsAllocated.DeleteModel>)PageContext?.ViewData;
        public ProyectoIgnis.Pages.ProjectsAllocated.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
