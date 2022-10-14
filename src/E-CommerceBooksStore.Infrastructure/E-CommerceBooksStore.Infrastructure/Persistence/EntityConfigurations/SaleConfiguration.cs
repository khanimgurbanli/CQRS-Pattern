

using E_CommerceBooksStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApi.Infrastructure.Persistence.EntityConfigurations
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sales");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OrderStatus).IsRequired(true);
        }
    }
}
