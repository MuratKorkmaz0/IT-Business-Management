#pragma checksum "/Users/bdgstudio/Projects/ITBusinessManagement/ITBusinessManagement/Views/Home/Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fac15493f57f6d99996fbbb112865e4600c96d38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Settings), @"mvc.1.0.view", @"/Views/Home/Settings.cshtml")]
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
#line 1 "/Users/bdgstudio/Projects/ITBusinessManagement/ITBusinessManagement/Views/_ViewImports.cshtml"
using ITBusinessManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/bdgstudio/Projects/ITBusinessManagement/ITBusinessManagement/Views/_ViewImports.cshtml"
using ITBusinessManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac15493f57f6d99996fbbb112865e4600c96d38", @"/Views/Home/Settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970bd9db7c3d94456f8c7768878a3074affe5e26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Settings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Chris Wood"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/DefaultUser-128.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle img-responsive mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("128"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("128"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!-- * IT Business Management v1.0.0
  * Copyright 2019-2021 The MSOFTWARE (https://www.msoftware.com/)
  * Licensed (https://www.msoftware.com/) -->


<div class=""container-fluid mt-0"">
    <div class=""card mb-4 wow fadeIn bg-m-0"">

        <!--Page Title/Button Bar-->
        <div class=""card-body d-sm-flex justify-content-between"">

            <h4 class=""mb-2 mb-sm-0 pt-1"">
                <a>Profili D??zenle</a>
            </h4>

        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-3 col-xl-2"">

        <div class=""card-d"">
            <div class=""card-header"">
                <h5 class=""card-title mb-0"">Profil Ayarlar??</h5>
            </div>

            <div class=""list-group list-group-flush"" role=""tablist"">
                <a class=""list-group-item list-group-item-action active"" data-bs-toggle=""list"" href=""#account"" role=""tab"" aria-selected=""true"">
                    Hesap
                </a>
                <a class=""list-group-item list-group-item-action data-bs-toggle"" dat");
            WriteLiteral(@"a-bs-toggle=""list"" href=""#password"" role=""tab"" aria-selected=""false"">
                    Parola
                </a>
                <a class=""list-group-item list-group-item-action"" data-bs-toggle=""list"" href=""#"" role=""tab"" aria-selected=""false"">
                    Gizlilik ve g??venlik
                </a>
            </div>
        </div>
    </div>

    <div class=""col-md-9 col-xl-10"">
        <div class=""tab-content"">
            <div class=""tab-pane fade active show"" id=""account"" role=""tabpanel"">

                <div class=""card-d"">
                    <div class=""card-header"">
                       
                        <h5 class=""card-title mb-0"">Ki??isel Bilgiler</h5>
                    </div>
                    <div class=""card-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fac15493f57f6d99996fbbb112865e4600c96d387065", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-8"">
                                    <div class=""mb-3"">
                                        <label for=""inputUsername"" class=""form-label"">Kullan??c?? Ad??</label>
                                        <input type=""text"" class=""form-control"" id=""inputUsername"" placeholder=""Kullan??c?? ad??n??z"">
                                    </div>
                                    <div class=""mb-3"">
                                        <label for=""inputUsername"" class=""form-label"">Hakk??nda</label>
                                        <textarea rows=""2"" class=""form-control"" id=""inputBio"" placeholder=""Kendin hakk??nda bir ??eyler s??yle..""></textarea>
                                    </div>
                                </div>
                                <div class=""col-md-4"">
                                    <div class=""text-center"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fac15493f57f6d99996fbbb112865e4600c96d388345", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        <div class=""mt-2"">
                                            <span class=""ist-group-item active waves-effect btn-primary btn-sm""><i class=""fas fa-upload""></i> Upload</span>
                                        </div>
                                        <small>En iyi sonu??lar i??in, .jpg bi??iminde en az 128 piksele 128 piksellik bir resim kullan??n</small>
                                    </div>
                                </div>
                            </div>

                            <button type=""submit"" class=""ist-group-item active waves-effect btn-primary btn-sm"">Kaydet</button>
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
                </div><br />

                <div class=""card-d"">
                    <div class=""card-header"">
                        <h5 class=""card-title mb-0"">Ki??isel Bilgiler</h5>
                    </div>
                    <div class=""card-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fac15493f57f6d99996fbbb112865e4600c96d3811720", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""mb-3 col-md-6"">
                                    <label for=""inputFirstName"" class=""form-label"">Ad</label>
                                    <input type=""text"" class=""form-control"" id=""Ad??n??z"" placeholder=""ad??n??z"">
                                </div>
                                <div class=""mb-3 col-md-6"">
                                    <label for=""inputLastName"" class=""form-label"">Soyad</label>
                                    <input type=""text"" class=""form-control"" id=""Soyad??n??z"" placeholder=""soyad??n??z"">
                                </div>
                            </div>
                            <div class=""mb-3"">
                                <label for=""inputEmail4"" class=""form-label"">Email</label>
                                <input type=""email"" class=""form-control"" id=""inputEmail4"" placeholder=""Email"">
                            </div>
                            
                ");
                WriteLiteral(@"            <div class=""row"">
                                <div class=""mb-3 col-md-6"">
                                    <label for=""inputCity"" class=""form-label"">??ehir</label>
                                    <input type=""text"" class=""form-control"" id=""inputCity"">
                                </div>
                                <div class=""mb-3 col-md-2"">
                                    <label for=""inputZip"" class=""form-label"">Zip</label>
                                    <input type=""text"" class=""form-control"" id=""inputZip"">
                                </div>
                            </div>
                            <button type=""submit"" class=""ist-group-item active waves-effect btn-primary btn-sm"">Kaydet</button>
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
                </div><br />

            </div>
            <div class=""tab-pane fade"" id=""password"" role=""tabpanel"">
                <div class=""card-d"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Parola</h5>

                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fac15493f57f6d99996fbbb112865e4600c96d3815167", async() => {
                WriteLiteral(@"
                            <div class=""mb-3"">
                                <label for=""inputPasswordCurrent"" class=""form-label"">Mevcut Parola</label>
                                <input type=""password"" class=""form-control"" id=""inputPasswordCurrent"">
                                <small><a href=""#"">Parolan??z?? m?? unuttunuz?</a></small>
                            </div>
                            <div class=""mb-3"">
                                <label for=""inputPasswordNew"" class=""form-label"">Yeni Parola</label>
                                <input type=""password"" class=""form-control"" id=""inputPasswordNew"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""inputPasswordNew2"" class=""form-label"">Parolay?? Onayla</label>
                                <input type=""password"" class=""form-control"" id=""inputPasswordNew2"">
                            </div>
                            <button type=""submit"" class=""ist-group-item a");
                WriteLiteral("ctive waves-effect btn-primary btn-sm\">Kaydet</button>\n                        ");
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
            WriteLiteral("\n\n                    </div>\n                </div>\n            </div><br />\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
