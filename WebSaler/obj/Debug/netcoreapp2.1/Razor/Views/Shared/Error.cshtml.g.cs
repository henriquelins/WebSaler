#pragma checksum "C:\Temp\ws-vs2019\WebSaler\WebSaler\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaabf94f3846283edde829ced80011a52a458c59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Temp\ws-vs2019\WebSaler\WebSaler\Views\_ViewImports.cshtml"
using WebSaler;

#line default
#line hidden
#line 2 "C:\Temp\ws-vs2019\WebSaler\WebSaler\Views\_ViewImports.cshtml"
using WebSaler.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaabf94f3846283edde829ced80011a52a458c59", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f63b34bfc77ce811070fa16883d93585fca4f273", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSaler.Models.ViewModels.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Temp\ws-vs2019\WebSaler\WebSaler\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(91, 26, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">");
            EndContext();
            BeginContext(118, 17, false);
#line 6 "C:\Temp\ws-vs2019\WebSaler\WebSaler\Views\Shared\Error.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(135, 31, true);
            WriteLiteral("</h1>\r\n<h2 class=\"text-danger\">");
            EndContext();
            BeginContext(167, 13, false);
#line 7 "C:\Temp\ws-vs2019\WebSaler\WebSaler\Views\Shared\Error.cshtml"
                   Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(180, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Temp\ws-vs2019\WebSaler\WebSaler\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(219, 52, true);
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(272, 15, false);
#line 12 "C:\Temp\ws-vs2019\WebSaler\WebSaler\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(287, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 14 "C:\Temp\ws-vs2019\WebSaler\WebSaler\Views\Shared\Error.cshtml"
}

#line default
#line hidden
            BeginContext(309, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSaler.Models.ViewModels.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
