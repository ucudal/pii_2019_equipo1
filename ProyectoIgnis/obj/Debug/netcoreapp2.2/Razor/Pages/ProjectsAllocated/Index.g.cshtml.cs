#pragma checksum "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "923d682589d6994c47b83184dcb881450e47bac2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoIgnis.Pages.ProjectsAllocated.Pages_ProjectsAllocated_Index), @"mvc.1.0.razor-page", @"/Pages/ProjectsAllocated/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ProjectsAllocated/Index.cshtml", typeof(ProyectoIgnis.Pages.ProjectsAllocated.Pages_ProjectsAllocated_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"923d682589d6994c47b83184dcb881450e47bac2", @"/Pages/ProjectsAllocated/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1213032042a9fd4b3c311f823ea2e17474b93b3e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ProjectsAllocated_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(107, 178, true);
            WriteLiteral("\r\n<h2>Proyectos en curso</h2>\r\n\r\n<!-- <p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p> -->\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(286, 64, false);
#line 17 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProjectAllocated[0].HourLoad));

#line default
#line hidden
            EndContext();
            BeginContext(350, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(406, 67, false);
#line 20 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProjectAllocated[0].Description));

#line default
#line hidden
            EndContext();
            BeginContext(473, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(529, 62, false);
#line 23 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProjectAllocated[0].Client));

#line default
#line hidden
            EndContext();
            BeginContext(591, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(647, 60, false);
#line 26 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProjectAllocated[0].Role));

#line default
#line hidden
            EndContext();
            BeginContext(707, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(763, 61, false);
#line 29 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProjectAllocated[0].Level));

#line default
#line hidden
            EndContext();
            BeginContext(824, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
 foreach (var item in Model.ProjectAllocated) {

#line default
#line hidden
            BeginContext(959, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1008, 43, false);
#line 38 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HourLoad));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1107, 46, false);
#line 41 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1209, 41, false);
#line 44 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Client));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1306, 39, false);
#line 47 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Role));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1401, 40, false);
#line 50 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Level));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1496, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "923d682589d6994c47b83184dcb881450e47bac29390", async() => {
                BeginContext(1541, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
                                       WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1549, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1569, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "923d682589d6994c47b83184dcb881450e47bac211724", async() => {
                BeginContext(1617, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1628, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1648, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "923d682589d6994c47b83184dcb881450e47bac214065", async() => {
                BeginContext(1695, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1705, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "/Users/felipeperdomo/Documents/GitHub/pii_2019_equipo1/ProyectoIgnis/Pages/ProjectsAllocated/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1744, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoIgnis.Pages.ProjectsAllocated.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoIgnis.Pages.ProjectsAllocated.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoIgnis.Pages.ProjectsAllocated.IndexModel>)PageContext?.ViewData;
        public ProyectoIgnis.Pages.ProjectsAllocated.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
