#pragma checksum "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\MVCtemplate\Views\Home\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5008f051268cd93951ebf6395c3086b3cf371b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Success.cshtml", typeof(AspNetCore.Views_Home_Success))]
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
#line 1 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\MVCtemplate\Views\_ViewImports.cshtml"
using MVCtemplate;

#line default
#line hidden
#line 2 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\MVCtemplate\Views\_ViewImports.cshtml"
using MVCtemplate.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5008f051268cd93951ebf6395c3086b3cf371b7", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7924152243c768d8e46d0ab58c50c66fa9b89c65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 29, true);
            WriteLiteral("<h1>SUCCESS</h1>\r\n<p>Welcome ");
            EndContext();
            BeginContext(30, 12, false);
#line 2 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\MVCtemplate\Views\Home\Success.cshtml"
      Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(42, 2, true);
            WriteLiteral("! ");
            EndContext();
            BeginContext(45, 11, false);
#line 2 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\MVCtemplate\Views\Home\Success.cshtml"
                     Write(ViewBag.Age);

#line default
#line hidden
            EndContext();
            BeginContext(56, 32, true);
            WriteLiteral("</p>\r\n<a href=\"/logout\">Home</a>");
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