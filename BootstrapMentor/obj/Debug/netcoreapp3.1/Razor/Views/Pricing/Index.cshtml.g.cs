#pragma checksum "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\Pricing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e1c5dffa5da7b0b89f1ed460f180f74733f8d0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pricing_Index), @"mvc.1.0.view", @"/Views/Pricing/Index.cshtml")]
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
#line 2 "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\_ViewImports.cshtml"
using BootstrapMentor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\_ViewImports.cshtml"
using BootstrapMentor.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e1c5dffa5da7b0b89f1ed460f180f74733f8d0b", @"/Views/Pricing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50b82024099c7e917063febf37a95107ecb7cdc4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pricing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlanFeatureViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\Pricing\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main id=""main"">
    <!-- ======= Breadcrumbs ======= -->
    <div class=""breadcrumbs"" data-aos=""fade-in"">
        <div class=""container"">
            <h2>Pricing</h2>
            <p>Est dolorum ut non facere possimus quibusdam eligendi voluptatem. Quia id aut similique quia voluptas sit quaerat debitis. Rerum omnis ipsam aperiam consequatur laboriosam nemo harum praesentium. </p>
        </div>
    </div><!-- End Breadcrumbs -->
    <!-- ======= Pricing Section ======= -->
    <section id=""pricing"" class=""pricing"">
        <div class=""container"" data-aos=""fade-up"">

            <div class=""row"">

");
#nullable restore
#line 22 "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\Pricing\Index.cshtml"
                 foreach (Plan plan in Model.Plans)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 815, "\"", 886, 5);
            WriteAttributeValue("", 823, "col-lg-3", 823, 8, true);
            WriteAttributeValue(" ", 831, "col-md-6", 832, 9, true);
            WriteAttributeValue(" ", 840, "mt-4", 841, 5, true);
            WriteAttributeValue(" ", 845, "mt-lg-0", 846, 8, true);
#nullable restore
#line 24 "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\Pricing\Index.cshtml"
WriteAttributeValue(" ", 853, plan.IsFeatured?"featured":"", 854, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <div class=\"box\">\n                            <span");
            BeginWriteAttribute("class", " class=\"", 964, "\"", 1010, 1);
#nullable restore
#line 26 "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\Pricing\Index.cshtml"
WriteAttributeValue("", 972, plan.IsAdvanced?"advanced":"d-none", 972, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Advanced</span>\n                            <h3>");
#nullable restore
#line 27 "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\Pricing\Index.cshtml"
                           Write(plan.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            <h4><sup>$</sup>");
#nullable restore
#line 28 "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\Pricing\Index.cshtml"
                                       Write(plan.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> / month</span></h4>\n                            <ul>\n");
#nullable restore
#line 30 "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\Pricing\Index.cshtml"
                                 foreach (FeatureItem feature in Model.FeatureItems)
                                {
                                    if (plan.PlanFeatures.Exists(p => p.FeatureItems.Id == feature.Id))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>");
#nullable restore
#line 34 "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\Pricing\Index.cshtml"
                                       Write(feature.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 35 "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\Pricing\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"na\"><i class=\"na\"></i> <span>");
#nullable restore
#line 38 "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\Pricing\Index.cshtml"
                                                                           Write(feature.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n");
#nullable restore
#line 39 "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\Pricing\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </ul>\n                            <div class=\"btn-wrap\">\n                                <a href=\"#\" class=\"btn-buy\">Buy Now</a>\n                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 48 "C:\Users\Onur\OneDrive\Masaüstü\BootstrapMentor-master\BootstrapMentor\Views\Pricing\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n\n        </div>\n    </section><!-- End Pricing Section -->\n\n</main><!-- End #main -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlanFeatureViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591