#pragma checksum "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\AddResolve.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64a4a622f13da8aefe185de91b6cfd32ac70bcdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddResolve), @"mvc.1.0.view", @"/Views/Home/AddResolve.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AddResolve.cshtml", typeof(AspNetCore.Views_Home_AddResolve))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64a4a622f13da8aefe185de91b6cfd32ac70bcdf", @"/Views/Home/AddResolve.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"040f4398a80ff197aedbfab3845cd9d5df43dbe9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddResolve : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FactWorkflow.Models.AddResolve>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\AddResolve.cshtml"
  
    ViewData["Title"] = "Tokens";
    

#line default
#line hidden
            BeginContext(86, 839, true);
            WriteLiteral(@"
<div id=""content-wrapper"">

    <div class=""container-fluid"">

        <!-- Breadcrumbs-->
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""~Home/Index"">Головна</a>
            </li>
            <li class=""breadcrumb-item active"">Додати резолюцію</li>
        </ol>

        <div class=""card mb-3"">
            <div class=""card-header"">
                <i class=""fas fa-table""></i>
                Інформація про документ
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered table-striped"">
                        <tbody>
                            <tr>
                                <th width=""15%"">Номер документа</th>
                                <td>");
            EndContext();
            BeginContext(926, 43, false);
#line 29 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\AddResolve.cshtml"
                               Write(Html.DisplayFor(model => model.History.DId));

#line default
#line hidden
            EndContext();
            BeginContext(969, 173, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th width=\"15%\">Індекс</th>\r\n                                <td>");
            EndContext();
            BeginContext(1143, 55, false);
#line 33 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\AddResolve.cshtml"
                               Write(Html.DisplayFor(model => model.History.Document.DIndex));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 181, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th width=\"15%\">Дата отримання</th>\r\n                                <td>");
            EndContext();
            BeginContext(1380, 61, false);
#line 37 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\AddResolve.cshtml"
                               Write(Html.Raw(Model.History.Document.DDate.ToString("dd.MM.yyyy")));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 178, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th width=\"15%\">Коресподент</th>\r\n                                <td>");
            EndContext();
            BeginContext(1620, 54, false);
#line 41 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\AddResolve.cshtml"
                               Write(Html.DisplayFor(model => model.History.Document.DFrom));

#line default
#line hidden
            EndContext();
            BeginContext(1674, 181, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th width=\"15%\">Короткий зміст</th>\r\n                                <td>");
            EndContext();
            BeginContext(1856, 55, false);
#line 45 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\AddResolve.cshtml"
                               Write(Html.DisplayFor(model => model.History.Document.DAbout));

#line default
#line hidden
            EndContext();
            BeginContext(1911, 486, true);
            WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>

        <div class=""card mb-3"">
            <div class=""card-header"">
                <i class=""fas fa-table""></i>
                Резолюція
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <div class=""col-lg-6"">
                        ");
            EndContext();
            BeginContext(2397, 838, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f5daf23f26480190b773cc36d4035d", async() => {
                BeginContext(2459, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2490, 42, false);
#line 62 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\AddResolve.cshtml"
                       Write(Html.HiddenFor(model => model.History.Hid));

#line default
#line hidden
                EndContext();
                BeginContext(2532, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2563, 42, false);
#line 63 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\AddResolve.cshtml"
                       Write(Html.HiddenFor(model => model.History.DId));

#line default
#line hidden
                EndContext();
                BeginContext(2605, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2636, 42, false);
#line 64 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\AddResolve.cshtml"
                       Write(Html.HiddenFor(model => model.History.UId));

#line default
#line hidden
                EndContext();
                BeginContext(2678, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2709, 47, false);
#line 65 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\AddResolve.cshtml"
                       Write(Html.HiddenFor(model => model.History.HAddress));

#line default
#line hidden
                EndContext();
                BeginContext(2756, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2787, 42, false);
#line 66 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\AddResolve.cshtml"
                       Write(Html.HiddenFor(model => model.History.TId));

#line default
#line hidden
                EndContext();
                BeginContext(2829, 88, true);
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                ");
                EndContext();
                BeginContext(2917, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "318add8978f543d2bb97d0da1f9a19d1", async() => {
                    BeginContext(2948, 9, true);
                    WriteLiteral("Резолюція");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 68 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\AddResolve.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Resolve.RText);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2965, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2999, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd0e13c4770148a5b6932bfb69aafc59", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 69 "D:\Sandbox\FactWorkflow\FactWorkflow\Views\Home\AddResolve.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Resolve.RText);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3065, 163, true);
                WriteLiteral("\r\n                            </div>\r\n                            <button type=\"submit\" class=\"btn btn-default\">Додати резолюцію</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3235, 417, true);
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

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FactWorkflow.Models.AddResolve> Html { get; private set; }
    }
}
#pragma warning restore 1591
