#pragma checksum "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9178545404245560cb7adb05143635ff89e6491e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9178545404245560cb7adb05143635ff89e6491e", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64cf0a236d56eca9d840dd0b9dea939e5f8e0b08", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BronyForm.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(15, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9178545404245560cb7adb05143635ff89e6491e3543", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 3 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new Brony(){ UserId = @Model.UserId  };

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(96, 12, true);
            WriteLiteral("</partial>\r\n");
            EndContext();
#line 4 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\Dashboard.cshtml"
  
    decimal sum = Model.MyLittleBronies.Sum( b => b.Price );

#line default
#line hidden
            BeginContext(177, 35, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1>");
            EndContext();
            BeginContext(213, 10, false);
#line 9 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\Dashboard.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(223, 28, true);
            WriteLiteral("</h1>\r\n    <p># of Bronies: ");
            EndContext();
            BeginContext(252, 27, false);
#line 10 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\Dashboard.cshtml"
                Write(Model.MyLittleBronies.Count);

#line default
#line hidden
            EndContext();
            BeginContext(279, 38, true);
            WriteLiteral("</p>\r\n    <p>Total Collection Value: $");
            EndContext();
            BeginContext(318, 3, false);
#line 11 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\Dashboard.cshtml"
                           Write(sum);

#line default
#line hidden
            EndContext();
            BeginContext(321, 238, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<table class=\"table table-striped\"> \r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Color</th>\r\n            <th>Condition</th>\r\n            <th>Price</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 24 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\Dashboard.cshtml"
         foreach( var b in Model.MyLittleBronies)
        {

#line default
#line hidden
            BeginContext(621, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(660, 6, false);
#line 27 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\Dashboard.cshtml"
               Write(b.Name);

#line default
#line hidden
            EndContext();
            BeginContext(666, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(694, 7, false);
#line 28 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\Dashboard.cshtml"
               Write(b.Color);

#line default
#line hidden
            EndContext();
            BeginContext(701, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(729, 11, false);
#line 29 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\Dashboard.cshtml"
               Write(b.Condition);

#line default
#line hidden
            EndContext();
            BeginContext(740, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(768, 7, false);
#line 30 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\Dashboard.cshtml"
               Write(b.Price);

#line default
#line hidden
            EndContext();
            BeginContext(775, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 32 "C:\Users\OYEWO\Desktop\CODING_DOJO\C sharp\ASP.NET\TradingBronies\Views\Home\Dashboard.cshtml"
        }

#line default
#line hidden
            BeginContext(812, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
