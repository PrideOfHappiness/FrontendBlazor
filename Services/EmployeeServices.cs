using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
//using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using UTSBlazor.Model;
using Microsoft.AspNetCore.Components;

namespace UTSBlazor.Services
{
    public class EmployeeServices : IDEmployeeServices {
        private HttpClient _httpclient;
        public EmployeeServices(HttpClient httpclient)
        {
            _httpclient = httpclient;
        }

        public async Task<IEnumerable<Employee>> GetAll(){
            var results = await _httpclient.GetFromJsonAsync<IEnumerable<Employee>>("/api/Employees");
            return results;
        }

        public async Task<Employee> GetById(int id){
            var results = await _httpclient.GetFromJsonAsync<Employee>($"/api/Employees/{id}");
            return results;
        }

}
}