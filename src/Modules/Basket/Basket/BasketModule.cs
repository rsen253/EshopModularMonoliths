using Microsoft.AspNetCore.Builder;

namespace Basket;

public static class BasketModule
{
    public static IServiceCollection AddBasketModule(this IServiceCollection services, IConfiguration configuration)
    {
        // Register your services 
        //services
        //    .AddApplicationServices()
        //    .AddInfrastructureServices(configuration)
        //    .AddApiServices(configuration);
        return services;
    }
    public static IApplicationBuilder UseBasketModule(this IApplicationBuilder app)
    {
        // configure http pipeline
        //app
        // .UseApplicationServices()
        // .UseInfrastructureServices(configuration)
        // .UseApiServices(configuration);
        return app;
    }
}
