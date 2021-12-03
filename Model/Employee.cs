using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UTSBlazor.Model
{
    public class Employee
    {
        public int employeeId { get; set; }
        public string firstName { get; set; }
        [Required(ErrorMessage = "First Name is Required")]
        public string lastName { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        public string email { get; set; }
        [Compare("Email",ErrorMessage = "Email and Confirm Email must be same")]
        public string confirmEmail { get; set; }
        public string dateOfBirth { get; set; }
        public int gender { get; set; }
        public int departmentId { get; set; }
        public string departmentName { get; set; }
        public string PhotoPath { get; set; }
    }

    public enum gender {
        Male, Female
    }
}