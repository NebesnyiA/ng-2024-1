using BLL.Models.AddEntityModels;
using BLL.Models.GetEntityModels;
using BLL.Models.UpdateEntityModel;

namespace BLL.Services.Interfaces
{
    public interface IShopService
    {
        Task<IEnumerable<ShopReadModel>> GetAllAsync();
        Task<Guid> AddAsync(SaveShopModel model);
        Task<Guid> UpdateAsync(UpdateShopModel model);
        Task DeleteAsync(Guid id);
        Task<ShopReadModel> GetByIdAsync(Guid id);
    }
}
