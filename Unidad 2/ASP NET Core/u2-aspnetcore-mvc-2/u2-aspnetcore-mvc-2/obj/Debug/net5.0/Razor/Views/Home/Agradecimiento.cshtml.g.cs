#pragma checksum "C:\Users\anton\source\repos\u2-aspnetcore-mvc-2\u2-aspnetcore-mvc-2\Views\Home\Agradecimiento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c9154e9c7d9e6203badc9b5b9b6bfa85cce7ad9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Agradecimiento), @"mvc.1.0.view", @"/Views/Home/Agradecimiento.cshtml")]
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
#line 1 "C:\Users\anton\source\repos\u2-aspnetcore-mvc-2\u2-aspnetcore-mvc-2\Views\_ViewImports.cshtml"
using u2_aspnetcore_mvc_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anton\source\repos\u2-aspnetcore-mvc-2\u2-aspnetcore-mvc-2\Views\_ViewImports.cshtml"
using u2_aspnetcore_mvc_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c9154e9c7d9e6203badc9b5b9b6bfa85cce7ad9", @"/Views/Home/Agradecimiento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c91045428576f7a7c0aaa9424c8886158433c0ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Agradecimiento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModelAlumnoEncuesta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListadoRespuestas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Gracias por responder la encuesta</h1>\r\n<p>\r\n");
#nullable restore
#line 4 "C:\Users\anton\source\repos\u2-aspnetcore-mvc-2\u2-aspnetcore-mvc-2\Views\Home\Agradecimiento.cshtml"
     if(Model.RegresarClases)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("Te esperamos pronto!\r\n");
#nullable restore
#line 7 "C:\Users\anton\source\repos\u2-aspnetcore-mvc-2\u2-aspnetcore-mvc-2\Views\Home\Agradecimiento.cshtml"
     }
     else
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("Hay que seguir cuid??ndonos!\r\n");
#nullable restore
#line 11 "C:\Users\anton\source\repos\u2-aspnetcore-mvc-2\u2-aspnetcore-mvc-2\Views\Home\Agradecimiento.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c9154e9c7d9e6203badc9b5b9b6bfa85cce7ad94395", async() => {
                WriteLiteral("Ver las dem??s respuestas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModelAlumnoEncuesta> Html { get; private set; }
    }
}
#pragma warning restore 1591
