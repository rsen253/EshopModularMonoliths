﻿
namespace Catalog;

public static class CatalogModule
{
    public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
    {
        // Register your services 

        // Data - infrastructure services
        var connectionString = configuration.GetConnectionString("Database");
        services.AddDbContext<CatalogDbContext>(options =>
        {
            options.AddInterceptors(new AuditableEntityInterceptor());
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
