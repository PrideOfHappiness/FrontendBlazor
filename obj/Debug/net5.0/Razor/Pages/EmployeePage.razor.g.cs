#pragma checksum "D:\Codes\frontend_blazor\UTSBlazor\Pages\EmployeePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "046a994ecc4d8a411ccfafc3549deff99cef41bd"
// <auto-generated/>
#pragma warning disable 1591
namespace UTSBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Codes\frontend_blazor\UTSBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Codes\frontend_blazor\UTSBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Codes\frontend_blazor\UTSBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Codes\frontend_blazor\UTSBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Codes\frontend_blazor\UTSBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Codes\frontend_blazor\UTSBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Codes\frontend_blazor\UTSBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Codes\frontend_blazor\UTSBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Codes\frontend_blazor\UTSBlazor\_Imports.razor"
using UTSBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Codes\frontend_blazor\UTSBlazor\_Imports.razor"
using UTSBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee")]
    public partial class EmployeePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3> Daftar Karyawan</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-deck");
#nullable restore
#line 6 "D:\Codes\frontend_blazor\UTSBlazor\Pages\EmployeePage.razor"
     foreach(var emp in Employees){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card m-3");
            __builder.AddAttribute(5, "style", "min-width: 18 rem; max-width: 30%");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-header");
            __builder.OpenElement(8, "h3");
            __builder.AddContent(9, 
#nullable restore
#line 9 "D:\Codes\frontend_blazor\UTSBlazor\Pages\EmployeePage.razor"
                      emp.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " ");
            __builder.AddContent(11, 
#nullable restore
#line 9 "D:\Codes\frontend_blazor\UTSBlazor\Pages\EmployeePage.razor"
                                     emp.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "class", "card-img-top img-thumbnail");
            __builder.AddAttribute(15, "src", 
#nullable restore
#line 11 "D:\Codes\frontend_blazor\UTSBlazor\Pages\EmployeePage.razor"
                                                          emp.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, " \r\n            ");
            __builder.AddMarkupContent(17, "<div class=\"card-footer text-center\"><a href=\"/employeedetail/{id}\" class=\"btn btn-primary m-1\"> View</a>\r\n                <a href=\"#\" class=\"btn btn-success m-1\"> Edit</a>\r\n                <a href=\"#\" class=\"btn btn-danger m-1\"> Delete</a></div>");
            __builder.CloseElement();
#nullable restore
#line 18 "D:\Codes\frontend_blazor\UTSBlazor\Pages\EmployeePage.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591