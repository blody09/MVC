#pragma checksum "C:\Users\Lock\OneDrive\Desktop\Assignments\MVCLab\MVCLab\Views\Trip\MileageResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4babbed4fb85be38e75f006ddd69d0980d85ddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trip_MileageResult), @"mvc.1.0.view", @"/Views/Trip/MileageResult.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4babbed4fb85be38e75f006ddd69d0980d85ddf", @"/Views/Trip/MileageResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3203db848336499b4bb043e09fd62d44056bc97", @"/Views/_ViewImports.cshtml")]
    public class Views_Trip_MileageResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tripometer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lock\OneDrive\Desktop\Assignments\MVCLab\MVCLab\Views\Trip\MileageResult.cshtml"
  
    ViewData["Title"] = "MileageResult";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Lock\OneDrive\Desktop\Assignments\MVCLab\MVCLab\Views\Trip\MileageResult.cshtml"
   double range = Model.MPG * Model.Gallons;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Lock\OneDrive\Desktop\Assignments\MVCLab\MVCLab\Views\Trip\MileageResult.cshtml"
   double rangeleft = range - Model.Trip;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Range til empty: ");
#nullable restore
#line 13 "C:\Users\Lock\OneDrive\Desktop\Assignments\MVCLab\MVCLab\Views\Trip\MileageResult.cshtml"
                Write(rangeleft);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h2>Range: ");
#nullable restore
#line 15 "C:\Users\Lock\OneDrive\Desktop\Assignments\MVCLab\MVCLab\Views\Trip\MileageResult.cshtml"
      Write(range);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Lock\OneDrive\Desktop\Assignments\MVCLab\MVCLab\Views\Trip\MileageResult.cshtml"
 if (range < Model.Trip)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 style=\"color: red;\">You need more gas</h2>\r\n");
#nullable restore
#line 20 "C:\Users\Lock\OneDrive\Desktop\Assignments\MVCLab\MVCLab\Views\Trip\MileageResult.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 style=\"color: green;\">You have enough gas</h2>\r\n");
#nullable restore
#line 24 "C:\Users\Lock\OneDrive\Desktop\Assignments\MVCLab\MVCLab\Views\Trip\MileageResult.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tripometer> Html { get; private set; }
    }
}
#pragma warning restore 1591
