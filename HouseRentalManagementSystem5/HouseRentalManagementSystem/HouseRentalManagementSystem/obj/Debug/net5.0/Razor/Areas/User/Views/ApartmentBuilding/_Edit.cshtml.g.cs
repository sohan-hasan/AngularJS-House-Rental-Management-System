#pragma checksum "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\ApartmentBuilding\_Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b742a040525b167ebe5d0c422e6e2ea4218d76d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_ApartmentBuilding__Edit), @"mvc.1.0.view", @"/Areas/User/Views/ApartmentBuilding/_Edit.cshtml")]
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
#line 1 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\_ViewImports.cshtml"
using HouseRentalManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\_ViewImports.cshtml"
using HouseRentalManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\_ViewImports.cshtml"
using HouseRentalManagementSystem.UserViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\_ViewImports.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b742a040525b167ebe5d0c422e6e2ea4218d76d", @"/Areas/User/Views/ApartmentBuilding/_Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42bb347e0d9e320667f64af44f4ad16dc9108501", @"/Areas/User/_ViewImports.cshtml")]
    public class Areas_User_Views_ApartmentBuilding__Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Custom/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12 mx-auto\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b742a040525b167ebe5d0c422e6e2ea4218d76d5634", async() => {
                WriteLiteral(@"
            <input type=""hidden"" ng-model=""clickedBuilding.BuildingId"" />
            <input type=""hidden"" ng-model=""clickedBuilding.ImageName"" />
            <div class=""form-group mb-3"">
                <label class=""form-label"">Building Short Name</label>
                <input ng-model=""clickedBuilding.BuildingShortName"" class=""form-control"" />
            </div>
            <div class=""form-group mb-3"">
                <label class=""form-label"">Building Full Name</label>
                <input ng-model=""clickedBuilding.BuildingFullName"" class=""form-control"" />
            </div>
            <div class=""form-group position-relative mb-3"">
                <label class=""form-label"">Building Description</label>
                <textarea ng-model=""clickedBuilding.BuildingDescription"" class=""form-control"" text-wrap:normal"" type=""text"" placeholder=""Write here (Optional)""></textarea>
            </div>
            <div class=""form-group mb-3"">
                <label class=""form-label"">Building A");
                WriteLiteral(@"ddress</label>
                <input ng-model=""clickedBuilding.BuildingAddress"" class=""form-control"" />
            </div>
            <div class=""form-group mb-3"">
                <label class=""form-label"">Building Manager</label>
                <input ng-model=""clickedBuilding.BuildingManager"" class=""form-control"" />
            </div>
            <div class=""form-group mb-3"">
                <label class=""form-label"">Building Phone</label>
                <input ng-model=""clickedBuilding.BuildingPhone"" class=""form-control"" />
            </div>
            <div class=""form-group mb-3"">
                <label class=""form-label"">Other Building Details</label>
                <textarea ng-model=""clickedBuilding.OtherBuildingDetails"" class=""form-control"" text-wrap:normal"" type=""text"" placeholder=""Write here (Optional)""></textarea>
            </div>
            <div class=""form-group mb-3"">
                <label class=""form-label mb-3"">Building Photo</label>
                <img ng-src=""/im");
                WriteLiteral(@"ages/building_images/{{clickedBuilding.ImageName}}"" style=""height:90px!important; width:auto!important;"" class=""form-control change_edit mb-3"" asp-append-version=""true""/>
                <input class=""form-control change_image"" type=""file"" ngf-select=""UploadFiles($files)"" />
            </div>
            <div class=""form-group mb-3"">
                <input type=""submit"" value=""Update"" class=""btn btn_modal"" data-bs-dismiss=""modal"" ng-click=""UpdateBuilding()"" />
                <input type=""button"" value=""Close"" data-bs-dismiss=""modal"" class=""btn btn_modal_close"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b742a040525b167ebe5d0c422e6e2ea4218d76d9807", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
