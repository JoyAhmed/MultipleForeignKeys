#pragma checksum "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "638009c848b484fbb1e8245fc7a16fc4cbc99108"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
#line 1 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\_ViewImports.cshtml"
using MultiForeignKeys;

#line default
#line hidden
#line 2 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\_ViewImports.cshtml"
using MultiForeignKeys.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"638009c848b484fbb1e8245fc7a16fc4cbc99108", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f0a2fd733cb9e87f4b25258733c8abf751e2cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MultiForeignKeys.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(126, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "638009c848b484fbb1e8245fc7a16fc4cbc991084782", async() => {
                BeginContext(149, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(163, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(256, 48, false);
#line 16 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeName));

#line default
#line hidden
            EndContext();
            BeginContext(304, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(360, 43, false);
#line 19 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TypeOne));

#line default
#line hidden
            EndContext();
            BeginContext(403, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(459, 43, false);
#line 22 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TypeTwo));

#line default
#line hidden
            EndContext();
            BeginContext(502, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(558, 45, false);
#line 25 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TypeThree));

#line default
#line hidden
            EndContext();
            BeginContext(603, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(659, 46, false);
#line 28 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ForTypeOne));

#line default
#line hidden
            EndContext();
            BeginContext(705, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(761, 46, false);
#line 31 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ForTypeTwo));

#line default
#line hidden
            EndContext();
            BeginContext(807, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(863, 48, false);
#line 34 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ForTypeThree));

#line default
#line hidden
            EndContext();
            BeginContext(911, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1029, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1078, 47, false);
#line 43 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeName));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1181, 49, false);
#line 46 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TypeOne.TypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1286, 49, false);
#line 49 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TypeTwo.TypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1335, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1391, 51, false);
#line 52 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TypeThree.TypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1442, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1498, 59, false);
#line 55 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ForTypeOne.DesignationId));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1613, 59, false);
#line 58 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ForTypeTwo.DesignationId));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1728, 61, false);
#line 61 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ForTypeThree.DesignationId));

#line default
#line hidden
            EndContext();
            BeginContext(1789, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1844, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "638009c848b484fbb1e8245fc7a16fc4cbc9910812728", async() => {
                BeginContext(1897, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
                                       WriteLiteral(item.EmployeeId);

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
            BeginContext(1905, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1925, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "638009c848b484fbb1e8245fc7a16fc4cbc9910815093", async() => {
                BeginContext(1981, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
                                          WriteLiteral(item.EmployeeId);

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
            BeginContext(1992, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2012, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "638009c848b484fbb1e8245fc7a16fc4cbc9910817464", async() => {
                BeginContext(2067, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
                                         WriteLiteral(item.EmployeeId);

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
            BeginContext(2077, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 69 "E:\ASP.NET Projects\Examples\MultiForeignKeys\MultiForeignKeys\Views\Employee\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2116, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MultiForeignKeys.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
