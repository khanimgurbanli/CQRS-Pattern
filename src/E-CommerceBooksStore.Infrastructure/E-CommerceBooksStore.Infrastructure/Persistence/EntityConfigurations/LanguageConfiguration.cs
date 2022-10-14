

using E_CommerceBooksStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApi.Infrastructure.Persistence.EntityConfigurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Languages");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired(true)
                .HasMaxLength(50);

            builder.HasMany(x => x.BookLanguages)
               .WithOne(x => x.Language)
               .HasForeignKey(x => x.LanguageId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
