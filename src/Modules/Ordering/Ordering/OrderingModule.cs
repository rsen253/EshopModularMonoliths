
namespace Ordering;

public static class OrderingModule
{
    public static IServiceCollection AddOrderingModule(this IServiceCollection services, IConfiguration configuration)
    {
        // Register your services 
        //services
        //    .AddApplicationServices()
        //    .AddInfrastructureServices(configuration)
        //    .AddApiServices(configuration);
        return services;
    }

    public static IApplicationBuilder UseOrderingModule(this IApplicationBuilder app)
    {
        // configure http pipeline
        //app
        // .UseApplicationServices()
        // .UseInfrastructureServices(configuration)
        // .UseApiServices(configuration);
        return app;
    }
}
