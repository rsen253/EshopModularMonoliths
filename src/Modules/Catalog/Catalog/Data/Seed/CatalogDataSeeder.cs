
namespace Catalog.Data.Seed;

public class CatalogDataSeeder(CatalogDbContext dbContext) : IDataSeeder
{
    public async Task SeedAllAync()
    {
        if (!await dbContext.Product.AnyAsync())
        {
            await dbContext.Product.AddRangeAsync(InitialData.Products);
            await dbContext.SaveChangesAsync();
        }
    }
}
