#pragma checksum "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "959769a09a87fdbda31f269a9da09a41cfd53efe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DimensionDatasets_Details), @"mvc.1.0.view", @"/Views/DimensionDatasets/Details.cshtml")]
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
#line 1 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\_ViewImports.cshtml"
using MyMVCProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\_ViewImports.cshtml"
using MyMVCProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"959769a09a87fdbda31f269a9da09a41cfd53efe", @"/Views/DimensionDatasets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"487eadc073acf40b4c4a1d32e7f2890941456a8e", @"/Views/_ViewImports.cshtml")]
    public class Views_DimensionDatasets_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyMVCProject.Models.DimensionDataset>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>DimensionDataset</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 134 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 137 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 140 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 143 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 146 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 149 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 152 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 155 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 158 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 161 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 164 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 167 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 170 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 173 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 176 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 179 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 182 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 185 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 188 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 191 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 194 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 197 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 200 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 203 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 206 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 209 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 212 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 215 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "959769a09a87fdbda31f269a9da09a41cfd53efe27327", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 220 "C:\Users\Hp Pc\source\repos\MyMVCProject\MyMVCProject\Views\DimensionDatasets\Details.cshtml"
                           WriteLiteral(Model.EmployeeNumber);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "959769a09a87fdbda31f269a9da09a41cfd53efe29496", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyMVCProject.Models.DimensionDataset> Html { get; private set; }
    }
}
#pragma warning restore 1591
