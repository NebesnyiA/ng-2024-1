using DataLayer.Data.Repositories.Interfaces;

namespace DataLayer.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        IItemRepository ItemRepository { get; }
        IShopRepository ShopRepository { get; }
        IManagerRepository ManagerRepository { get; }

        Task SaveChangesAsync();
    }
}
