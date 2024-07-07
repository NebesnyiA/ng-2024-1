using DataLayer.Data.Repositories.Interfaces;

namespace DataLayer.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WebShopDbContext _dbContext;
        public IItemRepository ItemRepository { get; }
        public IShopRepository ShopRepository { get; }
        public IManagerRepository ManagerRepository { get; }

        public UnitOfWork(
            WebShopDbContext dbContext,
            IItemRepository itemRepository,
            IShopRepository shopRepository,
            IManagerRepository managerRepository)
        {
            _dbContext = dbContext;
            ItemRepository = itemRepository;
            ShopRepository = shopRepository;
            ManagerRepository = managerRepository;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
