using DataLayer.Data.Infrastructure;

namespace DataLayer
{
    public static class DbInitializer
    {
        public static void InitializeDatabase(WebShopDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();
        }
    }
}
