#pragma checksum "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e104e156eb3d8c63dd23e76322e62656e951759a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e104e156eb3d8c63dd23e76322e62656e951759a", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe07369f566bae69b76347c3bd591e67ad487862", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Edura.Entity.Models.ProductDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""content"">

    <!-- shop section start -->
    <section id=""shop"" class=""container"">

        <!-- row start -->
        <div class=""row"">

            <!-- sidebar start -->
            <div id=""sidebar"" class=""col-md-3"">

                <!-- search widget start -->
                <div class=""widget"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e104e156eb3d8c63dd23e76322e62656e951759a6503", async() => {
                WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control input-lg"" placeholder=""Search..."">
                            <span class=""input-group-btn"">
                                <button class=""btn btn-default btn-lg"" type=""submit""><i class=""fa fa-search""></i></button>
                            </span>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                <!-- search widget end -->\n                <!-- categories widget start -->\n                ");
#nullable restore
#line 30 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
           Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <!-- categories widget end -->\n                <!-- featured products widget start -->\n                ");
#nullable restore
#line 33 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
           Write(await Component.InvokeAsync("FeaturedProducts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <!-- featured products widget end -->

            </div>
            <!-- sidebar end -->
            <!-- main column start -->
            <div class=""col-md-9"">

                <div class=""row"">


                    <!-- product page top info start -->
                    <div class=""col-md-12 product"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div id=""product-gallery"" class=""owl-carousel owl-theme"" style=""opacity: 1; display: block;"">
");
#nullable restore
#line 49 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                     foreach (var item in Model.ProductImages)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"item\">\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e104e156eb3d8c63dd23e76322e62656e951759a10017", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2033, "~/images/products/tn/", 2033, 21, true);
#nullable restore
#line 52 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 2054, item.ImageName, 2054, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </div>\n");
#nullable restore
#line 54 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </div>\n                            </div>\n\n                            <div class=\"col-md-6\">\n\n                                <div class=\"padding15\">\n                                    <h2 class=\"product-title\"><b>");
#nullable restore
#line 62 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                                            Write(Model.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h2>
                                    <p>
                                        <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                        3 Reviews
                                    </p>
                                    <p class=""product-price"">$");
#nullable restore
#line 67 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                                         Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                </div>\n                                <p>");
#nullable restore
#line 69 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                              Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n\n\n                                <div class=\"padding15\">\n\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e104e156eb3d8c63dd23e76322e62656e951759a13642", async() => {
                WriteLiteral("\n\n                                        <input type=\"hidden\" name=\"ProductId\"");
                BeginWriteAttribute("value", " value=\"", 3198, "\"", 3230, 1);
#nullable restore
#line 77 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
WriteAttributeValue("", 3206, Model.Product.ProductId, 3206, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                        <div class=""form-group qty"">
                                            <div class=""input-group"">
                                                <span class=""input-group-addon"">Qty</span>
                                                <input type=""number"" size=""4"" name=""quantity"" class=""form-control"" value=""1"" min=""1"" step=""1"">
                                            </div>
                                        </div>
                                        <button type=""submit"" class=""btn btn-primary""><i class=""fa fa-cart-plus fa-fw""></i>Sebete Ekle</button>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                                </div>\n\n                                <p>\n                                    <b>Category:</b>\n");
#nullable restore
#line 91 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                     foreach (var item in Model.Categories)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a href=\"#\">");
#nullable restore
#line 93 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 94 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </p>

                            </div>
                        </div>
                    </div>
                    <!-- product page top info end -->
                    <!-- product page middle info start -->
                    <div class=""col-md-12 padding25"">


                        <ul class=""nav nav-tabs"">
                            <li class=""active""><a data-toggle=""tab"" href=""#description"">Description</a></li>
                            <li><a data-toggle=""tab"" href=""#spec"">Specifications</a></li>
                            <li><a data-toggle=""tab"" href=""#reviews"">Reviews (3)</a></li>
                        </ul>


                        <div class=""tab-content"">

                            <!-- description tab start -->
                            <div id=""description"" class=""tab-pane fade in active"">
                                ");
#nullable restore
#line 116 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                           Write(Html.Raw(Model.Product.HtmlContent));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <!-- description tab end -->
                            <!-- Specifications tab start -->
                            <div id=""spec"" class=""tab-pane fade"">
                                <div class=""table-responsive"">
                                    <table class=""table table-striped table-hover"">
                                        <tbody>
");
#nullable restore
#line 124 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                             foreach (var item in Model.ProductAttributes)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\n                                                    <td><b>");
#nullable restore
#line 127 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                                      Write(item.Attribute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\n                                                    <td>");
#nullable restore
#line 128 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                                   Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                </tr>\n");
#nullable restore
#line 130 "C:\Users\talib\OneDrive\Desktop\Edura\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <!-- Specifications tab end -->
                            <!-- reviews tab start -->
                            <div id=""reviews"" class=""tab-pane fade"">

                                <div class=""reviews-list"">

                                    <div class=""media"">

                                        <a class=""media-left"" href=""#"">
                                            <img");
            BeginWriteAttribute("alt", " alt=\"", 6639, "\"", 6645, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle avatar"" src=""images/team/thumb8_40.jpg"">
                                        </a>
                                        <div class=""media-body"">
                                            <p class=""pull-right""><small><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i></small></p>
                                            <h4 class=""media-heading"">John Doe <small>2 days ago</small></h4>
                                            At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.
                                        </div>
                                    </div>

                                    <div class=""media"">

                                        ");
            WriteLiteral("<a class=\"media-left\" href=\"#\">\n                                            <img");
            BeginWriteAttribute("alt", " alt=\"", 7750, "\"", 7756, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle avatar"" src=""images/team/thumb5_40.jpg"">
                                        </a>
                                        <div class=""media-body"">
                                            <p class=""pull-right""><small><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i></small></p>
                                            <h4 class=""media-heading"">Sarah Smith<small>4 days ago</small></h4>
                                            Nunc risus ex, tempus quis purus ac, tempor consequat ex. Vivamus sem magna, maximus at est id, maximus aliquet nunc. Suspendisse lacinia velit a eros porttitor, in interdum ante faucibus.
                                        </div>
                                    </div>

                                    <div class=""media"">

                                        <a class=""media-left"" href=""#"">
                                            <img");
            BeginWriteAttribute("alt", " alt=\"", 8756, "\"", 8762, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle avatar"" src=""images/team/thumb3_40.jpg"">
                                        </a>
                                        <div class=""media-body"">
                                            <p class=""pull-right""><small><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i></small></p>
                                            <h4 class=""media-heading"">Jane Doe<small>5 days ago</small></h4>
                                            Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae.
                                        </div>
                                    </div>

                                </div>

                                <div class=""page-header"">
                                    <h4>ADD A <b>REVIEW</b></h4>
                                </div>

                                <p cla");
            WriteLiteral("ss=\"text-muted\">You must be logged in to add a review.</p>\n\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e104e156eb3d8c63dd23e76322e62656e951759a25093", async() => {
                WriteLiteral("\n                                    <div class=\"row\">\n                                        <div class=\"form-group col-xs-6\">\n                                            <input type=\"text\" class=\"form-control input-lg\" placeholder=\"Name*\"");
                BeginWriteAttribute("required", " required=\"", 10126, "\"", 10137, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                                        </div>\n                                        <div class=\"form-group col-xs-6\">\n                                            <input type=\"email\" class=\"form-control input-lg\" placeholder=\"Email*\"");
                BeginWriteAttribute("required", " required=\"", 10375, "\"", 10386, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                                        </div>\n\n                                        <div class=\"form-group col-xs-12\">\n                                            <textarea class=\"form-control\" rows=\"6\" placeholder=\"Review*\"");
                BeginWriteAttribute("required", " required=\"", 10617, "\"", 10628, 0);
                EndWriteAttribute();
                WriteLiteral(@"></textarea>
                                        </div>

                                        <div class=""form-group col-xs-12 text-right"">
                                            <button type=""submit"" class=""btn btn-primary""><i class=""fa fa-check fa-fw""></i> SUBMIT REVIEW</button>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                            </div>
                            <!-- reviews tab end -->

                        </div>

                    </div>

                </div>
                <!-- row end -->

            </div>
            <!-- main column end -->

        </div>
        <!-- row end -->

    </section>
    <!-- shop section end -->

</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Edura.Entity.Models.ProductDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591