using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazoR.Chat.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped<HttpClient>(
                provider => new()
                {
                    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
                });

            await builder.Build().RunAsync();
        }
    }
}
