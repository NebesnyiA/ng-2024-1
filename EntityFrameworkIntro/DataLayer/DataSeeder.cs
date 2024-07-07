using DataLayer.Data.Infrastructure;
using DataLayer.Entities;

namespace DataLayer
{
    public class DataSeeder
    {
        private readonly IUnitOfWork _uof;

        public DataSeeder(IUnitOfWork uof)
        {
            _uof = uof;
        }

        public async Task Seed()
        {
            var repository = _uof.ShopRepository;

            var shops = new List<Shop>()
            {
                new Shop
                {
                    PointName = "Test",
                    Description = "Test"
                }
            };

            foreach (var shop in shops)
            {
                await repository.Create(shop);
            }

            await _uof.SaveChangesAsync();
        }
    }
}
