using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Data.EntitiesConfigurations
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Manager> builder)
        {
            builder.Property(x => x.FullName).HasMaxLength(100);
        }
    }
}
