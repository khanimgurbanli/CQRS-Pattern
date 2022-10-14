

using BookApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApi.Infrastructure.Persistence.EntityConfigurations
{
    public class BookPriceConfiguration : IEntityTypeConfiguration<BookPrice>
    {
        public void Configure(EntityTypeBuilder<BookPrice> builder)
        {
            builder.ToTable("BookPrices");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price).IsRequired(true);
            builder.HasMany(x => x.Discounts)
             .WithMany(x => x.BookPrices);
        }
    }
}
