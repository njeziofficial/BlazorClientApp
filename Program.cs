using System;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorClientApp.Helpers;
using BlazorClientApp.Repository;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;

namespace BlazorClientApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzA4MDQzQDMxMzgyZTMyMmUzMEowcnl1VTN1K2JzZ2dpSUhQOE4zdjdkcyt4QVB2QzB4YTVHZ0QvV2IzdVE9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            //Services
            builder.Services.AddTransient<IHttpService, HttpService>();
            builder.Services.AddTransient<ISupplierRepository, SupplierRepository>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();


            await builder.Build().RunAsync();
        }
    }
}
