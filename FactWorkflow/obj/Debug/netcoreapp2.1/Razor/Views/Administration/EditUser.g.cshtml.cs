#pragma checksum "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Administration\EditUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89c9d8d30f08b8299e6e59399e8322b7b0b033c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_EditUser), @"mvc.1.0.view", @"/Views/Administration/EditUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration/EditUser.cshtml", typeof(AspNetCore.Views_Administration_EditUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89c9d8d30f08b8299e6e59399e8322b7b0b033c1", @"/Views/Administration/EditUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f566decc4ae3945f4f7812ea3607228cedc3698f", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_EditUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FactWorkflow.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Administration\EditUser.cshtml"
  
    ViewData["Title"] = "Users";
    

#line default
#line hidden
            BeginContext(79, 639, true);
            WriteLiteral(@"
<div id=""content-wrapper"">

    <div class=""container-fluid"">

        <!-- Breadcrumbs-->
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""#"">Dashboard</a>
            </li>
            <li class=""breadcrumb-item active"">Tables</li>
        </ol>

        <div class=""card mb-3"">
            <div class=""card-header"">
                <i class=""fas fa-table""></i>
                Data Table Example
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <div class=""col-lg-6"">
                        ");
            EndContext();
            BeginContext(718, 1327, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ed480ee3b8a450dbc861e834d41db80", async() => {
                BeginContext(750, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(781, 34, false);
#line 27 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Administration\EditUser.cshtml"
                       Write(Html.HiddenFor(model => model.UId));

#line default
#line hidden
                EndContext();
                BeginContext(815, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(846, 40, false);
#line 28 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Administration\EditUser.cshtml"
                       Write(Html.HiddenFor(model => model.UPassword));

#line default
#line hidden
                EndContext();
                BeginContext(886, 164, true);
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label>Text Input with Placeholder</label>\r\n                                ");
                EndContext();
                BeginContext(1051, 150, false);
#line 31 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Administration\EditUser.cshtml"
                           Write(Html.EditorFor(model => model.UName, new { htmlAttributes = new { @autocomplete = "off", @type = "text", @class="form-control", @readonly = "true" }}));

#line default
#line hidden
                EndContext();
                BeginContext(1201, 200, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Text Input with Placeholder</label>\r\n                                ");
                EndContext();
                BeginContext(1402, 151, false);
#line 35 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Administration\EditUser.cshtml"
                           Write(Html.EditorFor(model => model.UMail, new { htmlAttributes = new { @autocomplete = "off", @type = "text", @class="form-control", @readonly = "true" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1553, 200, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Text Input with Placeholder</label>\r\n                                ");
                EndContext();
                BeginContext(1754, 119, false);
#line 39 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Administration\EditUser.cshtml"
                           Write(Html.DropDownListFor(model => model.RId, ViewBag.Roles as SelectList, new { @type = "text", @class = "form-control"  }));

#line default
#line hidden
                EndContext();
                BeginContext(1873, 165, true);
                WriteLiteral("\r\n                            </div>\r\n                            <button type=\"submit\" class=\"btn btn-outline-dark\">Submit Button</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2045, 536, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""card-footer small text-muted"">Updated yesterday at 11:59 PM</div>
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
