#pragma checksum "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "351c37ffb194b85e2fbf92a435aff559548cf1f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DocumentTable), @"mvc.1.0.view", @"/Views/Home/DocumentTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DocumentTable.cshtml", typeof(AspNetCore.Views_Home_DocumentTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"351c37ffb194b85e2fbf92a435aff559548cf1f8", @"/Views/Home/DocumentTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"040f4398a80ff197aedbfab3845cd9d5df43dbe9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DocumentTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FactWorkflow.Models.History>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tableLanguage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
  
    ViewData["Title"] = "Users";
    

#line default
#line hidden
#line 4 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
    var hidden = false;
    

#line default
#line hidden
#line 5 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
     if (User.IsInRole("office") || User.IsInRole("rector"))
    {
        hidden = true;
    }

#line default
#line hidden
            BeginContext(220, 189, true);
            WriteLiteral("\r\n<div id=\"content-wrapper\">\r\n\r\n    <div class=\"container-fluid\">\r\n\r\n        <!-- Breadcrumbs-->\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                ");
            EndContext();
            BeginContext(409, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9326c24e565c489690266f343c2c1133", async() => {
                BeginContext(432, 7, true);
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
            BeginContext(443, 1213, true);
            WriteLiteral(@"
            </li>
            <li class=""breadcrumb-item active"">Документи</li>
        </ol>

        <!-- DataTables Example -->
        <div class=""card mb-3"">
            <div class=""card-header"">
                <i class=""fas fa-table""></i>
                Список документів
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>№</th>
                                <th>Індекс</th>
                                <th>Дата</th>
                                <th>Кореспондент</th>
                                <th>Зміст</th>
                                <th>Тип</th>
                                <th>Адресат</th>
                                <th>Статус</th>
                                <th>Виконати до</th>
                 ");
            WriteLiteral("               <th>Відповідальний</th>\r\n                                <th>Оригінал?</th>\r\n                                <th>Документ</th>\r\n                                <th width=\"8%\"");
            EndContext();
            BeginWriteAttribute("hidden", " hidden=", 1656, "", 1671, 1);
#line 46 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
WriteAttributeValue("", 1664, hidden, 1664, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1671, 110, true);
            WriteLiteral("></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 50 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1870, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1949, 8, false);
#line 53 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                   Write(item.DId);

#line default
#line hidden
            EndContext();
            BeginContext(1957, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2005, 20, false);
#line 54 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                   Write(item.Document.DIndex);

#line default
#line hidden
            EndContext();
            BeginContext(2025, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2073, 42, false);
#line 55 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                   Write(item.Document.DDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2115, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2163, 19, false);
#line 56 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                   Write(item.Document.DFrom);

#line default
#line hidden
            EndContext();
            BeginContext(2182, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2230, 20, false);
#line 57 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                   Write(item.Document.DAbout);

#line default
#line hidden
            EndContext();
            BeginContext(2250, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2298, 15, false);
#line 58 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                   Write(item.Type.TName);

#line default
#line hidden
            EndContext();
            BeginContext(2313, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2361, 13, false);
#line 59 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                   Write(item.HAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2374, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2422, 17, false);
#line 60 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                   Write(item.Status.SName);

#line default
#line hidden
            EndContext();
            BeginContext(2439, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 61 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                     if (item.HDate != null)
                                    {

#line default
#line hidden
            BeginContext(2547, 59, true);
            WriteLiteral("                                        <td align=\"center\">");
            EndContext();
            BeginContext(2607, 39, false);
#line 63 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                                      Write(item.HDate.Value.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2646, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 64 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2773, 93, true);
            WriteLiteral("                                        <td align=\"center\"><i class=\"fa fa-times\"></i></td>\r\n");
            EndContext();
#line 68 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2905, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 69 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                     if (item.HResponsible == true)
                                    {

#line default
#line hidden
            BeginContext(3013, 93, true);
            WriteLiteral("                                        <td align=\"center\"><i class=\"fa fa-check\"></i></td>\r\n");
            EndContext();
#line 72 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3226, 93, true);
            WriteLiteral("                                        <td align=\"center\"><i class=\"fa fa-times\"></i></td>\r\n");
            EndContext();
#line 76 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3358, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 77 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                     if (item.HOriginal == true)
                                    {

#line default
#line hidden
            BeginContext(3463, 93, true);
            WriteLiteral("                                        <td align=\"center\"><i class=\"fa fa-check\"></i></td>\r\n");
            EndContext();
#line 80 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3676, 93, true);
            WriteLiteral("                                        <td align=\"center\"><i class=\"fa fa-times\"></i></td>\r\n");
            EndContext();
#line 84 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3808, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(3848, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9eea109539841f58e45f187b5adc095", async() => {
                BeginContext(3894, 54, false);
#line 85 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                                                                Write(Html.DisplayFor(modelItem => item.Document.File.FName));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3857, "~/Home/Download/", 3857, 16, true);
#line 85 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
AddHtmlAttributeValue("", 3873, item.Document.FId, 3873, 18, false);

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
            BeginContext(3952, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 86 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                     if (item.SId == 7)
                                    {

#line default
#line hidden
            BeginContext(4055, 43, true);
            WriteLiteral("                                        <td");
            EndContext();
            BeginWriteAttribute("hidden", " hidden=", 4098, "", 4113, 1);
#line 88 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
WriteAttributeValue("", 4106, hidden, 4106, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4113, 588, true);
            WriteLiteral(@">
                                            <div class=""btn-group-vertical"">
                                                <div class=""btn-group"">
                                                    <button type=""button"" class=""btn btn-link dropdown-toggle"" data-toggle=""dropdown"" style=""text-decoration: none;"">
                                                        Керування
                                                    </button>
                                                    <div class=""dropdown-menu"">
                                                        ");
            EndContext();
            BeginContext(4701, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "464758ca36444005ab13f8b156060ea8", async() => {
                BeginContext(4764, 21, true);
                WriteLiteral("Підтвердити виконання");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4732, "~/Home/ApplyWork?did=", 4732, 21, true);
#line 95 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
AddHtmlAttributeValue("", 4753, item.DId, 4753, 9, false);

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
            BeginContext(4789, 327, true);
            WriteLiteral(@"
                                                        <!--  <a class=""dropdown-item"" href="""">Дія 1</a> -->
                                                    </div>
                                                </div>
                                            </div>
                                        </td>
");
            EndContext();
#line 101 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(5236, 43, true);
            WriteLiteral("                                        <td");
            EndContext();
            BeginWriteAttribute("hidden", " hidden=", 5279, "", 5294, 1);
#line 104 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
WriteAttributeValue("", 5287, hidden, 5287, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5294, 8, true);
            WriteLiteral("></td>\r\n");
            EndContext();
#line 105 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5341, 39, true);
            WriteLiteral("                                </tr>\r\n");
            EndContext();
#line 107 "C:\Users\vduc\Documents\GitHub\FactWorkflow\FactWorkflow\Views\Home\DocumentTable.cshtml"
                            }

#line default
#line hidden
            BeginContext(5411, 451, true);
            WriteLiteral(@"                        </tbody>
                    </table>
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

    ");
            EndContext();
            BeginContext(5862, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c704bedc20e41d2a9e8d411c0fe09ca", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5913, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(5919, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "079876f858e7414b9274b83e8b6ed750", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5964, 38, true);
            WriteLiteral("\r\n\r\n</div>\r\n<!-- /.content-wrapper -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FactWorkflow.Models.History>> Html { get; private set; }
    }
}
#pragma warning restore 1591
