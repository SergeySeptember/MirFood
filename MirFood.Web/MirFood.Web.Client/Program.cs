using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

namespace MirFood.Web.Client
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddRadzenComponents();

            await builder.Build().RunAsync();
        }
    }
}