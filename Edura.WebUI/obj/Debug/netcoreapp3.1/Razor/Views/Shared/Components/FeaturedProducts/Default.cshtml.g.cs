#pragma checksum "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Shared\Components\FeaturedProducts\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cef5c255ed242873ffdde3fb87613ff282fc9bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FeaturedProducts_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FeaturedProducts/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cef5c255ed242873ffdde3fb87613ff282fc9bc", @"/Views/Shared/Components/FeaturedProducts/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe07369f566bae69b76347c3bd591e67ad487862", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FeaturedProducts_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"widget\">\n    <h4>FEATURED</h4>\n\n    <div class=\"products-list\">\n");
#nullable restore
#line 6 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Shared\Components\FeaturedProducts\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"media\">\n                <a class=\"media-left\" href=\"#\">\n                    <img");
            BeginWriteAttribute("alt", " alt=\"", 255, "\"", 261, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive product-thumb\"");
            BeginWriteAttribute("src", " src=\"", 299, "\"", 336, 2);
            WriteAttributeValue("", 305, "/images/products/tn/", 305, 20, true);
#nullable restore
#line 10 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Shared\Components\FeaturedProducts\Default.cshtml"
WriteAttributeValue("", 325, item.Image, 325, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                </a>\n                <div class=\"media-body\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cef5c255ed242873ffdde3fb87613ff282fc9bc5969", async() => {
#nullable restore
#line 13 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Shared\Components\FeaturedProducts\Default.cshtml"
                                                                                                                     Write(item.ProductName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Shared\Components\FeaturedProducts\Default.cshtml"
                                                                       WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <p class=\"product-price\">$");
#nullable restore
#line 14 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Shared\Components\FeaturedProducts\Default.cshtml"
                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n            </div>\n");
#nullable restore
#line 17 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Shared\Components\FeaturedProducts\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </div>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591