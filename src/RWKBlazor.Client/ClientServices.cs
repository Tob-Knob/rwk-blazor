using Fluxor;
using Fluxor.Blazor.Web.ReduxDevTools;

namespace RWKBlazor.Client
{
    public static class ClientServices
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddFluxor(o => o
                .ScanAssemblies(typeof(Program).Assembly)
                .UseReduxDevTools());
        }
    }
}
