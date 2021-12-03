using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UTSBlazor.Model;
using UTSBlazor.Services;
using System.ComponentModel.DataAnnotations;

namespace UTSBlazor.Pages {
    public partial class DetailEmployee
    {
        [Parameter]
        public string id { get; set;}

        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public EmployeeServices EmployeeService { get; set; }
        public DepartmentService DepartmentService { get; set;} 
        public List<Department>  Departments { get; set; } = new List<Department>();

        public string Coordinates { get; set;}
        public String ButtonText { get; set;} = "Hide Footer";
        public String CssClass { get; set;} = null;
        protected void Button_Click(){
            if(ButtonText == "Hide Footer") {
                ButtonText = "Show Footer";
                CssClass = "HideFooter";
            }
            else{ 
                CssClass = null;
                ButtonText = "Hide Footer";

            }
        }

        protected void Mouse_Move(MoveEventArgs e) {
            Coordinates = $"X = {e.ClientX}, Y = {e.ClientY}";
        }
        
        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Employee = await EmployeeService.GetById(Convert.ToInt32(id));
            Departments = (await DepartmentService.GetAll()).ToList();

        }
    }
}