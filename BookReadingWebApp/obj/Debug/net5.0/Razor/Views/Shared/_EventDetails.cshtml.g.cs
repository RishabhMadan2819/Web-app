#pragma checksum "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Shared\_EventDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "284a51c2ef99fd925d69b7c5d8d79575f625db55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EventDetails), @"mvc.1.0.view", @"/Views/Shared/_EventDetails.cshtml")]
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
#line 2 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Shared\_EventDetails.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"284a51c2ef99fd925d69b7c5d8d79575f625db55", @"/Views/Shared/_EventDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ec7b176f075837e9c55f547458337b5e6e0ced2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__EventDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookReadingApp.Core.Modals.Event>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Shared\_EventDetails.cshtml"
  
    var user = await _userManager.GetUserAsync(User);
    var email = "";
    if (user != null)
    {
        email = user.Email;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-4\">\r\n    <div class=\"card mb-4\" style=\"width:20rem;\">\r\n        <div class=\"card-body\">\r\n            <div class=\"card-title\">\r\n                <h4>");
#nullable restore
#line 19 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Shared\_EventDetails.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n\r\n            <div>\r\n                <p class=\"text-dark d-inline\">Location :</p>");
#nullable restore
#line 23 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Shared\_EventDetails.cshtml"
                                                       Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <p class=\"text-dark d-inline\">Date :</p>");
#nullable restore
#line 26 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Shared\_EventDetails.cshtml"
                                                   Write(Model.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <p class=\"text-dark d-inline\">Start Time :</p>");
#nullable restore
#line 29 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Shared\_EventDetails.cshtml"
                                                         Write(Model.StartTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n\r\n            <div class=\"btn-group\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "284a51c2ef99fd925d69b7c5d8d79575f625db557112", async() => {
                WriteLiteral(" View Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Shared\_EventDetails.cshtml"
                                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n");
#nullable restore
#line 36 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Shared\_EventDetails.cshtml"
             if (_signInManager.IsSignedIn(User) && (User.Identity.Name == Model.Organiser || email == "myadmin@bookevents.com") && Model.Date >= DateTime.Now)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"btn-group\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "284a51c2ef99fd925d69b7c5d8d79575f625db5510143", async() => {
                WriteLiteral("Update Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Shared\_EventDetails.cshtml"
                                                                         WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 41 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Shared\_EventDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"co-md-6\">\r\n                    <p class=\"text-danger\"> ");
#nullable restore
#line 45 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Shared\_EventDetails.cshtml"
                                       Write(Model.EventType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Event</p>\r\n                </div>\r\n                <div class=\"col-md-6 text-danger\"> Organised By <b>");
#nullable restore
#line 47 "C:\Users\rishabhmadan\OneDrive - Nagarro\Desktop\online 4\BookReadingWebApp\BookReadingWebApp\Views\Shared\_EventDetails.cshtml"
                                                              Write(Model.Organiser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> _userManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> _signInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookReadingApp.Core.Modals.Event> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
