using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UTSBlazor.Model;
using UTSBlazor.Services;

namespace UTSBlazor.Pages
{
    public partial class EmployeePage
    {
        //public IEnumerable<Employee> employees { get; set;}
        public List<Employee> Employees { get; set; } = new List<Employee>();
        
        [Inject]
        public IDEmployeeServices EmployeeService { get; set; } 
        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetAll()).ToList();
        }
    }
}