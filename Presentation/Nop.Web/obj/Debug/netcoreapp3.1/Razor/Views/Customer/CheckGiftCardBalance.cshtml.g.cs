#pragma checksum "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66353392775f9cf744c72e850dbbfb471571717c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CheckGiftCardBalance), @"mvc.1.0.view", @"/Views/Customer/CheckGiftCardBalance.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 8 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
using Nop.Services.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66353392775f9cf744c72e850dbbfb471571717c", @"/Views/Customer/CheckGiftCardBalance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7654b745a4afa95f40d704ba2b1e9f7718148f30", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_CheckGiftCardBalance : Nop.Web.Framework.Mvc.Razor.NopRazorPage<CheckGiftCardBalanceModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("message-error"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-postfix", ":", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fullname"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckGiftCardBalance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.LabelTagHelper __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper __Nop_Web_Framework_TagHelpers_Public_InputTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Shared.NopRequiredTagHelper __Nop_Web_Framework_TagHelpers_Shared_NopRequiredTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.NopGenerateCaptchaTagHelper __Nop_Web_Framework_TagHelpers_Public_NopGenerateCaptchaTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
  
    var isRegisterCustomer = customerService.IsRegistered(workContext.CurrentCustomer);
    Layout = isRegisterCustomer ? "_ColumnsTwo" : "_ColumnsOne";

    //title
    Html.AddTitleParts(T("PageTitle.CheckGiftCardBalance").Text);
    //page class
    Html.AppendPageCssClassParts("html-account-page");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
 if (isRegisterCustomer)
{
    

#line default
#line hidden
#nullable disable
            DefineSection("left", async() => {
                WriteLiteral("\r\n        ");
#nullable restore
#line 23 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
   Write(await Component.InvokeAsync("CustomerNavigation", new { selectedTabId = CustomerNavigationEnum.CheckGiftCardBalance }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
#nullable restore
#line 24 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"page account-page check-gift-card-balance-page\">\r\n    <div class=\"page-title\">\r\n");
#nullable restore
#line 30 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
         if (isRegisterCustomer)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>");
#nullable restore
#line 32 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
           Write(T("Account.MyAccount"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 32 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
                                     Write(T("PageTitle.CheckGiftCardBalance"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 33 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>");
#nullable restore
#line 36 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
           Write(T("PageTitle.CheckGiftCardBalance"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 37 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"page-body\">\r\n");
#nullable restore
#line 40 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
         if (!string.IsNullOrEmpty(Model.Message))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"message-error\">\r\n                ");
#nullable restore
#line 43 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
           Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 45 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
         if (!string.IsNullOrEmpty(Model.Result))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"result\">\r\n                ");
#nullable restore
#line 49 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
           Write(string.Format(T("ShoppingCart.Totals.GiftCardInfo.Remaining").Text, @Model.Result));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 51 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66353392775f9cf744c72e850dbbfb471571717c17982", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66353392775f9cf744c72e850dbbfb471571717c18253", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 53 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"fieldset\">\r\n                <div class=\"form-fields\">\r\n                    <div class=\"inputs\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66353392775f9cf744c72e850dbbfb471571717c20118", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_LabelTagHelper);
#nullable restore
#line 57 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GiftCardCode);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For;
                __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper.Postfix = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66353392775f9cf744c72e850dbbfb471571717c22279", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
#nullable restore
#line 58 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
__Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GiftCardCode);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 58 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
AddHtmlAttributeValue("", 1914, T("ShoppingCart.GiftCardCouponCode.Tooltip"), 1914, 45, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-required", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66353392775f9cf744c72e850dbbfb471571717c24470", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Shared_NopRequiredTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Shared.NopRequiredTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Shared_NopRequiredTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66353392775f9cf744c72e850dbbfb471571717c25479", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 60 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GiftCardCode);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-captcha", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66353392775f9cf744c72e850dbbfb471571717c27137", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Public_NopGenerateCaptchaTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.NopGenerateCaptchaTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_NopGenerateCaptchaTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"buttons\">\r\n                    <input type=\"submit\" name=\"checkbalancegiftcard\" id=\"checkbalancegiftcard\" class=\"button-1 check-gift-card-balance-button\"");
                BeginWriteAttribute("value", " value=\"", 2367, "\"", 2420, 1);
#nullable restore
#line 65 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
WriteAttributeValue("", 2375, T("CheckGiftCard.GiftCardCouponCode.Button"), 2375, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66353392775f9cf744c72e850dbbfb471571717c28838", async() => {
                    WriteLiteral(@"
                        $(document).ready(function () {
                            $('#giftcardcouponcode').keydown(function (event) {
                                if (event.keyCode == 13) {
                                    $('#checkbalancegiftcard').click();
                                    return false;
                                }
                            });
                        });
                    ");
                }
                );
                __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper);
#nullable restore
#line 66 "C:\Users\qiConsole\source\repos\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\CheckGiftCardBalance.cshtml"
__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location = global::Nop.Web.Framework.UI.ResourceLocation.Footer;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-location", __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICustomerService customerService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckGiftCardBalanceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
