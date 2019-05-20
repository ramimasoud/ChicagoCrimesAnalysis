#pragma checksum "/home/codio/workspace/crimes/Views/CrimeCodesGuide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdfbd2e89992499a18f41dd2ffd4f15fa7df0846"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(crimes.Pages.Views_CrimeCodesGuide), @"mvc.1.0.razor-page", @"/Views/CrimeCodesGuide.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/CrimeCodesGuide.cshtml", typeof(crimes.Pages.Views_CrimeCodesGuide), null)]
namespace crimes.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/codio/workspace/crimes/Views/_ViewImports.cshtml"
using crimes;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdfbd2e89992499a18f41dd2ffd4f15fa7df0846", @"/Views/CrimeCodesGuide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f842f8255da31aa43ed40deaf7f18adbc89934f4", @"/Views/_ViewImports.cshtml")]
    public class Views_CrimeCodesGuide : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/codio/workspace/crimes/Views/CrimeCodesGuide.cshtml"
  
  ViewData["Title"] = "Crime Codes Description Guide";

#line default
#line hidden
            BeginContext(94, 81, true);
            WriteLiteral("\n<h2>Here you can view a list of all crime codes and their descriptions.</h2>  \n\n");
            EndContext();
#line 9 "/home/codio/workspace/crimes/Views/CrimeCodesGuide.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
            BeginContext(208, 37, true);
            WriteLiteral("\t   <br />\n\t\t <br />\n\t\t <h3>**ERROR: ");
            EndContext();
            BeginContext(246, 16, false);
#line 14 "/home/codio/workspace/crimes/Views/CrimeCodesGuide.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
            EndContext();
            BeginContext(262, 46, true);
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
            EndContext();
#line 19 "/home/codio/workspace/crimes/Views/CrimeCodesGuide.cshtml"
	 }

#line default
#line hidden
            BeginContext(314, 433, true);
            WriteLiteral(@"
<table class=""table"">  
    <thead>  
        <tr>  
            <th>  
                #
            </th>  
            <th>  
                IUCR
            </th>  
            <th>  
                Primary Description
            </th>  
            <th>  
                Secondary Description
            </th>  
            <th>
                Occurrences
            </th>  
        </tr>  
    </thead>  
    <tbody>  
");
            EndContext();
#line 43 "/home/codio/workspace/crimes/Views/CrimeCodesGuide.cshtml"
                  
				   int rank = 1;
				 

#line default
#line hidden
            BeginContext(782, 18, true);
            WriteLiteral("                \t\n");
            EndContext();
#line 47 "/home/codio/workspace/crimes/Views/CrimeCodesGuide.cshtml"
         foreach (var item in Model.CrimeCodeList)  
        {  

#line default
#line hidden
            BeginContext(865, 47, true);
            WriteLiteral("            <tr>  \n                <td>  \n\t\t\t\t\t");
            EndContext();
            BeginContext(913, 4, false);
#line 51 "/home/codio/workspace/crimes/Views/CrimeCodesGuide.cshtml"
               Write(rank);

#line default
#line hidden
            EndContext();
            BeginContext(917, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(986, 9, false);
#line 54 "/home/codio/workspace/crimes/Views/CrimeCodesGuide.cshtml"
               Write(item.IUCR);

#line default
#line hidden
            EndContext();
            BeginContext(995, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1064, 16, false);
#line 57 "/home/codio/workspace/crimes/Views/CrimeCodesGuide.cshtml"
               Write(item.PrimaryDesc);

#line default
#line hidden
            EndContext();
            BeginContext(1080, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1149, 18, false);
#line 60 "/home/codio/workspace/crimes/Views/CrimeCodesGuide.cshtml"
               Write(item.SecondaryDesc);

#line default
#line hidden
            EndContext();
            BeginContext(1167, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1236, 13, false);
#line 63 "/home/codio/workspace/crimes/Views/CrimeCodesGuide.cshtml"
               Write(item.NumCrime);

#line default
#line hidden
            EndContext();
            BeginContext(1249, 45, true);
            WriteLiteral("\n                </td>  \n            </tr>  \n");
            EndContext();
#line 66 "/home/codio/workspace/crimes/Views/CrimeCodesGuide.cshtml"
						
					rank++;
        }  

#line default
#line hidden
            BeginContext(1326, 24, true);
            WriteLiteral("    </tbody>  \n</table> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrimeCodesGuideModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CrimeCodesGuideModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CrimeCodesGuideModel>)PageContext?.ViewData;
        public CrimeCodesGuideModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
