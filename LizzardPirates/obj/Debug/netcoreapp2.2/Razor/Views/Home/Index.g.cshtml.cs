#pragma checksum "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\LizzardPirates\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3134306dd83791c3c2ac6f03bbc986d813c5595"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\LizzardPirates\Views\_ViewImports.cshtml"
using LizzardPirates;

#line default
#line hidden
#line 2 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\LizzardPirates\Views\_ViewImports.cshtml"
using LizzardPirates.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3134306dd83791c3c2ac6f03bbc986d813c5595", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e7ac7be05502cf1f9fe8f4d3e9da4498f841986", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LizzardPirate>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\LizzardPirates\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(73, 356, true);
            WriteLiteral(@"
<h1>Lizard Pirates</h1>
<a href=""/add"" class=""btn btn-primary"">Add Lizard Pirate</a>

<table class=""table table-striped"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Lizard Type</th>
            <th>Pirate Role</th>
            <th>Joined Crew</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\LizzardPirates\Views\Home\Index.cshtml"
         foreach( LizzardPirate lp in Model )
        {

#line default
#line hidden
            BeginContext(487, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(525, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3134306dd83791c3c2ac6f03bbc986d813c55955049", async() => {
                BeginContext(585, 7, false);
#line 23 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\LizzardPirates\Views\Home\Index.cshtml"
                                                                          Write(lp.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-LPId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\LizzardPirates\Views\Home\Index.cshtml"
                                             WriteLiteral(lp.LizzardPirateId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["LPId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-LPId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["LPId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(596, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(624, 14, false);
#line 24 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\LizzardPirates\Views\Home\Index.cshtml"
               Write(lp.LizzardType);

#line default
#line hidden
            EndContext();
            BeginContext(638, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(666, 13, false);
#line 25 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\LizzardPirates\Views\Home\Index.cshtml"
               Write(lp.PirateRole);

#line default
#line hidden
            EndContext();
            BeginContext(679, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(707, 32, false);
#line 26 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\LizzardPirates\Views\Home\Index.cshtml"
               Write(lp.CreatedAt.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(739, 4, true);
            WriteLiteral(" || ");
            EndContext();
            BeginContext(744, 32, false);
#line 26 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\LizzardPirates\Views\Home\Index.cshtml"
                                                    Write(lp.CreatedAt.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(776, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(825, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3134306dd83791c3c2ac6f03bbc986d813c55959173", async() => {
                BeginContext(914, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-LPId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\LizzardPirates\Views\Home\Index.cshtml"
                                             WriteLiteral(lp.LizzardPirateId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["LPId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-LPId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["LPId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(922, 24, true);
            WriteLiteral("\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 946, "\"", 980, 2);
            WriteAttributeValue("", 953, "/delete/", 953, 8, true);
#line 29 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\LizzardPirates\Views\Home\Index.cshtml"
WriteAttributeValue("", 961, lp.LizzardPirateId, 961, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(981, 85, true);
            WriteLiteral(" class=\"btn btn-sm btn-danger\">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 32 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\LizzardPirates\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1077, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LizzardPirate>> Html { get; private set; }
    }
}
#pragma warning restore 1591