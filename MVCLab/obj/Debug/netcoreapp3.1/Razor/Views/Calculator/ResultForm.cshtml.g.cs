#pragma checksum "C:\Users\Lock\OneDrive\Desktop\Assignments\MVCLab\MVCLab\Views\Calculator\ResultForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9ea4a2746a60022c6aa75fb1ddf31e2160438a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_ResultForm), @"mvc.1.0.view", @"/Views/Calculator/ResultForm.cshtml")]
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
#line 1 "C:\Users\Lock\OneDrive\Desktop\Assignments\MVCLab\MVCLab\Views\_ViewImports.cshtml"
using MVCLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lock\OneDrive\Desktop\Assignments\MVCLab\MVCLab\Views\_ViewImports.cshtml"
using MVCLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ea4a2746a60022c6aa75fb1ddf31e2160438a5", @"/Views/Calculator/ResultForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3203db848336499b4bb043e09fd62d44056bc97", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_ResultForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<double>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lock\OneDrive\Desktop\Assignments\MVCLab\MVCLab\Views\Calculator\ResultForm.cshtml"
  
    ViewData["Title"] = "Results";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Results</h1>\r\n\r\n");
            WriteLiteral("<p>The result is ");
#nullable restore
#line 9 "C:\Users\Lock\OneDrive\Desktop\Assignments\MVCLab\MVCLab\Views\Calculator\ResultForm.cshtml"
            Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<double> Html { get; private set; }
    }
}
#pragma warning restore 1591
