#pragma checksum "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4116b079ffd5ed57cb6441f4ec5212885e0d8557107ec4b02a2d3ed61c09f2b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4116b079ffd5ed57cb6441f4ec5212885e0d8557107ec4b02a2d3ed61c09f2b1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"31bcc72f41b1a8df57f832077c98fb92d6d57ac8e94da48085ee50eee55c54ec", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("slider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("images"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addToCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("detail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("brand-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<!-- Start Main Area -->\r\n<main>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 103, "\"", 110, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""angleUp"">
        <i class=""fa-solid fa-angles-up""></i>
    </a>
    <section id=""slider-img"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12"">
                    <div class=""swiper mySwiperSl"">
                        <div class=""swiper-wrapper"">
");
#nullable restore
#line 20 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                             foreach (var slider in Model.Sliders)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"swiper-slide\">\r\n\r\n                                    <div class=\"img\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4116b079ffd5ed57cb6441f4ec5212885e0d8557107ec4b02a2d3ed61c09f2b19166", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 716, "~/assets/img/slider/", 716, 20, true);
#nullable restore
#line 25 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 736, slider.Image, 736, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"slider-text\">\r\n                                        <p>");
#nullable restore
#line 28 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                                      Write(slider.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <h1>");
#nullable restore
#line 29 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                                       Write(Html.Raw(slider.Descirption));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1059, "\"", 1066, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Now</a>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 33 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <section id=\"service\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 46 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                 foreach (var service in Model.Services)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-md-6 col-sm-12\">\r\n\r\n                        <div class=\"cards\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4116b079ffd5ed57cb6441f4ec5212885e0d8557107ec4b02a2d3ed61c09f2b112759", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1656, "~/assets/img/service/", 1656, 21, true);
#nullable restore
#line 51 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1677, service.Image, 1677, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <h3>");
#nullable restore
#line 52 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                           Write(service.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 53 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                          Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 56 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <section id=\"feature-part\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 67 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                 foreach (var feature in Model.Features)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-12 col-sm-12\">\r\n                        <div class=\"card mb-2\">\r\n                            <div class=\"img\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4116b079ffd5ed57cb6441f4ec5212885e0d8557107ec4b02a2d3ed61c09f2b115931", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2331, "~/assets/img/product/", 2331, 21, true);
#nullable restore
#line 72 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2352, feature.Image, 2352, 14, false);

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
            WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"text\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4116b079ffd5ed57cb6441f4ec5212885e0d8557107ec4b02a2d3ed61c09f2b117675", async() => {
                WriteLiteral("Buy Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 80 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </section>


    <section id=""slider-product-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""title-ourPr"">
                        <h3>Our Product</h3>
                    </div>
                </div>
                <div class=""swiper mySwiper1"">
                    <div class=""swiper-wrapper"">
");
#nullable restore
#line 97 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                         foreach (var product in Model.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"swiper-slide\">\r\n                                <div class=\"card-pr\"");
            BeginWriteAttribute("cart-id", " cart-id=\"", 3317, "\"", 3338, 1);
#nullable restore
#line 100 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 3327, product.Id, 3327, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <input type=\"hidden\" class=\"product-id\"");
            BeginWriteAttribute("value", " value=\"", 3417, "\"", 3436, 1);
#nullable restore
#line 101 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 3425, product.Id, 3425, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <div class=\"imagesBx\">\r\n\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4116b079ffd5ed57cb6441f4ec5212885e0d8557107ec4b02a2d3ed61c09f2b121221", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3554, "~/assets/img/product/", 3554, 21, true);
#nullable restore
#line 104 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3575, product.ProductImages.FirstOrDefault(m => m.IsMain)?.Image, 3575, 59, false);

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
            WriteLiteral(@"

                                        <ul class=""icon-shop"">
                                            <li>
                                                <i class=""fa fa-heart wishList""></i>
                                                <span>Add to WishList</span>
                                            </li>
");
#nullable restore
#line 111 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                                             if (User.Identity.IsAuthenticated)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li>\r\n                                                    <a");
            BeginWriteAttribute("cart-id", " cart-id=\"", 4218, "\"", 4239, 1);
#nullable restore
#line 114 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 4228, product.Id, 4228, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"addToCart\"><i class=\"fa-sharp fa-solid fa-bag-shopping\"></i></a>\r\n                                                    <span>Add to Cart</span>\r\n\r\n                                                </li>\r\n");
#nullable restore
#line 118 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li>\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4116b079ffd5ed57cb6441f4ec5212885e0d8557107ec4b02a2d3ed61c09f2b124724", async() => {
                WriteLiteral("<i class=\"fa-sharp fa-solid fa-bag-shopping\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "cart-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 122 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4752, product.Id, 4752, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    <span>Add to Cart</span>\r\n\r\n                                                </li>\r\n");
#nullable restore
#line 126 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4116b079ffd5ed57cb6441f4ec5212885e0d8557107ec4b02a2d3ed61c09f2b127162", async() => {
                WriteLiteral(@"
                                            <li>
                                                <i class=""fa fa-eye""></i>
                                                <span>View Details</span>
                                            </li>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 129 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                                                                                                                  WriteLiteral(product.Id);

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
            WriteLiteral("\r\n\r\n                                        </ul>\r\n                                    </div>\r\n\r\n                                    <div class=\"productName\">\r\n                                        <h4>");
#nullable restore
#line 140 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                                       Write(product.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 5733, "\"", 5740, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 141 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                                              Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </div>\r\n                                    <div class=\"price\">\r\n                                        <span>");
#nullable restore
#line 144 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                                          Write((product.Price-((product.Price*product.DiscountPrice)/100)).ToString("##.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("₼</span>\r\n                                        <span><del>");
#nullable restore
#line 145 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                                              Write(product.Price.ToString("##.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("₼</del></span>\r\n                                    </div>\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 150 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </section>\r\n\r\n\r\n\r\n    ");
#nullable restore
#line 163 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("InstagramPhoto"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <section id=\"brand-area\">\r\n        <div class=\"container\">\r\n            <h3>OUR BRANDS</h3>\r\n            <div class=\"swiper mySwiperbrand\">\r\n                <div class=\"swiper-wrapper\">\r\n");
#nullable restore
#line 171 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                     foreach (var barnd in Model.Brands)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"swiper-slide\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4116b079ffd5ed57cb6441f4ec5212885e0d8557107ec4b02a2d3ed61c09f2b133204", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6782, "~/assets/img/brand/", 6782, 19, true);
#nullable restore
#line 174 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6801, barnd.Image, 6801, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 176 "C:\Users\User\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n\r\n</main>\r\n<!-- end Main Area -->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
