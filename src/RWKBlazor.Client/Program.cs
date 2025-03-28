using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

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

        await builder.Build().RunAsync();
    }
}
