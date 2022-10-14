

using E_CommerceBooksStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApi.Infrastructure.Persistence.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired(true)
                .HasMaxLength(50);

            builder.Property(x => x.Description)
                .IsRequired(true)
                .HasMaxLength(250);

            builder.HasOne(x => x.SupCategory)
             .WithMany(x => x.SupCategories)
             .HasForeignKey(x => x.SupCategoryId)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
