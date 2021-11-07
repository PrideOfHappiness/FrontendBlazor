using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UTSBlazor.Model
{
    public class Employee
    {
        public int employeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string dateOfBirth { get; set; }
        public int gender { get; set; }
        public int departmentId { get; set; }
        public string departmentName { get; set; }
        public string PhotoPath { get; set; }
    }
}