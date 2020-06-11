#pragma checksum "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90886303c2d8ed818464be9dbe437a2c464971f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CatalogList), @"mvc.1.0.view", @"/Views/Admin/CatalogList.cshtml")]
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
#line 1 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.Entity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90886303c2d8ed818464be9dbe437a2c464971f0", @"/Views/Admin/CatalogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe07369f566bae69b76347c3bd591e67ad487862", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CatalogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CatalogListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/font-awesome/css/all.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
  
    ViewData["Title"] = "CatalogList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "90886303c2d8ed818464be9dbe437a2c464971f04989", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<h2>Catalog</h2>
<hr />



<div class=""card"">
    <div class=""card-header"">
        Categories
    </div>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th scope=""col"">CategoryName</th>
                <th style=""width:135px;""></th>
            </tr>
        </thead>
        <tbody id=""categories"">
");
#nullable restore
#line 27 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
             foreach (var item in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th>");
#nullable restore
#line 30 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                   Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <td>");
#nullable restore
#line 31 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                        <button class=\"btn btn-primary btn-sm\">Edit</button>\n                        <button class=\"btn btn-danger btn-sm\">Delete</button>\n                    </td>\n                </tr>\n");
#nullable restore
#line 37 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </tbody>\n    </table>\n    <div class=\"card-footer\">\n        <button class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"#addCategoryModal\">Create</button>\n\n        ");
#nullable restore
#line 44 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
   Write(Html.Partial("_addCategoryForm", new Category()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

            <script>
                $(""#addCategory"").submit(function (event) {

                    event.preventDefault();
                    var form = $(this);

                    var token = $('input[name=""_RequestVerificationToken""]', form).val();

                    var data = { categoryName: $(""#CategoryName"").val() };

                    var dataWithToken = $.extend(data, { '_RequestVerificationToken': token });

                    $ajax({
                        url: form.attr(""action""),
                        type: ""POST"",
                        data: dataWithToken,
                        beforeSend: function () {
                            $(""#ajax-loading"").show();
                        },
                        complete: function () {
                            $(""#ajax-loader"").hide();
                        },
                        success: function (data) {
                            var html = '<tr>< th >' + data.categoryId + '</th><td>' + data.categoryName + '</td><td><b");
                WriteLiteral(@"utton class=""btn btn-primary btn-sm"">Edit</button><button class=""btn btn-danger btn-sm"">Delete</button></td></tr > ';

                            $(""#categories"").append(html);


                            $(""#addCategoryModal"").modal('hide');
                        },
                        error: function () {

                        }
                    });

                });


            </script>

        ");
            }
            );
            WriteLiteral(@"    </div>
</div>

<hr />

<div class=""card"">
    <div class=""card-header"">
        Products
    </div>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th>Image</th>
                <th>ProductName</th>
                <th>IsApproved</th>
                <th>IsHome</th>
                <th>IsFeatured</th>
                <th style=""width:135px;""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 110 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
             foreach (var item in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th>");
#nullable restore
#line 113 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                   Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "90886303c2d8ed818464be9dbe437a2c464971f010975", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3341, "~/images/products/tn/", 3341, 21, true);
#nullable restore
#line 115 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
AddHtmlAttributeValue("", 3362, item.Image, 3362, 11, false);

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
            WriteLiteral("\n                    </td>\n                    <td>");
#nullable restore
#line 117 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n");
#nullable restore
#line 119 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                         if (item.IsAppreoved)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fas fa-check-circle\"></i>\n");
#nullable restore
#line 122 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"far fa-times-circle\"></i>\n");
#nullable restore
#line 126 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                    <td>\n");
#nullable restore
#line 129 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                         if (item.IsHome)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fas fa-check-circle\"></i>\n");
#nullable restore
#line 132 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"far fa-times-circle\"></i>\n");
#nullable restore
#line 136 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 137 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                   Write(item.IsHome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n");
#nullable restore
#line 140 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                         if (item.IsFeatured)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fas fa-check-circle\"></i>\n");
#nullable restore
#line 143 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"far fa-times-circle\"></i>\n");
#nullable restore
#line 147 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                    <td>\n                        <button class=\"btn btn-primary btn-sm\">Edit</button>\n                        <button class=\"btn btn-danger btn-sm\">Delete</button>\n                    </td>\n                </tr>\n");
#nullable restore
#line 154 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </tbody>\n    </table>\n    <div class=\"card-footer\">\n        <button class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"#exampleModal\">Create</button>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CatalogListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591