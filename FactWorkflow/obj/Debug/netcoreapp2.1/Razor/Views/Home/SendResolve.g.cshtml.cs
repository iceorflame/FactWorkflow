#pragma checksum "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2cf200540d759d7be11eb042c8a67ddfd580810"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SendResolve), @"mvc.1.0.view", @"/Views/Home/SendResolve.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SendResolve.cshtml", typeof(AspNetCore.Views_Home_SendResolve))]
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
#line 1 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\_ViewImports.cshtml"
using FactWorkflow;

#line default
#line hidden
#line 2 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\_ViewImports.cshtml"
using FactWorkflow.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2cf200540d759d7be11eb042c8a67ddfd580810", @"/Views/Home/SendResolve.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"040f4398a80ff197aedbfab3845cd9d5df43dbe9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SendResolve : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FactWorkflow.Models.SendResolve>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ShowFieldsResolve.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tableLanguage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
  
    ViewData["Title"] = "Tokens";
    

#line default
#line hidden
            BeginContext(87, 189, true);
            WriteLiteral("\r\n<div id=\"content-wrapper\">\r\n\r\n    <div class=\"container-fluid\">\r\n\r\n        <!-- Breadcrumbs-->\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                ");
            EndContext();
            BeginContext(276, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f71e6f9bbcf947d4b1059b397e436940", async() => {
                BeginContext(299, 7, true);
                WriteLiteral("Головна");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(310, 940, true);
            WriteLiteral(@"
            </li>
            <li class=""breadcrumb-item active"">Відправити резолюцію</li>
        </ol>
        <div class=""card mb-3"">
            <div class=""card-header"">
                <i class=""fas fa-table""></i>
                Виконавці
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table id=""dataTable"" class=""table table-bordered"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>ПІБ</th>
                                <th>Тип</th>
                                <th>Виконати до</th>
                                <th>Відповідальний</th>
                                <th>Оригінал?</th>
                                <th width=""8%""></th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 36 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                             foreach (var item in Model.Histories)
                            {

#line default
#line hidden
            BeginContext(1349, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1420, 13, false);
#line 39 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                               Write(item.HAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1433, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1477, 15, false);
#line 40 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                               Write(item.Type.TName);

#line default
#line hidden
            EndContext();
            BeginContext(1492, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 41 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                                 if (item.HDate != null)
                                {

#line default
#line hidden
            BeginContext(1592, 55, true);
            WriteLiteral("                                    <td align=\"center\">");
            EndContext();
            BeginContext(1648, 39, false);
#line 43 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                                                  Write(item.HDate.Value.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1687, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 44 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1802, 89, true);
            WriteLiteral("                                    <td align=\"center\"><i class=\"fa fa-times\"></i></td>\r\n");
            EndContext();
#line 48 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                                }

#line default
#line hidden
            BeginContext(1926, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 49 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                                 if (item.HResponsible == true)
                                {

#line default
#line hidden
            BeginContext(2026, 89, true);
            WriteLiteral("                                    <td align=\"center\"><i class=\"fa fa-check\"></i></td>\r\n");
            EndContext();
#line 52 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2223, 89, true);
            WriteLiteral("                                    <td align=\"center\"><i class=\"fa fa-times\"></i></td>\r\n");
            EndContext();
#line 56 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                                }

#line default
#line hidden
            BeginContext(2347, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 57 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                                 if (item.HOriginal == true)
                                {

#line default
#line hidden
            BeginContext(2444, 89, true);
            WriteLiteral("                                    <td align=\"center\"><i class=\"fa fa-check\"></i></td>\r\n");
            EndContext();
#line 60 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2641, 89, true);
            WriteLiteral("                                    <td align=\"center\"><i class=\"fa fa-times\"></i></td>\r\n");
            EndContext();
#line 64 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                                }

#line default
#line hidden
            BeginContext(2765, 567, true);
            WriteLiteral(@"                                <td>
                                    <div class=""btn-group-vertical"">
                                        <div class=""btn-group"">
                                            <button type=""button"" class=""btn btn-link dropdown-toggle"" data-toggle=""dropdown"" style=""text-decoration: none;"">
                                                Керування
                                            </button>
                                            <div class=""dropdown-menu"">
                                                ");
            EndContext();
            BeginContext(3332, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e9801b1c91f4155a2e394cfe3efb477", async() => {
                BeginContext(3399, 8, true);
                WriteLiteral("Видалити");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3363, "~/Home/DeleteHistory?hid=", 3363, 25, true);
#line 72 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
AddHtmlAttributeValue("", 3388, item.Hid, 3388, 9, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3411, 320, true);
            WriteLiteral(@"
                                              <!--  <a class=""dropdown-item"" href="""">Дія 1</a> -->
                                            </div>
                                        </div>
                                    </div>
                                </td>
                            </tr>
");
            EndContext();
#line 79 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                            }

#line default
#line hidden
            BeginContext(3762, 451, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>

        </div>
        <div class=""card mb-3"">
            <div class=""card-header"">
                <i class=""fas fa-table""></i>
                Додати виконавця
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <div class=""col-lg-6"">
                        ");
            EndContext();
            BeginContext(4213, 2557, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8547940518b24919baec601bd24596a2", async() => {
                BeginContext(4275, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(4306, 43, false);
#line 95 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\SendResolve.cshtml"
                       Write(Html.HiddenFor(model => model.Document.DId));

#line default
#line hidden
                EndContext();
                BeginContext(4349, 2414, true);
                WriteLiteral(@"
                            <div class=""form-group"">
                                <div class=""radio"">
                                    <label><input type=""radio"" id=""toObserve"" name=""optradio"" value=""1"" onclick=""showAdditionalFields()"" checked>На ознайомлення</label>
                                </div>
                                <div class=""radio"">
                                    <label><input type=""radio"" id=""toDo"" name=""optradio"" value=""2"" onclick=""showAdditionalFields()"">На виконання</label>
                                </div>
                            </div>
                            <div class=""form-group"" id=""endDate"" hidden=""true"">
                                <label>Кінцева дата виконання</label>
                                <input class=""form-control"" type=""date"" name=""dateSelect"">
                            </div>
                            <div class=""form-group"">
                                <label>Посада/Відділ</label>
                          ");
                WriteLiteral(@"      <select class=""form-control"" id=""roleSelect"" name=""roleSelect"" onchange=""setUsers(this)""></select>
                            </div>
                            <div class=""form-group"">
                                <label>Виконавець/Кафедра</label>
                                <select class=""form-control"" id=""userSelect"" name=""userSelect""></select>
                            </div>
                            <div id=""cathedraUser"" hidden=""true"" name=""cathedraUser"" class=""form-group"">
                                <label>ПІБ</label>
                                <input id=""userName"" name=""userName"" class=""form-control"">
                            </div>
                            <div class=""form-group"">
                                <div class=""checkbox"">
                                    <label><input type=""checkbox"" name=""rOriginal"" value=""true"">Оригінал?</label>
                                </div>
                                <div class=""checkbox"" id=""responsibl");
                WriteLiteral(@"e"" hidden=""true"">
                                    <label><input type=""checkbox"" name=""rResponsible"" value=""true"">Відповідальний за виконання документу</label>
                                </div>
                            </div>
                            <button type=""submit"" class=""btn btn-default"">Додати виконавця</button>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6770, 419, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- /.container-fluid -->
    <!-- Sticky Footer -->
    <footer class=""sticky-footer"">
        <div class=""container my-auto"">
            <div class=""copyright text-center my-auto"">
                <span>Copyright © Your Website 2018</span>
            </div>
        </div>
    </footer>

</div>

");
            EndContext();
            BeginContext(7189, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2c230b581514f298a4b83fd29da3f9f", async() => {
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
            EndContext();
            BeginContext(7240, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(7242, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b5b298128fe49faabdc76e52be409b7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7291, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(7293, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3250abe5943e485882330f07b55ad280", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FactWorkflow.Models.SendResolve> Html { get; private set; }
    }
}
#pragma warning restore 1591
