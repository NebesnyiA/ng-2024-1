using AutoMapper;
using BLL.Models.AddEntityModels;
using BLL.Models.GetEntityModels;
using BLL.Models.UpdateEntityModel;
using BLL.Services.Interfaces;
using DataLayer.Data.Infrastructure;
using DataLayer.Entities;

namespace BLL.Services.Classes
{
    public class ShopService : IShopService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ShopService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Guid> AddAsync(SaveShopModel model)
        {
            var shopRepository = _unitOfWork.ShopRepository;
            var itemRepository = _unitOfWork.ItemRepository;
            var managerRepository = _unitOfWork.ManagerRepository;

            var shop = _mapper.Map<Shop>(model);

            if (model.Items is not null && model.Items.Any())
            {
                var existingItems = await itemRepository.GetAllAsync(x => model.Items.Contains(x.Id));
                shop.Items = existingItems;
            }

            if (model is not null && model.ManagerId.HasValue)
            {
                var existingManager = await managerRepository.Find(model.ManagerId.Value);
                shop.Manager = existingManager;
            }

            var result = await shopRepository.Create(shop);
            await _unitOfWork.SaveChangesAsync();

            return result.Id;
        }

        public async Task DeleteAsync(Guid id)
        {
            var shopRepository = _unitOfWork.ShopRepository;
            await shopRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<ShopReadModel>> GetAllAsync()
        {
            var shopRepository = _unitOfWork.ShopRepository;
            return _mapper.Map<IEnumerable<ShopReadModel>>(shopRepository.GetAll());
        }

        public async Task<ShopReadModel> GetByIdAsync(Guid id)
        {
            var shopRepository = _unitOfWork.ShopRepository;
            var shop = shopRepository.Find(id);
            return _mapper.Map<ShopReadModel>(shop);
        }

        public async Task<Guid> UpdateAsync(UpdateShopModel model)
        {
            var shopRepository = _unitOfWork.ShopRepository;
            var shop = await shopRepository.Find(model.ShopId);

            _mapper.Map(model, shop);

            await UpdateItems(model.Items, shop);
            var result = await shopRepository.Update(shop);

            await _unitOfWork.SaveChangesAsync();

            return result.Id;
        }

        private async Task UpdateItems(List<Guid> updateItemsList, Shop shop)
        {
            var itemRepository = _unitOfWork.ItemRepository;
            var shopItemIds = shop.Items.Select(items => items.Id);

            var existingItems = await itemRepository.GetAllAsync(x => shopItemIds.Contains(x.Id));

            var itemsToAdd = updateItemsList.Except(existingItems.Select(item => item.Id)).ToList();

            var itemsToRemove = existingItems.Where(x => !updateItemsList.Contains(x.Id)).ToList();

            foreach (var item in itemsToAdd)
            {
                var itemToAdd = await itemRepository.Find(item);
                shop.Items.Add(itemToAdd);
            }

            foreach (var item in itemsToRemove)
            {
                shop.Items.Remove(item);
            }
        }
    }
}
