#pragma checksum "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Comment\ViewComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab0af175c8885faf3db08b040d5409ce48b010f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_ViewComment), @"mvc.1.0.view", @"/Views/Comment/ViewComment.cshtml")]
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
#line 1 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\_ViewImports.cshtml"
using BookReadingWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\_ViewImports.cshtml"
using BookReadingApp.Core.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab0af175c8885faf3db08b040d5409ce48b010f5", @"/Views/Comment/ViewComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ec7b176f075837e9c55f547458337b5e6e0ced2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Comment_ViewComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookReadingApp.Core.Modals.Comment>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Comment\ViewComment.cshtml"
  
    ViewData["Title"] = "ViewComment";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <hr />\r\n\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Comment\ViewComment.cshtml"
       Write(Html.DisplayNameFor(model => model.comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Comment\ViewComment.cshtml"
       Write(Html.DisplayFor(model => model.comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Comment\ViewComment.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Comment\ViewComment.cshtml"
       Write(Html.DisplayFor(model => model.TimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookReadingApp.Core.Modals.Comment> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591