using DataLayer.Data.Infrastructure;
using DataLayer.Data.Repositories.Interfaces;
using DataLayer.Data.Repositories.Realization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer
{
    public static class DataLayerDI
    {
        public static void AddDataAccessLayer(
        this IServiceCollection services,
        IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("WebShopConnectionString");
            services.AddDbContext<WebShopDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IShopRepository, ShopRepository>();
            services.AddScoped<IManagerRepository, ManagerRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<DataSeeder>();
        }
    }
}
