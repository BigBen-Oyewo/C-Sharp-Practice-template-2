#pragma checksum "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\GlueFactory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7c6ae0200a220ed1cdac982eb935b3aa7731168"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GlueFactory), @"mvc.1.0.view", @"/Views/Home/GlueFactory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GlueFactory.cshtml", typeof(AspNetCore.Views_Home_GlueFactory))]
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
#line 1 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\_ViewImports.cshtml"
using TradingBronies;

#line default
#line hidden
#line 2 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\_ViewImports.cshtml"
using TradingBronies.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c6ae0200a220ed1cdac982eb935b3aa7731168", @"/Views/Home/GlueFactory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64cf0a236d56eca9d840dd0b9dea939e5f8e0b08", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GlueFactory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Brony>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 290, true);
            WriteLiteral(@"
<h2>Here are all the Bronies!</h2>

<table class=""table table-striped""> 
    <thead>
        <tr>
            <th>Name</th>
            <th>Color</th>
            <th>Condition</th>
            <th>Price</th>
            <th>Owner</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 16 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\GlueFactory.cshtml"
         foreach( var b in Model)
        {

#line default
#line hidden
            BeginContext(356, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(395, 6, false);
#line 19 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\GlueFactory.cshtml"
               Write(b.Name);

#line default
#line hidden
            EndContext();
            BeginContext(401, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(429, 7, false);
#line 20 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\GlueFactory.cshtml"
               Write(b.Color);

#line default
#line hidden
            EndContext();
            BeginContext(436, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(464, 11, false);
#line 21 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\GlueFactory.cshtml"
               Write(b.Condition);

#line default
#line hidden
            EndContext();
            BeginContext(475, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(503, 7, false);
#line 22 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\GlueFactory.cshtml"
               Write(b.Price);

#line default
#line hidden
            EndContext();
            BeginContext(510, 29, true);
            WriteLiteral("</td>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 539, "\"", 564, 2);
            WriteAttributeValue("", 546, "/profile/", 546, 9, true);
#line 23 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\GlueFactory.cshtml"
WriteAttributeValue("", 555, b.UserId, 555, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(565, 2, true);
            WriteLiteral(" >");
            EndContext();
            BeginContext(568, 12, false);
#line 23 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\GlueFactory.cshtml"
                                             Write(b.Owner.Name);

#line default
#line hidden
            EndContext();
            BeginContext(580, 30, true);
            WriteLiteral("</a></td>\r\n            </tr>\r\n");
            EndContext();
#line 25 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\GlueFactory.cshtml"
        }

#line default
#line hidden
            BeginContext(621, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Brony>> Html { get; private set; }
    }
}
#pragma warning restore 1591
