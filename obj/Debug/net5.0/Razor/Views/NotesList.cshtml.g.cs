#pragma checksum "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\NotesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d381dc5bdd804dbfae3609d9a1d14c2beec84bae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NotesList), @"mvc.1.0.view", @"/Views/NotesList.cshtml")]
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
#line 1 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\NotesList.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d381dc5bdd804dbfae3609d9a1d14c2beec84bae", @"/Views/NotesList.cshtml")]
    public class Views_NotesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataSet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"card\" id=\"dvNotes\" style=\"margin-top: -14px;\">\r\n\r\n    <div class=\"card-body\" style=\"overflow-x: hidden;\">\r\n");
#nullable restore
#line 18 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\NotesList.cshtml"
             foreach (DataRow row in Model.Tables[0].Rows)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\" style=\"background: #e7e6e585;padding-left: 30px;height: 30px;font-size: 12px;line-height: 27px;font-weight: 700;\">\r\n                    <div class=\"col-xl-6\">");
#nullable restore
#line 21 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\NotesList.cshtml"
                                      Write(row["id_utente"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-xl-6\">");
#nullable restore
#line 22 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\NotesList.cshtml"
                                      Write(row["data_inserimento"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"row\" style=\"height: 60px;padding-left: 30px;height:auto !important;font-size: 12px \">\r\n                    <div class=\"col-xl-12\">\r\n                        ");
#nullable restore
#line 26 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\NotesList.cshtml"
                    Write(row["Nota"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 29 "E:\InplaceNewProject\InPlace415032021\InPlace4\Views\NotesList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
