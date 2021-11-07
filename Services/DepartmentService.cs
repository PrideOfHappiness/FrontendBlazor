using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using UTSBlazor.Model;

namespace UTSBlazor.Services
{
    public class DepartmentService : IDepartmentService
    {
        private HttpClient _httpclient;
        public DepartmentService(HttpClient httpclient){
            _httpclient = httpclient;
        }

        public async Task<IEnumerable<Department>> GetAll(){
            var results = await _httpclient.GetFromJsonAsync<IEnumerable<Department>>("/api/Departments");
            return results;
        }

        public async Task<Department> GetById(int id){
            var results = await _httpclient.GetFromJsonAsync<Department>($"/api/Departments/{id}");
            return results;
        }

    }
}