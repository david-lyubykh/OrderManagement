using Client.App.Services;
using Client.App.Services.IService;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client.App
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(
                sp =>
                    new HttpClient
                    {
                        BaseAddress = new Uri(builder.Configuration.GetValue<string>("BaseAPIUrl"))
                    }
            );
            builder.Services.AddScoped<ISupplierService, SupplierService>();
            builder.Services.AddScoped<IStateService, StateService>();

            await builder.Build().RunAsync();
        }
    }
}
