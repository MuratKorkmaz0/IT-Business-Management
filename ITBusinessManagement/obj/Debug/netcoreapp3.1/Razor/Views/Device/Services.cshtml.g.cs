#pragma checksum "/Users/bdgstudio/Projects/ITBusinessManagement/ITBusinessManagement/Views/Device/Services.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e87384f3efc6b7bb03a2f2d769566569e14139b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Device_Services), @"mvc.1.0.view", @"/Views/Device/Services.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e87384f3efc6b7bb03a2f2d769566569e14139b7", @"/Views/Device/Services.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970bd9db7c3d94456f8c7768878a3074affe5e26", @"/Views/_ViewImports.cshtml")]
    public class Views_Device_Services : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-sm-inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Device", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Personal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item active waves-effect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/computerPage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid mt-0"">

    <div class=""card mb-4 wow fadeIn"">

        <!--Card content-->
        <div class=""card-body d-sm-flex justify-content-between bg-m-0"">
            <!--Title-->
            <h4 class=""mb-2 mb-sm-0 pt-1"">
                <a");
            BeginWriteAttribute("href", " href=\"", 263, "\"", 270, 0);
            EndWriteAttribute();
            WriteLiteral(">Bilgisayarlar</a>\n            </h4>\n            <!--Title-->\n            <!--Search-->\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87384f3efc6b7bb03a2f2d769566569e14139b76074", async() => {
                WriteLiteral(@"
                <div class=""input-group input-group-navbar"">
                    <input type=""text"" class=""form-control"" placeholder=""Ara…"" aria-label=""Search"">
                    <button class=""btn"" type=""button"" style=""background-color: #1659c7"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" style=""color:white"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-search align-middle"">
                        <circle  cx=""11"" cy=""11"" r=""8""></circle>
                        <line x1=""21"" y1=""21"" x2=""16.65"" y2=""16.65""></line></svg>
                    </button>
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
            WriteLiteral(@"
            <!--Search-->
        </div>
        <!--Card content-->
    </div>

    <div class=""card mb-4 wow fadeIn bg-m"">
        <!--Page Title/Button Bar-->
        <div class=""card-body d-sm-flex justify-content-between"">

            <div class=""tab-pane active"">


                <div class=""form-group"">
                    <div class=""col-xs-6"">
                        <!--Top bar-->
                        <table>

                            <thead>
                                <tr>
                                    <td>
                                        <h5><label for=""Marka"" style=""color:white"">Marka:</label></h5>
                                        <input type=""text"" class=""form-control"" name=""Marka"" id=""Brand"" placeholder=""Marka"" title=""Marka Girin."">
                                    </td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td>
          ");
            WriteLiteral(@"                              <h5><label for=""Model"" style=""color:white"">Model:</label></h5>
                                        <input type=""text"" class=""form-control"" name=""Model"" id=""Model"" placeholder=""Model"" size=""60"" title=""Model Girin."">
                                    </td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td>
                                        <h5><label for=""Açıklama"" style=""color:white"">Açıklama:</label></h5>
                                        <input type=""text"" class=""form-control"" name=""Açıklama"" id=""explanation"" placeholder=""Açıklama"" size=""75"" title=""Açıklama Girin."">
                                    </td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td>
                                        <h5><label fo");
            WriteLiteral(@"r=""Tarih"" style=""color:white"">Tarih:</label></h5>
                                        <input type=""datetime-local"" class=""form-control"" name=""Tarih"" id=""DataTime"" placeholder=""Tarih"" title=""Tarih Girin."">
                                    </td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </thead>
                        </table>
                        <!--Top bar-->
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!--Card-->
<div class=""card flex-fill"">
    <div class=""card-header""></div>

    <div id=""datatables-dashboard-projects_wrapper"" class=""dataTables_wrapper dt-bootstrap4 no-footer"">
        <div class=""row"">
            <div class=""col-sm-12 col-md-6"">
            </div>
            <div class=""col-sm-12 col-md-6"">
            </div>
        </div>
        <div class=""row"">
            <div class=""col-sm-12"">

                <");
            WriteLiteral(@"!--Table-->
                <table id=""datatables-dashboard-projects"" class=""table table-striped my-0 dataTable no-footer"" role=""grid"" aria-describedby=""datatables-dashboard-projects_info"">
                    <thead>
                        <!--Table Cell Header-->
                        <tr role=""row"">
                            <th class=""sorting sorting_asc"" tabindex=""0"" aria-controls=""datatables-dashboard-projects"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Name: activate to sort column descending"">Marka</th>

                            <th class=""d-none d-xl-table-cell sorting"" tabindex=""0"" aria-controls=""datatables-dashboard-projects"" rowspan=""1"" colspan=""1"" aria-label=""End Date: activate to sort column ascending"">Model</th>

                            <th class=""sorting"" tabindex=""0"" aria-controls=""datatables-dashboard-projects"" rowspan=""1"" colspan=""1"" aria-label=""Status: activate to sort column ascending"">Açıklama</th>

                            <th class=""d-none d-md-table-cell ");
            WriteLiteral(@"sorting"" tabindex=""0"" aria-controls=""datatables-dashboard-projects"" rowspan=""1"" colspan=""1"" aria-label=""Assignee: activate to sort column ascending"">Tarih</th>
                        </tr>
                        <!--Table Cell Header-->
                    </thead>

                    <!--Table body-->
                    <tbody>

                        <tr class=""odd"">
                            <td>Cell</td>
                            <td>Cell</td>
                            <td>Cell</td>
                            <td>Cell</td>
                        </tr>
                        <tr class=""even"">
                            <td>Cell</td>
                            <td>Cell</td>
                            <td>Cell</td>
                            <td>Cell</td>
                        </tr>
                        <tr class=""odd"">
                            <td>Cell</td>
                            <td>Cell</td>
                            <td>Cell</td>
                            <td>Cell</td>
");
            WriteLiteral(@"                        </tr>
                        <tr class=""even"">
                            <td>Cell</td>
                            <td>Cell</td>
                            <td>Cell</td>
                            <td>Cell</td>
                        </tr>
                        <tr class=""odd"">
                            <td>Cell</td>
                            <td>Cell</td>
                            <td>Cell</td>
                            <td>Cell</td>
                        </tr>
                        <tr class=""even"">
                            <td>Cell</td>
                            <td>Cell</td>
                            <td>Cell</td>
                            <td>Cell</td>
                        </tr>
                    </tbody>
                    <!--Table body-->
                </table>
                <!--Table-->
            </div>
        </div>
        <!--Table page-->
        <div class=""row"">
            <div class=""col-sm-12 col-md-5"">
                <div cl");
            WriteLiteral(@"ass=""dataTables_info"" id=""stockDatatablesInfo"" role=""status"" aria-live=""polite"">6 kayıttan 1-6 arası gösteriliyor</div>
            </div>
            <div class=""col-sm-12 col-md-7"">
                <div class=""dataTables_paginate paging_simple_numbers"" id=""datatables-dashboard-projects_paginate"">
                    <ul class=""pagination"">
                        <li class=""paginate_button page-item previous disabled"" id=""datatables-dashboard-projects_previous"">
                            <a href=""#"" aria-controls=""datatables-dashboard-projects"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">önceki</a>
                        </li>
                        <li class=""paginate_button page-item active"">
                            <a href=""#"" aria-controls=""datatables-dashboard-projects"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a>
                        </li>
                        <li class=""paginate_button page-item "">
                            <a href=""#"" aria-controls=""datatables-dashboard-pr");
            WriteLiteral(@"ojects"" data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a>
                        </li>
                        <li class=""paginate_button page-item previous disabled"" id=""datatables-dashboard-projects_previous"">
                            <a href=""#"" aria-controls=""datatables-dashboard-projects"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">sonraki</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!--Table page-->
    </div>
</div>
<!--Card-->
<br />
<!--Bottom bar-->
<div class=""card mb-4 wow fadeIn"">
    <table>
        <thead>
            <tr>
                <td>
                    <!--Buttons-->
                    <div class=""lt-gist-group lisroup-flush"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87384f3efc6b7bb03a2f2d769566569e14139b716556", async() => {
                WriteLiteral("\n                            <i class=\"fa fa-pie-chart mr-3\">Ekle</i>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </td>\n                <td>\n                    <div class=\"lt-gist-group lisroup-flush\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87384f3efc6b7bb03a2f2d769566569e14139b718316", async() => {
                WriteLiteral("\n                            <i class=\"fa fa-pie-chart mr-3\">Sil</i>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </td>\n                <td>\n                    <div class=\"lt-gist-group lisroup-flush\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87384f3efc6b7bb03a2f2d769566569e14139b720075", async() => {
                WriteLiteral("\n                            <i class=\"fa fa-pie-chart mr-3\">Güncelle</i>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <!--Buttons-->
                </td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
   ");
            WriteLiteral("             <td></td>\n                <td></td>\n                <td></td>\n                <td></td>\n\n            </tr>\n        </thead>\n    </table>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87384f3efc6b7bb03a2f2d769566569e14139b722892", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n<!--Bottom bar-->");
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
