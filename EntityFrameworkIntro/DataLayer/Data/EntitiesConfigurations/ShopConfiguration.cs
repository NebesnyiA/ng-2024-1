using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Data.EntitiesConfigurations
{
    public class ShopConfiguration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.PointName)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasIndex(x => x.PointName);

            builder
                .HasMany(x => x.Items)
                .WithOne(x => x.Shop)
                .HasForeignKey(x => x.ShopId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(x => x.Manager)
                .WithOne(x => x.Shop)
                .HasForeignKey<Shop>(x => x.ManagerId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
