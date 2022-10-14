

using E_CommerceBooksStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApi.Infrastructure.Persistence.EntityConfigurations
{
    public class BasketItemConfiguration : IEntityTypeConfiguration<BasketItem>
    {
        public void Configure(EntityTypeBuilder<BasketItem> builder)
        {
            builder.Property(x => x.Quantity).IsRequired(true);

            builder.ToTable("BasketItems");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Book)
               .WithMany(x => x.BasketItems)
               .HasForeignKey(x => x.BookId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Order)
            .WithMany(x => x.BasketItems)
            .HasForeignKey(x => x.OrderId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
