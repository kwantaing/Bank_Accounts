#pragma checksum "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/BankAccount/Views/Home/Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1da759efee93f8a96caa6abb22862b674cca71c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Info), @"mvc.1.0.view", @"/Views/Home/Info.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Info.cshtml", typeof(AspNetCore.Views_Home_Info))]
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
#line 1 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/BankAccount/Views/_ViewImports.cshtml"
using BankAccount;

#line default
#line hidden
#line 2 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/BankAccount/Views/_ViewImports.cshtml"
using BankAccount.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1da759efee93f8a96caa6abb22862b674cca71c8", @"/Views/Home/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b20f887a8df0d276701ac0f260ce405b9af56dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("controller", new global::Microsoft.AspNetCore.Html.HtmlString("Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "newTransaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(13, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1da759efee93f8a96caa6abb22862b674cca71c84682", async() => {
                BeginContext(54, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(64, 61, true);
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-3\">Welcome ");
            EndContext();
            BeginContext(126, 15, false);
#line 5 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/BankAccount/Views/Home/Info.cshtml"
                             Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(141, 92, true);
            WriteLiteral("</h1>\n    <h3 class=\"display-5\">Make a transaction</h3>\n    <h4 class=\"display-5\">You have $");
            EndContext();
            BeginContext(234, 27, false);
#line 7 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/BankAccount/Views/Home/Info.cshtml"
                               Write(Math.Round(Model.balance,2));

#line default
#line hidden
            EndContext();
            BeginContext(261, 11, true);
            WriteLiteral("</h4>\n\n    ");
            EndContext();
            BeginContext(272, 391, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1da759efee93f8a96caa6abb22862b674cca71c86999", async() => {
                BeginContext(338, 235, true);
                WriteLiteral("\n        <span for=\"amount\"class=\"error\"></span>\n        <label for=\"amount\">Deposit/ Withdraw</label>\n        <input style=\"text-align:center\" type=\"text\" name=\"amount\" placeholder=\"100.00\">\n        <input type=\"hidden\" name=\"user_id\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 573, "", 594, 1);
#line 13 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/BankAccount/Views/Home/Info.cshtml"
WriteAttributeValue("", 580, Model.user_id, 580, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(594, 62, true);
                WriteLiteral(">\n        <button class=\"btn btn-primary\">Submit</button>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(663, 187, true);
            WriteLiteral("\n    <table class=\"table table-striped\">\n        <thead>\n            <tr>\n                <th>Amount</th>\n                <th>Date</th>\n            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 24 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/BankAccount/Views/Home/Info.cshtml"
             foreach(var transaction in Model.UserTransactions){

#line default
#line hidden
            BeginContext(915, 46, true);
            WriteLiteral("                <tr>\n                    <td>$");
            EndContext();
            BeginContext(962, 32, false);
#line 26 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/BankAccount/Views/Home/Info.cshtml"
                    Write(Math.Round(transaction.amount,2));

#line default
#line hidden
            EndContext();
            BeginContext(994, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1025, 21, false);
#line 27 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/BankAccount/Views/Home/Info.cshtml"
                   Write(transaction.createdAt);

#line default
#line hidden
            EndContext();
            BeginContext(1046, 28, true);
            WriteLiteral("</td>\n                </tr>\n");
            EndContext();
#line 29 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/BankAccount/Views/Home/Info.cshtml"
            }

#line default
#line hidden
            BeginContext(1088, 36, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
