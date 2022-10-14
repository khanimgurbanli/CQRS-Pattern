

using E_CommerceBooksStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_CommerceBooksStore.Infrastructure.Persistence.EntityConfigurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders"); 
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email).IsRequired(false);
            builder.Property(x => x.Phone).IsRequired(true);
            builder.Property(x => x.Description).IsRequired(true).HasMaxLength(500);
            builder.Property(x => x.OrderCode).IsRequired(true);
            builder.Property(x => x.Shipping).IsRequired(true);

            builder.HasOne(x => x.Address)
             .WithMany(x => x.Orders)
             .HasForeignKey(x => x.AddressId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Sale)
            .WithMany(x => x.Orders)
            .HasForeignKey(x => x.SaleId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
