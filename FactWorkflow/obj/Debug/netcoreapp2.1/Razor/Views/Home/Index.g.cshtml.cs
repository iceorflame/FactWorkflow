#pragma checksum "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5babb18a78b6587fd1234c2ac56a0a070db21a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\_ViewImports.cshtml"
using FactWorkflow;

#line default
#line hidden
#line 2 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\_ViewImports.cshtml"
using FactWorkflow.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5babb18a78b6587fd1234c2ac56a0a070db21a5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f566decc4ae3945f4f7812ea3607228cedc3698f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FactWorkflow.Models.History>>
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
#line 1 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Users";
    

#line default
#line hidden
            BeginContext(95, 189, true);
            WriteLiteral("\r\n<div id=\"content-wrapper\">\r\n\r\n    <div class=\"container-fluid\">\r\n\r\n        <!-- Breadcrumbs-->\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                ");
            EndContext();
            BeginContext(284, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93d090f3d6df47dc865888d64df24f94", async() => {
                BeginContext(307, 7, true);
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
            BeginContext(318, 1686, true);
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
                                <th>Статус</th>
                                <th>Адресат</th>
                                <th>Документ</th>
                                <th></th>
                       ");
            WriteLiteral(@"     </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>№</th>
                                <th>Індекс</th>
                                <th>Дата</th>
                                <th>Кореспондент</th>
                                <th>Зміст</th>
                                <th>Статус</th>
                                <th>Адресат</th>
                                <th>Документ</th>
                                <th width=""8%""></th>
                            </tr>
                        </tfoot>
                        <tbody>
");
            EndContext();
#line 54 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(2093, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2164, 17, false);
#line 57 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                               Write(item.Document.DId);

#line default
#line hidden
            EndContext();
            BeginContext(2181, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2225, 20, false);
#line 58 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                               Write(item.Document.DIndex);

#line default
#line hidden
            EndContext();
            BeginContext(2245, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2289, 42, false);
#line 59 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                               Write(item.Document.DDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2331, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2375, 19, false);
#line 60 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                               Write(item.Document.DFrom);

#line default
#line hidden
            EndContext();
            BeginContext(2394, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2438, 20, false);
#line 61 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                               Write(item.Document.DAbout);

#line default
#line hidden
            EndContext();
            BeginContext(2458, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2502, 17, false);
#line 62 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                               Write(item.Status.SName);

#line default
#line hidden
            EndContext();
            BeginContext(2519, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2563, 13, false);
#line 63 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                               Write(item.HAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2576, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2619, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f11732ec4be43f7b74f0b8609277d19", async() => {
                BeginContext(2665, 54, false);
#line 64 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => item.Document.File.FName));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2628, "~/Home/Download/", 2628, 16, true);
#line 64 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2644, item.Document.FId, 2644, 18, false);

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
            BeginContext(2723, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 65 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                 if (User.IsInRole("rector"))
                                {

#line default
#line hidden
            BeginContext(2828, 614, true);
            WriteLiteral(@"                                    <td align=""center"">
                                        <div class=""btn-group-vertical"">
                                            <div class=""btn-group"">
                                                <button type=""button"" class=""btn btn-link dropdown-toggle"" data-toggle=""dropdown"" style=""text-decoration: none;"">
                                                    Керування
                                                </button>
                                                <div class=""dropdown-menu"">
                                                    ");
            EndContext();
            BeginContext(3442, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e884d1f6d6014c898bf41fff6512aa5c", async() => {
                BeginContext(3506, 18, true);
                WriteLiteral("Написати резолюцію");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3473, "~/Home/AddResolve?hid=", 3473, 22, true);
#line 74 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3495, item.Hid, 3495, 9, false);

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
            BeginContext(3528, 299, true);
            WriteLiteral(@"
                                                   <!-- <a class=""dropdown-item"">Назва 1</a> -->
                                                </div>
                                            </div>
                                        </div>
                                    </td>
");
            EndContext();
#line 80 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3935, 599, true);
            WriteLiteral(@"                                    <td>
                                        <div class=""btn-group-vertical"">
                                            <div class=""btn-group"">
                                                <button type=""button"" class=""btn btn-link dropdown-toggle"" data-toggle=""dropdown"" style=""text-decoration: none;"">
                                                    Керування
                                                </button>
                                                <div class=""dropdown-menu"">
                                                    ");
            EndContext();
            BeginContext(4534, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b1b95e237da4c8b9ec0dd1b24586fb1", async() => {
                BeginContext(4600, 20, true);
                WriteLiteral("Підтвердити перегляд");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4565, "~/Home/ChangeStatus?hid=", 4565, 24, true);
#line 90 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4589, item.Hid, 4589, 9, false);

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
            BeginContext(4624, 307, true);
            WriteLiteral(@"
                                                    <!--  <a class=""dropdown-item"" href="""">Дія 1</a> -->
                                                </div>
                                            </div>
                                        </div>
                                    </td>
");
            EndContext();
#line 96 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(4966, 35, true);
            WriteLiteral("                            </tr>\r\n");
            EndContext();
#line 98 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(5032, 451, true);
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
            BeginContext(5483, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16fa3af08d26422cb36f6a8cfa609a0d", async() => {
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
            BeginContext(5534, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(5540, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75f3b802de1e41419a6b9655a49830b4", async() => {
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
            BeginContext(5585, 38, true);
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
