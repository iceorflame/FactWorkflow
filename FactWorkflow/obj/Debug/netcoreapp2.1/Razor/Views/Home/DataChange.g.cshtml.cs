#pragma checksum "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\DataChange.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d036f551d23559af60eb1231aef716f1d4a327d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DataChange), @"mvc.1.0.view", @"/Views/Home/DataChange.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DataChange.cshtml", typeof(AspNetCore.Views_Home_DataChange))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d036f551d23559af60eb1231aef716f1d4a327d", @"/Views/Home/DataChange.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f566decc4ae3945f4f7812ea3607228cedc3698f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DataChange : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FactWorkflow.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\DataChange.cshtml"
  
    ViewData["Title"] = "Users";
    

#line default
#line hidden
            BeginContext(79, 189, true);
            WriteLiteral("\r\n<div id=\"content-wrapper\">\r\n\r\n    <div class=\"container-fluid\">\r\n\r\n        <!-- Breadcrumbs-->\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                ");
            EndContext();
            BeginContext(268, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac678ce99f2b4941a345199739ac3270", async() => {
                BeginContext(291, 7, true);
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
            BeginContext(302, 440, true);
            WriteLiteral(@"
            </li>
            <li class=""breadcrumb-item active"">Дані користувача</li>
        </ol>

        <div class=""card mb-3"">
            <div class=""card-header"">
                <i class=""fas fa-table""></i>
                Зміна даних користувача
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <div class=""col-lg-6"">
                        ");
            EndContext();
            BeginContext(742, 1631, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "683ed95ddd5d4d179dc145bb850880ef", async() => {
                BeginContext(774, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(805, 34, false);
#line 27 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\DataChange.cshtml"
                       Write(Html.HiddenFor(model => model.UId));

#line default
#line hidden
                EndContext();
                BeginContext(839, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(870, 40, false);
#line 28 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\DataChange.cshtml"
                       Write(Html.HiddenFor(model => model.UPassword));

#line default
#line hidden
                EndContext();
                BeginContext(910, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(941, 34, false);
#line 29 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\DataChange.cshtml"
                       Write(Html.HiddenFor(model => model.RId));

#line default
#line hidden
                EndContext();
                BeginContext(975, 157, true);
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label>ПІБ/Назва підрозділу</label>\r\n                                ");
                EndContext();
                BeginContext(1133, 133, false);
#line 32 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\DataChange.cshtml"
                           Write(Html.EditorFor(model => model.UName, new { htmlAttributes = new { @autocomplete = "off", @type = "text", @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1266, 189, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Електронна пошта</label>\r\n                                ");
                EndContext();
                BeginContext(1456, 133, false);
#line 36 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Home\DataChange.cshtml"
                           Write(Html.EditorFor(model => model.UMail, new { htmlAttributes = new { @autocomplete = "off", @type = "text", @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1589, 777, true);
                WriteLiteral(@"
                            </div>
                            <div class=""form-group"">
                                <label>Новий пароль(необов'язково)</label>
                                <input type=""password"" class=""form-control"" placeholder=""Новий пароль"" name=""newPassword"">
                            </div>
                            <div class=""form-group"">
                                <label>Підтвердження нового паролю(необов'язково)</label>
                                <input type=""password"" class=""form-control"" placeholder=""Підтвердженя нового паролю"" name=""confirmPassword"">
                            </div>
                            <button type=""submit"" class=""btn btn-outline-dark"">Змінити дані</button>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2373, 447, true);
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

<!-- /.content-wrapper -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FactWorkflow.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
