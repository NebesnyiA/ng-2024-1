using DataLayer.Data.Infrastructure;
using DataLayer.Data.Repositories.Interfaces;
using DataLayer.Entities;

namespace DataLayer.Data.Repositories.Realization
{
    public class ShopRepository : Repository<Shop>, IShopRepository
    {
        public ShopRepository(WebShopDbContext dbContext) : base(dbContext)
        {
        }
    }
}
