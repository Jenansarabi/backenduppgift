#pragma checksum "C:\Users\sarab\Desktop\backend1\BE1\Backend1\AspNetMvc\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac0c37936162a3e86438f7aecd5b301b83d8fb17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "C:\Users\sarab\Desktop\backend1\BE1\Backend1\AspNetMvc\Views\_ViewImports.cshtml"
using AspNetMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sarab\Desktop\backend1\BE1\Backend1\AspNetMvc\Views\_ViewImports.cshtml"
using AspNetMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac0c37936162a3e86438f7aecd5b301b83d8fb17", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd7a5b26f4f85a266f389e0570f5da29cd2cb830", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetMvc.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sarab\Desktop\backend1\BE1\Backend1\AspNetMvc\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card-columns row-cols-1 row-cols-md-4 g-4 mb-5\">\r\n    <div class=\"card \">\r\n        <div class=\"card-body h-50 \">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\sarab\Desktop\backend1\BE1\Backend1\AspNetMvc\Views\Products\Details.cshtml"
                              Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n\r\n            <p class=\"mb-1 text-muted\"><small>");
#nullable restore
#line 14 "C:\Users\sarab\Desktop\backend1\BE1\Backend1\AspNetMvc\Views\Products\Details.cshtml"
                                         Write(Html.DisplayFor(model => model.SubCategory.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 14 "C:\Users\sarab\Desktop\backend1\BE1\Backend1\AspNetMvc\Views\Products\Details.cshtml"
                                                                                                     Write(Html.DisplayFor(model => model.SubCategory.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 476, "\"", 523, 1);
#nullable restore
#line 15 "C:\Users\sarab\Desktop\backend1\BE1\Backend1\AspNetMvc\Views\Products\Details.cshtml"
WriteAttributeValue("", 482, Html.DisplayFor(model => model.ImageUrl), 482, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 545, "\"", 551, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n            <p class=\"card-text my-1\">");
#nullable restore
#line 18 "C:\Users\sarab\Desktop\backend1\BE1\Backend1\AspNetMvc\Views\Products\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n            <div class=\"d-flex justify-content-between align-items-end\">\r\n                <p class=\"text-danger price pt-2\">");
#nullable restore
#line 22 "C:\Users\sarab\Desktop\backend1\BE1\Backend1\AspNetMvc\Views\Products\Details.cshtml"
                                             Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@":-</p>
                <button class=""btn btn-outline-secondary"">
                    <i class=""fas fa-shopping-cart me-2""></i>
                    Add to Cart
                </button>


            </div>
        </div>
        <div class=""card-footer d-flex justify-content-between align-items-end"">

            <small class=""text-muted""><i class=""fas fa-box text-success me-2""></i> Storestatus</small>


        </div>

    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetMvc.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
