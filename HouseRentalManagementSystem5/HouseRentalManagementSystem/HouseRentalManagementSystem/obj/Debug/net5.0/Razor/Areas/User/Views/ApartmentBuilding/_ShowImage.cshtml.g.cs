#pragma checksum "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\ApartmentBuilding\_ShowImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94f523184d5399b25d995eec4d06fc36a3fa5cc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_ApartmentBuilding__ShowImage), @"mvc.1.0.view", @"/Areas/User/Views/ApartmentBuilding/_ShowImage.cshtml")]
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
#line 1 "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\_ViewImports.cshtml"
using HouseRentalManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\_ViewImports.cshtml"
using HouseRentalManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\_ViewImports.cshtml"
using HouseRentalManagementSystem.UserViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\_ViewImports.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f523184d5399b25d995eec4d06fc36a3fa5cc3", @"/Areas/User/Views/ApartmentBuilding/_ShowImage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42bb347e0d9e320667f64af44f4ad16dc9108501", @"/Areas/User/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_User_Views_ApartmentBuilding__ShowImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""form-group mb-3"">
    <label class=""form-label mb-3"">Building Photo</label>
    <img ng-src=""/images/building_images/{{clickedBuilding.ImageName}}"" style=""width:100%!important; height:auto!important;"" class=""form-control changeEdit mb-3"" asp-append-version=""true"" />
</div>
<div class=""form-group mb-3"">
    <input type=""button"" value=""Close"" data-bs-dismiss=""modal"" class=""btn btn_modal_close"" />
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
