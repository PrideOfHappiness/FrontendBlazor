#pragma checksum "D:\Codes\frontend_blazor\UTSBlazor\Pages\DepartmentPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5838e42b3199e8c75573d4cb2738cf86a01816ca"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/department")]
    public partial class DepartmentPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3> Daftar Departemen</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
            __builder.AddMarkupContent(3, "<thead><tr><td> Department ID</td>\r\n            <td> Department Name</td>\r\n            <td> Action</td></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 14 "D:\Codes\frontend_blazor\UTSBlazor\Pages\DepartmentPage.razor"
         foreach(var dept in Departments){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 16 "D:\Codes\frontend_blazor\UTSBlazor\Pages\DepartmentPage.razor"
                     dept.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 17 "D:\Codes\frontend_blazor\UTSBlazor\Pages\DepartmentPage.razor"
                     dept.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", 
#nullable restore
#line 18 "D:\Codes\frontend_blazor\UTSBlazor\Pages\DepartmentPage.razor"
                               $"departmentdetail/{dept.DepartmentId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "btn btn-success");
            __builder.AddContent(16, " Detail ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "D:\Codes\frontend_blazor\UTSBlazor\Pages\DepartmentPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591