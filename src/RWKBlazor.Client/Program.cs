using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RWKBlazor.Client.Services;
using RWKBlazor.Sdk;
using RWKBlazor.Shared.Services;

namespace RWKBlazor.Client;

class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        builder.Services.AddAuthorizationCore();
        builder.Services.AddCascadingAuthenticationState();
        builder.Services.AddAuthenticationStateDeserialization();

        ClientServices.ConfigureServices(builder.Services);

        builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        builder.Services.AddSingleton(sp => new RWKBlazorClient(sp.GetRequiredService<HttpClient>()));

        builder.Services.AddSingleton<IValueService, ValueService>();

        await builder.Build().RunAsync();
    }
}
