#pragma checksum "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\Shared\_SideNavbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4271e6609f7001ad34fe0b10e4db8125d647c7bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__SideNavbar), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_SideNavbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4271e6609f7001ad34fe0b10e4db8125d647c7bb", @"/Areas/Admin/Views/Shared/_SideNavbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06ca95f762243cd89303b2b5f90e8687afc786bc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__SideNavbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <nav class=""sb-sidenav accordion sb-sidenav-dark"" id=""sidenavAccordion"">
        <div class=""sb-sidenav-menu"">
            <div class=""nav"">
                <div class=""sb-sidenav-menu-heading"">Core</div>
               
                <div class=""sb-nav-link-icon nav-link"">
                    <i class=""fas fa-tachometer-alt""> </i>
                    &nbsp;&nbsp; ");
#nullable restore
#line 8 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\Shared\_SideNavbar.cshtml"
                            Write(Html.ActionLink("Dashboard", "Index", "Home", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            
                <div class=""sb-sidenav-menu-heading"">Interface</div>
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseLayouts"" aria-expanded=""false"" aria-controls=""collapseLayouts"">
                    <div class=""sb-nav-link-icon""><i class=""fas fa-columns""></i></div>
                    Movies Crud
                    <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                </a>
                <div class=""collapse"" id=""collapseLayouts"" aria-labelledby=""headingOne"" data-parent=""#sidenavAccordion"">
                    <nav class=""sb-sidenav-menu-nested nav"">
                        ");
#nullable restore
#line 19 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\Shared\_SideNavbar.cshtml"
                   Write(Html.ActionLink("Index", "Index", "Movie",null,new { @class= "nav-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 20 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\Shared\_SideNavbar.cshtml"
                   Write(Html.ActionLink("Add Movie", "AddMovie", "Movie", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </nav>
                </div>
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages"" aria-expanded=""false"" aria-controls=""collapsePages"">
                    <div class=""sb-nav-link-icon""><i class=""as fa-columns""></i></div>
                    Category
                    <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                </a>
                <div class=""collapse"" id=""collapsePages"" aria-labelledby=""headingTwo"" data-parent=""#sidenavAccordion"">
                    <nav class=""sb-sidenav-menu-nested nav"">
                        ");
#nullable restore
#line 30 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\Shared\_SideNavbar.cshtml"
                   Write(Html.ActionLink("Index", "Index", "Genre", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 31 "C:\Users\anil.adar\Desktop\Story\NetCoreMovieTheater\NetCoreMovieTheater\Areas\Admin\Views\Shared\_SideNavbar.cshtml"
                   Write(Html.ActionLink("Add Category", "AddGenre", "Genre", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </nav>
                </div>                
            </div>
        </div>
        <div class=""sb-sidenav-footer"">
            <div class=""small"">Logged in as:</div>
            Login Yapan Admının Adı Yazılacak
        </div>
    </nav>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
