using DataLayer.Data.EntitiesConfigurations;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Data.Infrastructure
{
    public class WebShopDbContext : DbContext
    {
        public WebShopDbContext(DbContextOptions<WebShopDbContext> options)
        : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Shop> Shops { get; set; }

        public DbSet<Manager> Managers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new ManagerConfiguration());
            modelBuilder.ApplyConfiguration(new ShopConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
