using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UTSBlazor.Model;
using UTSBlazor.Services;
using Microsoft.AspNetCore.Components;

namespace UTSBlazor.Pages {
public partial class EditEmployee {
    public Employee Employee { get; set;} = new Employee();

    [Inject]

    public IDEmployeeServices EmployeeServices { get; set; }

    [Inject] 
    public IDepartmentService DepartmentService { get; set; }
    public List<Department>  Departments { get; set; } = new List<Department>();

    [Parameter]
    public string Id { get; set; }

    protected async override Task OnInitializedAsync()
     {
         Employee = await EmployeeServices.GetById(int.Parse(Id));
         Departments = (await DepartmentService.GetAll()).ToList();
     }
}
}


