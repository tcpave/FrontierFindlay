#pragma checksum "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00a9de3aa95a7bc5755e423115ae459449ca0023"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_StatusReport), @"mvc.1.0.view", @"/Views/Accounts/StatusReport.cshtml")]
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
#line 1 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\_ViewImports.cshtml"
using FrontierNETCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\_ViewImports.cshtml"
using FrontierNETCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00a9de3aa95a7bc5755e423115ae459449ca0023", @"/Views/Accounts/StatusReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2443d483519e2c4e00af5cbc5d12cc1567110698", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_StatusReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrontierNETCore.Models.AccountDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "AccountsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
  
    Layout = "~/Views/Shared/_Frontier.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"account-column grid\" id=\"active-account-column\">\r\n    <div class=\"account-container-title\" id=\"active-account-container-title\">\r\n        <h3>Active</h3>\r\n    </div>\r\n    <div class=\"account-container active-account\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
         foreach (var account in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
             if (account.AccountStatusId == FrontierNETCore.Code.AccountStatus.Active)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00a9de3aa95a7bc5755e423115ae459449ca00234618", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 17 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = account;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</section>

<section class=""account-column grid"" id=""overdue-account-column"">
    <div class=""account-container-title"" id=""overdue-account-container-title"">
        <h3>Overdue</h3>
    </div>
    <div class=""account-container overdue-account"">

");
#nullable restore
#line 30 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
         foreach (var account in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
             if (account.AccountStatusId == FrontierNETCore.Code.AccountStatus.Overdue)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00a9de3aa95a7bc5755e423115ae459449ca00237504", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 34 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = account;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</section>

<section class=""account-column grid"" id=""inactive-account-column"">
    <div class=""account-container-title"" id=""inactive-account-container-title"">
        <h3>Inactive</h3>
    </div>
    <div class=""account-container inactive-account"">

");
#nullable restore
#line 47 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
         foreach (var account in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
             if (account.AccountStatusId == FrontierNETCore.Code.AccountStatus.Inactive)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00a9de3aa95a7bc5755e423115ae459449ca002310395", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 51 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = account;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\brianfindlay\source\repos\FrontierCodeEx\FrontierNETCore\Views\Accounts\StatusReport.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FrontierNETCore.Models.AccountDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
