using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UTSBlazor.Model;
using UTSBlazor.Services;
using Microsoft.AspNetCore.Components;

namespace UTSBlazor.Pages {
public partial class AddEmployee {
    public Employee Employee { get; set;} = new Employee();

    [Inject]

    public IDEmployeeServices EmployeeServices { get; set; }

    [Inject] 
    public IDepartmentService DepartmentService { get; set; }
    public List<Department>  Departments { get; set; } = new List<Department>();
    public NavigationManager NavigationManager { get; set; }

    [Parameter]
    public string Id { get; set; }

    protected async override Task OnInitializedAsync()
     {
         Employee = await EmployeeServices.GetById(int.Parse(Id));
         Departments = (await DepartmentService.GetAll()).ToList();
     }

     protected async Task handleValidSubmit(){
         Employee.PhotoPath = "images/nophoto.jpg";
         Employee result = await EmployeeServices.Update(int.Parse(Id),Employee));
         NavigationManager.NavigateTo("EmployeePage");
     }
     
}
}


