#pragma checksum "C:\Users\anton\source\repos\appASPWebForms1\Unidad 2\ASP NET Core\u2-aspnetcore-mvc-3\u2-aspnetcore-mvc-3\Views\Home\ListadoEmpleados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97911b31ab35f56185199c45755ed90c3bca53af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListadoEmpleados), @"mvc.1.0.view", @"/Views/Home/ListadoEmpleados.cshtml")]
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
#line 1 "C:\Users\anton\source\repos\appASPWebForms1\Unidad 2\ASP NET Core\u2-aspnetcore-mvc-3\u2-aspnetcore-mvc-3\Views\_ViewImports.cshtml"
using u2_aspnetcore_mvc_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anton\source\repos\appASPWebForms1\Unidad 2\ASP NET Core\u2-aspnetcore-mvc-3\u2-aspnetcore-mvc-3\Views\_ViewImports.cshtml"
using u2_aspnetcore_mvc_3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97911b31ab35f56185199c45755ed90c3bca53af", @"/Views/Home/ListadoEmpleados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0207f057df51e64124d081501e353c9b7e3eed7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListadoEmpleados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Empleado>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegistroEmpleado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("<table class=\"table table-striped\">\r\n");
#nullable restore
#line 6 "C:\Users\anton\source\repos\appASPWebForms1\Unidad 2\ASP NET Core\u2-aspnetcore-mvc-3\u2-aspnetcore-mvc-3\Views\Home\ListadoEmpleados.cshtml"
     foreach (Empleado empleado in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 9 "C:\Users\anton\source\repos\appASPWebForms1\Unidad 2\ASP NET Core\u2-aspnetcore-mvc-3\u2-aspnetcore-mvc-3\Views\Home\ListadoEmpleados.cshtml"
           Write(empleado.NumeroEmpleado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 10 "C:\Users\anton\source\repos\appASPWebForms1\Unidad 2\ASP NET Core\u2-aspnetcore-mvc-3\u2-aspnetcore-mvc-3\Views\Home\ListadoEmpleados.cshtml"
           Write(empleado.NombreCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 11 "C:\Users\anton\source\repos\appASPWebForms1\Unidad 2\ASP NET Core\u2-aspnetcore-mvc-3\u2-aspnetcore-mvc-3\Views\Home\ListadoEmpleados.cshtml"
           Write(empleado.Puesto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "C:\Users\anton\source\repos\appASPWebForms1\Unidad 2\ASP NET Core\u2-aspnetcore-mvc-3\u2-aspnetcore-mvc-3\Views\Home\ListadoEmpleados.cshtml"
           Write(empleado.HorasTrabajadas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\anton\source\repos\appASPWebForms1\Unidad 2\ASP NET Core\u2-aspnetcore-mvc-3\u2-aspnetcore-mvc-3\Views\Home\ListadoEmpleados.cshtml"
           Write(empleado.Sueldo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\anton\source\repos\appASPWebForms1\Unidad 2\ASP NET Core\u2-aspnetcore-mvc-3\u2-aspnetcore-mvc-3\Views\Home\ListadoEmpleados.cshtml"
           Write(Html.ActionLink("Editar", "EditarEmpleado", new { numEmpleado = empleado.NumeroEmpleado}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 16 "C:\Users\anton\source\repos\appASPWebForms1\Unidad 2\ASP NET Core\u2-aspnetcore-mvc-3\u2-aspnetcore-mvc-3\Views\Home\ListadoEmpleados.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td> </td>\r\n    <td> </td>\r\n    <td> </td>\r\n    <td> </td>\r\n</tr>\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97911b31ab35f56185199c45755ed90c3bca53af6362", async() => {
                WriteLiteral("Registrar otro empleado");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Empleado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
