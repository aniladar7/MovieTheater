#pragma checksum "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b33ff0aba6041e09a1aaa16e4bb4b876f6c59505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Movie_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\_ViewImports.cshtml"
using NetCoreMovieTheater;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\_ViewImports.cshtml"
using NetCoreMovieTheater.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\_ViewImports.cshtml"
using NetCoreMovieTheater.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\_ViewImports.cshtml"
using NetCoreMovieTheater.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33ff0aba6041e09a1aaa16e4bb4b876f6c59505", @"/Areas/Admin/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06ca95f762243cd89303b2b5f90e8687afc786bc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\Movie\Index.cshtml"
   ViewData["Title"] = "Index";
                Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Movie Name</th>
                    <th>Description</th>
                    <th>Güncelle/Sil</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 17 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\Movie\Index.cshtml"
                 foreach (var movie in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 20 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\Movie\Index.cshtml"
                       Write(movie.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 21 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\Movie\Index.cshtml"
                       Write(movie.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 23 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\Movie\Index.cshtml"
                       Write(Html.ActionLink("Remove", "RemoveMovie", new { Id = movie.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 24 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\Movie\Index.cshtml"
                       Write(Html.ActionLink("Update", "UpdateMovie", new { Id = movie.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 28 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\Movie\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591