#pragma checksum "C:\Users\Aravind\source\repos\CheckoutEPay\Pages\TransactionReport\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f285d0a63a7a3aca66323702a83f396335b89f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_TransactionReport_Create), @"mvc.1.0.razor-page", @"/Pages/TransactionReport/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f285d0a63a7a3aca66323702a83f396335b89f8", @"/Pages/TransactionReport/Create.cshtml")]
    public class Pages_TransactionReport_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Aravind\source\repos\CheckoutEPay\Pages\TransactionReport\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""AuthoriseCardRequestModel.CardHolderName"" class=""control-label""></label>
                <input asp-for=""AuthoriseCardRequestModel.CardHolderName"" class=""form-control"" />
                <span asp-validation-for=""AuthoriseCardRequestModel.CardHolderName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AuthoriseCardRequestModel.CardNumber"" class=""control-label""></label>
                <input asp-for=""AuthoriseCardRequestModel.CardNumber"" class=""form-control"" />
                <span asp-validation-for=""AuthoriseCardRequestModel.CardNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AuthoriseCardRequestModel.Ex");
            WriteLiteral(@"piryMonth"" class=""control-label""></label>
                <input asp-for=""AuthoriseCardRequestModel.ExpiryMonth"" class=""form-control"" />
                <span asp-validation-for=""AuthoriseCardRequestModel.ExpiryMonth"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AuthoriseCardRequestModel.ExpiryYear"" class=""control-label""></label>
                <input asp-for=""AuthoriseCardRequestModel.ExpiryYear"" class=""form-control"" />
                <span asp-validation-for=""AuthoriseCardRequestModel.ExpiryYear"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AuthoriseCardRequestModel.Cvv"" class=""control-label""></label>
                <input asp-for=""AuthoriseCardRequestModel.Cvv"" class=""form-control"" />
                <span asp-validation-for=""AuthoriseCardRequestModel.Cvv"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
          ");
            WriteLiteral(@"      <label asp-for=""AuthoriseCardRequestModel.Currency"" class=""control-label""></label>
                <input asp-for=""AuthoriseCardRequestModel.Currency"" class=""form-control"" />
                <span asp-validation-for=""AuthoriseCardRequestModel.Currency"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AuthoriseCardRequestModel.Amount"" class=""control-label""></label>
                <input asp-for=""AuthoriseCardRequestModel.Amount"" class=""form-control"" />
                <span asp-validation-for=""AuthoriseCardRequestModel.Amount"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AuthoriseCardRequestModel.TransactionId"" class=""control-label""></label>
                <input asp-for=""AuthoriseCardRequestModel.TransactionId"" class=""form-control"" />
                <span asp-validation-for=""AuthoriseCardRequestModel.TransactionId"" class=""text-danger""></span>
         ");
            WriteLiteral(@"   </div>
            <div class=""form-group"">
                <label asp-for=""AuthoriseCardRequestModel.MerchantId"" class=""control-label""></label>
                <input asp-for=""AuthoriseCardRequestModel.MerchantId"" class=""form-control"" />
                <span asp-validation-for=""AuthoriseCardRequestModel.MerchantId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AuthoriseCardRequestModel.ProcessedDate"" class=""control-label""></label>
                <input asp-for=""AuthoriseCardRequestModel.ProcessedDate"" class=""form-control"" />
                <span asp-validation-for=""AuthoriseCardRequestModel.ProcessedDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Users\Aravind\source\repos\CheckoutEPay\Pages\TransactionReport\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckoutEPay.Pages.TransactionReport.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CheckoutEPay.Pages.TransactionReport.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CheckoutEPay.Pages.TransactionReport.CreateModel>)PageContext?.ViewData;
        public CheckoutEPay.Pages.TransactionReport.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
