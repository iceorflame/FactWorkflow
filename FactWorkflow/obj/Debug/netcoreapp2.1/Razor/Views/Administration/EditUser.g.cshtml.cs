#pragma checksum "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Administration\EditUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ee9f2ed49f057a0dd1da8eb02640bf6bbf35b38"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee9f2ed49f057a0dd1da8eb02640bf6bbf35b38", @"/Views/Administration/EditUser.cshtml")]
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
  
    ViewData["Title"] = "Зміна ролі користувача";
    

#line default
#line hidden
            BeginContext(96, 657, true);
            WriteLiteral(@"
<div id=""content-wrapper"">

    <div class=""container-fluid"">

        <!-- Breadcrumbs-->
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <span>Адміністрування</span>
            </li>
            <li class=""breadcrumb-item"">Зміна ролі користувача</li>
        </ol>

        <div class=""card mb-3"">
            <div class=""card-header"">
                <i class=""fas fa-table""></i>
                Змінити роль користувача
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <div class=""col-lg-6"">
                        ");
            EndContext();
            BeginContext(753, 1297, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3553c885ed7e4c058c4e50cf35e2feb6", async() => {
                BeginContext(785, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(816, 34, false);
#line 27 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Administration\EditUser.cshtml"
                       Write(Html.HiddenFor(model => model.UId));

#line default
#line hidden
                EndContext();
                BeginContext(850, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(881, 40, false);
#line 28 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Administration\EditUser.cshtml"
                       Write(Html.HiddenFor(model => model.UPassword));

#line default
#line hidden
                EndContext();
                BeginContext(921, 157, true);
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label>ПІБ/Назва підрозділу</label>\r\n                                ");
                EndContext();
                BeginContext(1079, 150, false);
#line 31 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Administration\EditUser.cshtml"
                           Write(Html.EditorFor(model => model.UName, new { htmlAttributes = new { @autocomplete = "off", @type = "text", @class="form-control", @readonly = "true" }}));

#line default
#line hidden
                EndContext();
                BeginContext(1229, 189, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Електронна пошта</label>\r\n                                ");
                EndContext();
                BeginContext(1419, 151, false);
#line 35 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Administration\EditUser.cshtml"
                           Write(Html.EditorFor(model => model.UMail, new { htmlAttributes = new { @autocomplete = "off", @type = "text", @class="form-control", @readonly = "true" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1570, 189, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Роль користувача</label>\r\n                                ");
                EndContext();
                BeginContext(1760, 119, false);
#line 39 "D:\Data\Files\Visual Studio\FactWorkflow\FactWorkflow\Views\Administration\EditUser.cshtml"
                           Write(Html.DropDownListFor(model => model.RId, ViewBag.Roles as SelectList, new { @type = "text", @class = "form-control"  }));

#line default
#line hidden
                EndContext();
                BeginContext(1879, 164, true);
                WriteLiteral("\r\n                            </div>\r\n                            <button type=\"submit\" class=\"btn btn-outline-dark\">Змінити роль</button>\r\n                        ");
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
            BeginContext(2050, 445, true);
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
