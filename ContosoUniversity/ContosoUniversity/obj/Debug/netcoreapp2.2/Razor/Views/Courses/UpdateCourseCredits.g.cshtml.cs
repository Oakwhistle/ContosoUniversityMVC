#pragma checksum "C:\Users\Oakwhistle\Source\repos\PS\ContosoUniversityMVC\ContosoUniversity\ContosoUniversity\Views\Courses\UpdateCourseCredits.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da8da3b1bf676a587eaad4a95c1dc454e884c760"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_UpdateCourseCredits), @"mvc.1.0.view", @"/Views/Courses/UpdateCourseCredits.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/UpdateCourseCredits.cshtml", typeof(AspNetCore.Views_Courses_UpdateCourseCredits))]
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
#line 1 "C:\Users\Oakwhistle\Source\repos\PS\ContosoUniversityMVC\ContosoUniversity\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#line 2 "C:\Users\Oakwhistle\Source\repos\PS\ContosoUniversityMVC\ContosoUniversity\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da8da3b1bf676a587eaad4a95c1dc454e884c760", @"/Views/Courses/UpdateCourseCredits.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8c63dad9db0b17e31c66667dec1a52add46bdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_UpdateCourseCredits : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCourseCredits", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Oakwhistle\Source\repos\PS\ContosoUniversityMVC\ContosoUniversity\ContosoUniversity\Views\Courses\UpdateCourseCredits.cshtml"
  
    ViewBag.Title = "UpdateCourseCredits";

#line default
#line hidden
            BeginContext(51, 36, true);
            WriteLiteral("\r\n<h2>Update Course Credits</h2>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Oakwhistle\Source\repos\PS\ContosoUniversityMVC\ContosoUniversity\ContosoUniversity\Views\Courses\UpdateCourseCredits.cshtml"
 if (ViewData["RowsAffected"] == null)
{

#line default
#line hidden
            BeginContext(130, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(134, 362, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da8da3b1bf676a587eaad4a95c1dc454e884c7604467", async() => {
                BeginContext(173, 134, true);
                WriteLiteral("\r\n        <div class=\"form-actions no-color\">\r\n            <p>\r\n                Enter a number to multiply every course\'s credits by: ");
                EndContext();
                BeginContext(308, 26, false);
#line 12 "C:\Users\Oakwhistle\Source\repos\PS\ContosoUniversityMVC\ContosoUniversity\ContosoUniversity\Views\Courses\UpdateCourseCredits.cshtml"
                                                                 Write(Html.TextBox("multiplier"));

#line default
#line hidden
                EndContext();
                BeginContext(334, 155, true);
                WriteLiteral("\r\n            </p>\r\n            <p>\r\n                <input type=\"submit\" value=\"Update\" class=\"btn btn-default\" />\r\n            </p>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(496, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\Oakwhistle\Source\repos\PS\ContosoUniversityMVC\ContosoUniversity\ContosoUniversity\Views\Courses\UpdateCourseCredits.cshtml"
}

#line default
#line hidden
#line 20 "C:\Users\Oakwhistle\Source\repos\PS\ContosoUniversityMVC\ContosoUniversity\ContosoUniversity\Views\Courses\UpdateCourseCredits.cshtml"
 if (ViewData["RowsAffected"] != null)
{

#line default
#line hidden
            BeginContext(544, 41, true);
            WriteLiteral("    <p>\r\n        Number of rows updated: ");
            EndContext();
            BeginContext(586, 24, false);
#line 23 "C:\Users\Oakwhistle\Source\repos\PS\ContosoUniversityMVC\ContosoUniversity\ContosoUniversity\Views\Courses\UpdateCourseCredits.cshtml"
                           Write(ViewData["RowsAffected"]);

#line default
#line hidden
            EndContext();
            BeginContext(610, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 25 "C:\Users\Oakwhistle\Source\repos\PS\ContosoUniversityMVC\ContosoUniversity\ContosoUniversity\Views\Courses\UpdateCourseCredits.cshtml"
}

#line default
#line hidden
            BeginContext(625, 11, true);
            WriteLiteral("<div>\r\n    ");
            EndContext();
            BeginContext(637, 40, false);
#line 27 "C:\Users\Oakwhistle\Source\repos\PS\ContosoUniversityMVC\ContosoUniversity\ContosoUniversity\Views\Courses\UpdateCourseCredits.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(677, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
