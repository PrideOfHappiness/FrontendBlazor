using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using UTSBlazor.Services;

namespace UTSBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            
            var url = new Uri("https://blazorbackend.azurewebsites.net/swagger/index.html");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = url });
            
            builder.Services.AddScoped<IDEmployeeServices, EmployeeServices>();
            builder.Services.AddScoped<IDepartmentService, DepartmentService>();

            await builder.Build().RunAsync();
        }
    }
}
