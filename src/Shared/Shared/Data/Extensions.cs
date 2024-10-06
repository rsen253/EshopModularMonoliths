
namespace Shared.Data;

public static class Extensions
{
    public static IApplicationBuilder UseMigration<TContext>(this IApplicationBuilder app)
        where TContext : DbContext
    {
        MigratieDatabaseAsync<TContext>(app).GetAwaiter().GetResult();

        return app;
    }

    private static async Task MigratieDatabaseAsync<TContext>(IApplicationBuilder app) where TContext : DbContext
    {
        var scope = app.ApplicationServices.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<TContext>();
        await context.Database.MigrateAsync();
    }
}
