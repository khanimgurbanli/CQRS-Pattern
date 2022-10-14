

using E_CommerceBooksStore.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Infrastructure.Persistence.EntityConfigurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CountryRegion).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.Contact).IsRequired(true).HasMaxLength(50);
            builder.Property(x => x.AddressDetails).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.PostalCode).IsRequired(true);
            builder.Property(x => x.City).IsRequired(true);
        }
    }
}
