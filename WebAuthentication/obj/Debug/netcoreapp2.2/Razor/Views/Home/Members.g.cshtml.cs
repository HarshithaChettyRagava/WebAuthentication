#pragma checksum "C:\Users\S533569\Harshitha_Chetty_Ragava\44663\WebAuthentication\WebAuthentication\Views\Home\Members.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60f9e4c02849fb65f32882aedc8464ac5aa26838"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Members), @"mvc.1.0.view", @"/Views/Home/Members.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Members.cshtml", typeof(AspNetCore.Views_Home_Members))]
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
#line 1 "C:\Users\S533569\Harshitha_Chetty_Ragava\44663\WebAuthentication\WebAuthentication\Views\_ViewImports.cshtml"
using WebAuthentication;

#line default
#line hidden
#line 2 "C:\Users\S533569\Harshitha_Chetty_Ragava\44663\WebAuthentication\WebAuthentication\Views\_ViewImports.cshtml"
using WebAuthentication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60f9e4c02849fb65f32882aedc8464ac5aa26838", @"/Views/Home/Members.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e5a37981f5f464bdf24b1f335702d83143b8c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Members : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\S533569\Harshitha_Chetty_Ragava\44663\WebAuthentication\WebAuthentication\Views\Home\Members.cshtml"
  
    ViewData["Title"] = "Members Only";

#line default
#line hidden
            BeginContext(50, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(55, 13, false);
#line 5 "C:\Users\S533569\Harshitha_Chetty_Ragava\44663\WebAuthentication\WebAuthentication\Views\Home\Members.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(68, 137, true);
            WriteLiteral("</h2>\r\n\r\n<h6>Harshitha Chetty Ragava</h6>\r\n<h6>Zaiba Ali</h6>\r\n<h6>Vamshi Krishna Nuka</h6>\r\n\r\n<p>You must be a member. Congratulations, ");
            EndContext();
            BeginContext(206, 18, false);
#line 11 "C:\Users\S533569\Harshitha_Chetty_Ragava\44663\WebAuthentication\WebAuthentication\Views\Home\Members.cshtml"
                                     Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(224, 29, true);
            WriteLiteral(", on your membership!</p>\r\n\r\n");
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
