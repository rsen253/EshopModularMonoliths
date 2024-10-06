
namespace Catalog;

public static class CatalogModule
{
    public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
    {
        // Register your services 
        //services
        //    .AddApplicationServices()
        //    .AddInfrastructureServices(configuration)
        //    .AddApiServices(configuration);

        return services;
    }

    public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
    {
        // configure http pipeline
        //app
        // .UseApplicationServices()
        // .UseInfrastructureServices(configuration)
        // .UseApiServices(configuration);
        return app;
    }
}
