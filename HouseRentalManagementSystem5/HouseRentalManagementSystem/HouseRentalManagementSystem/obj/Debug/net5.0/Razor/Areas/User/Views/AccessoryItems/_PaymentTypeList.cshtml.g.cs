#pragma checksum "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\AccessoryItems\_PaymentTypeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "507a02561d0380502f59a3f3a191ccbf4812d17d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_AccessoryItems__PaymentTypeList), @"mvc.1.0.view", @"/Areas/User/Views/AccessoryItems/_PaymentTypeList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"507a02561d0380502f59a3f3a191ccbf4812d17d", @"/Areas/User/Views/AccessoryItems/_PaymentTypeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42bb347e0d9e320667f64af44f4ad16dc9108501", @"/Areas/User/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_User_Views_AccessoryItems__PaymentTypeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AccessoryItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PaymentTypeDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure to delete?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div>
    <table class=""table table-bordered table-striped list_table"">
        <thead>
            <tr>
                <th class=""text-center"">
                    ###
                </th>
                <th>
                    Payment Type
                </th>
                <th class=""text-center tbl_action"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 16 "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\AccessoryItems\_PaymentTypeList.cshtml"
             foreach (var item in Model.PaymentTypeViewModel)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 20 "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\AccessoryItems\_PaymentTypeList.cshtml"
                   Write(item.SirialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 23 "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\AccessoryItems\_PaymentTypeList.cshtml"
                   Write(item.PaymentTypeDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td class=""text-center"">
                        <div class=""btn-group"">
                            <div class=""dropdown"">
                                <a class=""btn_table dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                    Action
                                </a>
                                <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuLink"">
                                    <li><a class=""dropdown-item""");
            BeginWriteAttribute("onclick", " onclick=\'", 1285, "\'", 1333, 3);
            WriteAttributeValue("", 1295, "PaymentTypeUpdate(", 1295, 18, true);
#nullable restore
#line 32 "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\AccessoryItems\_PaymentTypeList.cshtml"
WriteAttributeValue("", 1313, item.PaymentTypeId, 1313, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1332, ")", 1332, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"modal\" data-bs-target=\"#PaymentTypeEditModal\">Edit</a></li>\r\n                                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "507a02561d0380502f59a3f3a191ccbf4812d17d9420", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\AccessoryItems\_PaymentTypeList.cshtml"
                                                                                                                                                  WriteLiteral(item.PaymentTypeId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\AccessoryItems\_PaymentTypeList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div>\r\n    <div class=\"page_section\">\r\n        ");
#nullable restore
#line 45 "F:\Repository\AngularJS-House-Rental-Management-System\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\AccessoryItems\_PaymentTypeList.cshtml"
   Write(Html.PagedListPager((IPagedList)Model.ApartmentTypeViewModel, paymentTypePage => Url.Action("Index", new { paymentTypePage = paymentTypePage }),
    new X.PagedList.Web.Common.PagedListRenderOptions
    {
        ContainerDivClasses = new[] { "navication" },
        LiElementClasses = new[] { "page-item" },
        PageClasses = new[] { "page-link" },
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
