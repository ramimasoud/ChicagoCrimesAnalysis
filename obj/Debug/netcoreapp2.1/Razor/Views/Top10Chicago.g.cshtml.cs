#pragma checksum "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ee915241049687359fa78d7a00a2dd89ec2dd95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(crimes.Pages.Views_Top10Chicago), @"mvc.1.0.razor-page", @"/Views/Top10Chicago.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/Top10Chicago.cshtml", typeof(crimes.Pages.Views_Top10Chicago), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ee915241049687359fa78d7a00a2dd89ec2dd95", @"/Views/Top10Chicago.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f842f8255da31aa43ed40deaf7f18adbc89934f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Top10Chicago : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml"
  
  ViewData["Title"] = "Top-10 Crimes for The City of Chicago.";

#line default
#line hidden
            BeginContext(104, 39, true);
            WriteLiteral("\n<h2>Top-10 Crimes for Chicago</h2>  \n\n");
            EndContext();
#line 9 "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
            BeginContext(176, 37, true);
            WriteLiteral("\t   <br />\n\t\t <br />\n\t\t <h3>**ERROR: ");
            EndContext();
            BeginContext(214, 16, false);
#line 14 "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
            EndContext();
            BeginContext(230, 46, true);
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
            EndContext();
#line 19 "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml"
	 }

#line default
#line hidden
            BeginContext(282, 589, true);
            WriteLiteral(@"
<table class=""table"">  
    <thead>  
        <tr>  
            <th>  
                Rank
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
            <th>  
                Percent of Total Crimes
            </th>  
            <th>  
                Percent of Arrests
            </th>  
        </tr>  
    </thead>  
    <tbody>  
");
            EndContext();
#line 49 "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml"
                  
				   int rank = 1;
				 

#line default
#line hidden
            BeginContext(906, 5, true);
            WriteLiteral("\t\t\t\t\n");
            EndContext();
#line 53 "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml"
         foreach (var item in Model.CrimeList)  
        {  

#line default
#line hidden
            BeginContext(972, 47, true);
            WriteLiteral("            <tr>  \n                <td>  \n\t\t\t\t\t");
            EndContext();
            BeginContext(1020, 4, false);
#line 57 "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml"
               Write(rank);

#line default
#line hidden
            EndContext();
            BeginContext(1024, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1093, 9, false);
#line 60 "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml"
               Write(item.IUCR);

#line default
#line hidden
            EndContext();
            BeginContext(1102, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1171, 16, false);
#line 63 "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml"
               Write(item.PrimaryDesc);

#line default
#line hidden
            EndContext();
            BeginContext(1187, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1256, 18, false);
#line 66 "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml"
               Write(item.SecondaryDesc);

#line default
#line hidden
            EndContext();
            BeginContext(1274, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1343, 13, false);
#line 69 "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml"
               Write(item.NumCrime);

#line default
#line hidden
            EndContext();
            BeginContext(1356, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1426, 65, false);
#line 72 "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml"
                Write((((@item.NumCrime) / (@item.TotalCrimes)) * 100).ToString("0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1562, 67, false);
#line 75 "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml"
                Write((((@item.ArrestedCount) / (@item.NumCrime)) * 100).ToString("0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(1630, 45, true);
            WriteLiteral("\n                </td>  \n            </tr>  \n");
            EndContext();
#line 78 "/home/codio/workspace/crimes/Views/Top10Chicago.cshtml"
						
					rank++;
        }  

#line default
#line hidden
            BeginContext(1707, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopCrimesChicagoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopCrimesChicagoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopCrimesChicagoModel>)PageContext?.ViewData;
        public TopCrimesChicagoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
