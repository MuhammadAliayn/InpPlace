#pragma checksum "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\Assets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2beaa5f4050619ff60e9cb0ccb4b425f8cc0962"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assets), @"mvc.1.0.view", @"/Views/Assets.cshtml")]
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
#line 1 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\Assets.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2beaa5f4050619ff60e9cb0ccb4b425f8cc0962", @"/Views/Assets.cshtml")]
    public class Views_Assets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataSet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-lg-12"">
    <div class=""card"">
        <div class=""card-body"">
            <div class=""table-responsive"" id=""dvAssets"">
                <table class=""table table-bordered table-striped verticle-middle table-responsive-sm"">
                    <thead>
                        <tr>
");
#nullable restore
#line 11 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\Assets.cshtml"
                             foreach (System.Data.DataColumn col in Model.Tables[0].Columns)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th>");
#nullable restore
#line 13 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\Assets.cshtml"
                               Write(col.Caption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 14 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\Assets.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 18 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\Assets.cshtml"
                         foreach (System.Data.DataRow dr in Model.Tables[0].Rows)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n");
#nullable restore
#line 21 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\Assets.cshtml"
                                 foreach (System.Data.DataColumn col in Model.Tables[0].Columns)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 23 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\Assets.cshtml"
                                   Write(dr[col.ColumnName].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 24 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\Assets.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 26 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\Assets.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataSet> Html { get; private set; }
    }
}
#pragma warning restore 1591
