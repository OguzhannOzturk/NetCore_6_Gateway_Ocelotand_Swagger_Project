using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace GatewayAPI;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddOcelot();
    }
    async public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        await app.UseOcelot();
    }
}