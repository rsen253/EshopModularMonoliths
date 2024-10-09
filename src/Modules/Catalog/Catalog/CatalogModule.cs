using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Catalog;

public static class CatalogModule
{
    public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
    {
        // Register your services 

        // Data - infrastructure services
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        var connectionString = configuration.GetConnectionString("Database");
        services.AddScoped<ISaveChangesInterceptor, AuditableEntityInterceptor>();
        services.AddScoped<ISaveChangesInterceptor, DispatchDomainEventsInterceptor>();
        
        services.AddDbContext<CatalogDbContext>((serviceProvider, options) =>
        {
            //var logger = serviceProvider.GetRequiredService<ILogger<AuditableEntityInterceptor>>();
            //options.AddInterceptors(new AuditableEntityInterceptor(logger));
            options.AddInterceptors(serviceProvider.GetServices<ISaveChangesInterceptor>()!);
            options.UseNpgsql(connectionString);
        });

        services.AddScoped<IDataSeeder, CatalogDataSeeder>();

        return services;
    }

    public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
    {
        // configure HTTP pipeline

        // use data - Infrastructure services
        app.UseMigration<CatalogDbContext>();

        return app;
    }
}
