#pragma checksum "D:\Identity\IdentityServer4.Samples\Quickstarts\Combined_AspId_and_EFStorage\src\MvcClient\Views\Home\Secure.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b63c131b5ae02c7feab49ff6d11bd5d8f2c3d1a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Secure), @"mvc.1.0.view", @"/Views/Home/Secure.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Secure.cshtml", typeof(AspNetCore.Views_Home_Secure))]
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
#line 1 "D:\Identity\IdentityServer4.Samples\Quickstarts\Combined_AspId_and_EFStorage\src\MvcClient\Views\_ViewImports.cshtml"
using MvcClient;

#line default
#line hidden
#line 1 "D:\Identity\IdentityServer4.Samples\Quickstarts\Combined_AspId_and_EFStorage\src\MvcClient\Views\Home\Secure.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b63c131b5ae02c7feab49ff6d11bd5d8f2c3d1a0", @"/Views/Home/Secure.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"701af7170455274798b4c65ab94fd0e36dcf510b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Secure : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CallApi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 32, true);
            WriteLiteral("\r\n<h2>Claims</h2>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(76, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f2e9b66c8d546f998104778c99d6a08", async() => {
                BeginContext(100, 25, true);
                WriteLiteral("Call API using user token");
                EndContext();
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
            EndContext();
            BeginContext(129, 18, true);
            WriteLiteral("\r\n</div>\r\n\r\n<dl>\r\n");
            EndContext();
#line 10 "D:\Identity\IdentityServer4.Samples\Quickstarts\Combined_AspId_and_EFStorage\src\MvcClient\Views\Home\Secure.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
            BeginContext(195, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(208, 10, false);
#line 12 "D:\Identity\IdentityServer4.Samples\Quickstarts\Combined_AspId_and_EFStorage\src\MvcClient\Views\Home\Secure.cshtml"
       Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(218, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(238, 11, false);
#line 13 "D:\Identity\IdentityServer4.Samples\Quickstarts\Combined_AspId_and_EFStorage\src\MvcClient\Views\Home\Secure.cshtml"
       Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(249, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 14 "D:\Identity\IdentityServer4.Samples\Quickstarts\Combined_AspId_and_EFStorage\src\MvcClient\Views\Home\Secure.cshtml"
    }

#line default
#line hidden
            BeginContext(263, 38, true);
            WriteLiteral("</dl>\r\n\r\n<h2>Properties</h2>\r\n\r\n<dl>\r\n");
            EndContext();
#line 20 "D:\Identity\IdentityServer4.Samples\Quickstarts\Combined_AspId_and_EFStorage\src\MvcClient\Views\Home\Secure.cshtml"
     foreach (var prop in (await Context.AuthenticateAsync()).Properties.Items)
    {

#line default
#line hidden
            BeginContext(389, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(402, 8, false);
#line 22 "D:\Identity\IdentityServer4.Samples\Quickstarts\Combined_AspId_and_EFStorage\src\MvcClient\Views\Home\Secure.cshtml"
       Write(prop.Key);

#line default
#line hidden
            EndContext();
            BeginContext(410, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(430, 10, false);
#line 23 "D:\Identity\IdentityServer4.Samples\Quickstarts\Combined_AspId_and_EFStorage\src\MvcClient\Views\Home\Secure.cshtml"
       Write(prop.Value);

#line default
#line hidden
            EndContext();
            BeginContext(440, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 24 "D:\Identity\IdentityServer4.Samples\Quickstarts\Combined_AspId_and_EFStorage\src\MvcClient\Views\Home\Secure.cshtml"
    }

#line default
#line hidden
            BeginContext(454, 5, true);
            WriteLiteral("</dl>");
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
