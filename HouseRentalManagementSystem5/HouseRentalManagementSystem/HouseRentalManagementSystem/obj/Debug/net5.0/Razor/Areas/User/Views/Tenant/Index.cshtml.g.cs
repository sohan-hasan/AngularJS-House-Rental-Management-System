#pragma checksum "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93efdbef2a3f59c9153862355c2995670e6d7624"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Tenant_Index), @"mvc.1.0.view", @"/Areas/User/Views/Tenant/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93efdbef2a3f59c9153862355c2995670e6d7624", @"/Areas/User/Views/Tenant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42bb347e0d9e320667f64af44f4ad16dc9108501", @"/Areas/User/_ViewImports.cshtml")]
    public class Areas_User_Views_Tenant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TenantViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tenant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure to delete?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_back_to_list"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Areas/User/Views/Tenant/_Edit.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Areas/User/Views/Tenant/_Details.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Areas/User/Views/Tenant/_ViewImages.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <div class=""pl-0"">
        <div><span class=""page_header"">Tenant</span></div>
        <div style=""padding-left:0"">
            <button type=""button"" class=""btn_add_new"" data-bs-toggle=""modal"" data-bs-target=""#CreateModal"">Create New</button>
        </div>
    </div>
    <table class=""table table-bordered table-striped list_table"">
        <thead>
            <tr>
                <th class=""text-center"">
                    ");
#nullable restore
#line 17 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
               Write(Html.ActionLink("###", "Index", new { SortOrder = ViewBag.SortNameParam }, new { @class = "text-decoration-none text-white" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </th>
                <th>
                    Tenant Name
                </th>
                <th>
                    Phone Number
                </th>
                <th>
                    Email Address
                </th>
                <th class=""text-center"">
                    Date Of Birth
                </th>
                <th class=""text-center"">
                    Gender
                </th>
                <th class=""tbl_large_field"">
                    Tenant Details
                </th>
                <th class=""text-center"">
                    Tenant Image
                </th>
                <th class=""text-center tbl_action"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 44 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 48 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
                   Write(item.SirialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 51 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
                   Write(item.TenantFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
                   Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 57 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 60 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
                   Write(item.DateOfBirth.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 63 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
                   Write(item.GenderProperty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"tbl_large_field\">\r\n                        ");
#nullable restore
#line 66 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
                   Write(item.OtherTenantDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        <a class=\"btn_view_images\"");
            BeginWriteAttribute("onclick", " onclick=\'", 2432, "\'", 2467, 3);
            WriteAttributeValue("", 2442, "ShowImage(", 2442, 10, true);
#nullable restore
#line 69 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
WriteAttributeValue("", 2452, item.TenantId, 2452, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2466, ")", 2466, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-toggle=""modal"" data-bs-target=""#ViewImagesModal"">View&nbsp;Images</a>
                    </td>
                    <td class=""text-center"">
                        <div class=""btn-group"">
                            <div class=""dropdown"">
                                <a class=""btn_table dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                    Action
                                </a>
                                <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuLink"">
                                    <li><a class=""dropdown-item""");
            BeginWriteAttribute("onclick", " onclick=\'", 3127, "\'", 3159, 3);
            WriteAttributeValue("", 3137, "Update(", 3137, 7, true);
#nullable restore
#line 78 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
WriteAttributeValue("", 3144, item.TenantId, 3144, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3158, ")", 3158, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"modal\" data-bs-target=\"#EditModal\">Edit</a></li>\r\n                                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93efdbef2a3f59c9153862355c2995670e6d762415941", async() => {
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
#line 79 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
                                                                                                                               WriteLiteral(item.TenantId);

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
            WriteLiteral("</li>\r\n                                    <li><a class=\"dropdown-item\"");
            BeginWriteAttribute("onclick", " onclick=\'", 3515, "\'", 3548, 3);
            WriteAttributeValue("", 3525, "Details(", 3525, 8, true);
#nullable restore
#line 80 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
WriteAttributeValue("", 3533, item.TenantId, 3533, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3547, ")", 3547, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"modal\" data-bs-target=\"#DetailsModal\">Details</a></li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 86 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div>\r\n    <div class=\"search_section\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93efdbef2a3f59c9153862355c2995670e6d762420146", async() => {
                WriteLiteral("\r\n            <div>\r\n                <span class=\"search_title\">Find By Tenant Name: </span>\r\n                <input type=\"text\" class=\"input_search\" name=\"SearchString\"");
                BeginWriteAttribute("value", " value=\"", 4090, "\"", 4120, 1);
#nullable restore
#line 95 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
WriteAttributeValue("", 4098, ViewBag.CurrentFilter, 4098, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"submit\" value=\"Search\" class=\"btn_search\" />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93efdbef2a3f59c9153862355c2995670e6d762421163", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"page_section\">\r\n        ");
#nullable restore
#line 102 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
   Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page = page }),
    new X.PagedList.Web.Common.PagedListRenderOptions
    {
        ContainerDivClasses = new[] { "navication" },
        LiElementClasses = new[] { "page-item" },
        PageClasses = new[] { "page-link" },
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>
<div class=""modal fade"" id=""CreateModal"" tabindex=""-1"" aria-labelledby=""CreateModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header px-md-5"">
                <h3 class=""modal-title"" id=""detailsModalLabel"">Create Apartment</h3>
                <button type=""button"" class=""btn-close btn-close-white"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body px-md-5"">
                ");
#nullable restore
#line 119 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
           Write(await Html.PartialAsync("_Create", new TenantViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""EditModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header px-md-5"">
                <h3 class=""modal-title"" id=""detailsModalLabel"">Update Tenant</h3>
                <button type=""button"" class=""btn-close btn-close-white"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body px-md-5"">
                <div id=""EditDiv"">
");
#nullable restore
#line 133 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
                     if (ViewBag.Details == "Show")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "93efdbef2a3f59c9153862355c2995670e6d762426479", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 136 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
                        ViewBag.Details = "";
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""DetailsModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header px-md-5 ba"">
                <h3 class=""modal-title"" id=""detailsModalLabel"">Tenant Details</h3>
                <button type=""button"" class=""btn-close btn-close-white"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body px-md-5"">
                <div id=""DetailsDiv"">
");
#nullable restore
#line 152 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
                     if (ViewBag.Details == "Show")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "93efdbef2a3f59c9153862355c2995670e6d762428985", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 155 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
                        ViewBag.Details = "";
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""ViewImagesModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header px-md-5 ba"">
                <button type=""button"" class=""btn-close btn-close-white"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body px-md-5"">
                <div id=""ViewImagesDiv"">
");
#nullable restore
#line 170 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
                     if (ViewBag.ViewImages == "Show")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "93efdbef2a3f59c9153862355c2995670e6d762431412", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 173 "F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\Areas\User\Views\Tenant\Index.cshtml"
                        ViewBag.ViewImages = "";
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<script>
    function Update(id) {
        $.ajax({
            url: ""/User/Tenant/Edit?id="" + id,
            type: ""GET"",
            data: """",
            contentType: 'application/json; charset = utf-8',
            success: function (data) {
                $('#EditDiv').show();
                $('#EditDiv').html(data);
            },
            error: function () {
                alert(""Error occured"")
            }
        })
    }
    function Details(id) {
        $.ajax({
            url: ""/User/Tenant/Details?id="" + id,
            type: ""GET"",
            data: """",
            contentType: 'application/json; charset = utf-8',
            success: function (data) {
                $('#DetailsDiv').show();
                $('#DetailsDiv').html(data);
            },
            error: function () {
                alert(""Error occured"")
            }
        })
    }
    function ShowImage");
            WriteLiteral(@"(id) {
        $.ajax({
            url: ""/User/Tenant/ShowImage?id="" + id,
            type: ""GET"",
            data: """",
            contentType: 'application/json; charset = utf-8',
            success: function (data) {
                $('#ViewImagesDiv').show();
                $('#ViewImagesDiv').html(data);
            },
            error: function () {
                alert(""Error occured"")
            }
        })
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TenantViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
