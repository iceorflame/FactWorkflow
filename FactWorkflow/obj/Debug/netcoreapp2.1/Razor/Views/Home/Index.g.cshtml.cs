#pragma checksum "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fad98d7ac31ee31a514254e30280088101589f6"
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
#line 1 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\_ViewImports.cshtml"
using FactWorkflow;

#line default
#line hidden
#line 2 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\_ViewImports.cshtml"
using FactWorkflow.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fad98d7ac31ee31a514254e30280088101589f6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"040f4398a80ff197aedbfab3845cd9d5df43dbe9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FactWorkflow.Models.Resolve>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tableLanguage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Users";
    

#line default
#line hidden
            BeginContext(95, 189, true);
            WriteLiteral("\r\n<div id=\"content-wrapper\">\r\n\r\n    <div class=\"container-fluid\">\r\n\r\n        <!-- Breadcrumbs-->\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                ");
            EndContext();
            BeginContext(284, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e90f4569e17649be830c7f5a066ec7a4", async() => {
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
            BeginContext(318, 1573, true);
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
                                <th></th>
                            </tr>
                        </thead>
     ");
            WriteLiteral(@"                   <tfoot>
                            <tr>
                                <th>№</th>
                                <th>Індекс</th>
                                <th>Дата</th>
                                <th>Кореспондент</th>
                                <th>Зміст</th>
                                <th>Статус</th>
                                <th>Адресат</th>
                                <th></th>
                            </tr>
                        </tfoot>
                        <tbody>
");
            EndContext();
#line 52 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1980, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(2059, 17, false);
#line 55 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                   Write(item.Document.DId);

#line default
#line hidden
            EndContext();
            BeginContext(2076, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2124, 20, false);
#line 56 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                   Write(item.Document.DIndex);

#line default
#line hidden
            EndContext();
            BeginContext(2144, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2192, 42, false);
#line 57 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                   Write(item.Document.DDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2234, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2282, 19, false);
#line 58 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                   Write(item.Document.DFrom);

#line default
#line hidden
            EndContext();
            BeginContext(2301, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2349, 20, false);
#line 59 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                   Write(item.Document.DAbout);

#line default
#line hidden
            EndContext();
            BeginContext(2369, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2417, 12, false);
#line 60 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                   Write(item.RStatus);

#line default
#line hidden
            EndContext();
            BeginContext(2429, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2477, 13, false);
#line 61 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                   Write(item.RAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2490, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 62 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                     if (User.IsInRole("office"))
                                    {

#line default
#line hidden
            BeginContext(2603, 59, true);
            WriteLiteral("                                        <td align=\"center\">");
            EndContext();
            BeginContext(2662, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70f9f51cc2fc4595ae3e6bd8c03ee065", async() => {
                BeginContext(2709, 52, true);
                WriteLiteral("<i class=\"fa fa-plus bigger-130 padding-2 grey\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2671, "~/Home/SendResolve?resid=", 2671, 25, true);
#line 64 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2696, item.ResId, 2696, 11, false);

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
            BeginContext(2765, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 65 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                    }
                                    else if (User.IsInRole("rector"))
                                    {

#line default
#line hidden
            BeginContext(2921, 59, true);
            WriteLiteral("                                        <td align=\"center\">");
            EndContext();
            BeginContext(2980, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d812e2ba81ed4b2d9c97f3c7d8668905", async() => {
                BeginContext(3026, 52, true);
                WriteLiteral("<i class=\"fa fa-plus bigger-130 padding-2 grey\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2989, "~/Home/AddResolve?resid=", 2989, 24, true);
#line 68 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3013, item.ResId, 3013, 11, false);

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
            BeginContext(3082, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 69 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3209, 59, true);
            WriteLiteral("                                        <td align=\"center\">");
            EndContext();
            BeginContext(3268, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5c323f316e14303b94764c3d9e5b187", async() => {
                BeginContext(3316, 52, true);
                WriteLiteral("<i class=\"fa fa-plus bigger-130 padding-2 grey\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3277, "~/Home/ChangeStatus?resid=", 3277, 26, true);
#line 72 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3303, item.ResId, 3303, 11, false);

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
            BeginContext(3372, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 73 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3418, 39, true);
            WriteLiteral("                                </tr>\r\n");
            EndContext();
#line 75 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3488, 451, true);
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
            BeginContext(3939, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "996d5ae54a22466bb317edae39db2c1a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3990, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(3996, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c74db69c2fe4dcc9408bd0cbe8b04e6", async() => {
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
            BeginContext(4041, 38, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FactWorkflow.Models.Resolve>> Html { get; private set; }
    }
}
#pragma warning restore 1591
