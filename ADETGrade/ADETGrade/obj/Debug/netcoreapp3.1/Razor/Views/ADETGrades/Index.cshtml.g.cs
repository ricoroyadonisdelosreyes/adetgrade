#pragma checksum "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ecbf32a12743ea6a2ec55c3ea0948ae68f65a1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ADETGrades_Index), @"mvc.1.0.view", @"/Views/ADETGrades/Index.cshtml")]
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
#line 1 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\_ViewImports.cshtml"
using ADETGrade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\_ViewImports.cshtml"
using ADETGrade.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ecbf32a12743ea6a2ec55c3ea0948ae68f65a1f", @"/Views/ADETGrades/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79726cc2765384d3f7457db6eade42eec8fd4b5a", @"/Views/_ViewImports.cshtml")]
    public class Views_ADETGrades_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ADETGrade.Models.ADETGrades>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ecbf32a12743ea6a2ec55c3ea0948ae68f65a1f4567", async() => {
                WriteLiteral("Add New");
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
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th width=""300"">

            </th>
            <th>

            </th>
            <th colspan=""7"">
                Prelim
            </th>
            <th colspan=""7"">
                MidTerm
            </th>
            <th colspan=""7"">
                PreFinal
            </th>
            <th colspan=""7"">
                Final
            </th>
            <th colspan=""4"">
                
            </th>
        </tr>

        <tr>
            <th width=""500"">
                ");
#nullable restore
#line 40 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StudName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n              \r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrelimQ1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrelimQ2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrelimQ3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrelimA1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrelimA2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrelimA3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrelimTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 68 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MidtermQ1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 71 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MidtermQ2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 74 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MidtermQ3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 77 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MidtermA1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 80 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MidtermA2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 83 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MidtermA3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 86 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MidTermTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 89 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PreFinalQ1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 92 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PreFinalQ2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 95 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PreFinalQ3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 98 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PreFinalA1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 101 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PreFinalA2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 104 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PreFinalA3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 107 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PreFinalTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 110 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FinalQ1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 113 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FinalQ2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 116 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FinalQ3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 119 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FinalA1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 122 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FinalA2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 125 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FinalA3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 128 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FinalTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 134 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 137 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StudName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 140 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 144 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrelimQ1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 147 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrelimQ2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 150 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrelimQ3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 153 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrelimA1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 156 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrelimA2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 159 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrelimA3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 162 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrelimTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 165 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MidtermQ1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 168 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MidtermQ2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 171 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MidtermQ3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 174 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MidtermA1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 177 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MidtermA2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 180 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MidtermA3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 183 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MidTermTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 186 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PreFinalQ1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 189 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PreFinalQ2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 192 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PreFinalQ3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 195 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PreFinalA1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 198 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PreFinalA2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 201 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PreFinalA3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 204 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PreFinalTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 207 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FinalQ1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 210 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FinalQ2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 213 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FinalQ3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 216 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FinalA1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 219 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FinalA2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 222 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FinalA3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 225 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FinalTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ecbf32a12743ea6a2ec55c3ea0948ae68f65a1f25595", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 227 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ecbf32a12743ea6a2ec55c3ea0948ae68f65a1f27762", async() => {
                WriteLiteral("Details");
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
#nullable restore
#line 228 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ecbf32a12743ea6a2ec55c3ea0948ae68f65a1f29935", async() => {
                WriteLiteral("Delete");
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
#nullable restore
#line 229 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 231 "C:\Users\USER\source\repos\ADETGrade\ADETGrade\Views\ADETGrades\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ADETGrade.Models.ADETGrades>> Html { get; private set; }
    }
}
#pragma warning restore 1591
