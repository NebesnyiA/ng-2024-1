using BLL.Mapping;
using BLL.Services.Classes;
using BLL.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.Extensions
{
    public static class BLLDI
    {
        public static void AddBusinessLogicLayer(
        this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutomapperBLLProfile));
            services.AddScoped<IShopService, ShopService>();
        }
    }
}
