

using E_CommerceBooksStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApi.Infrastructure.Persistence.EntityConfigurations
{
    public class BookLanguageConfiguration : IEntityTypeConfiguration<BookLanguage>
    {
        public void Configure(EntityTypeBuilder<BookLanguage> builder)
        {
            builder.ToTable("BookLanguages");
            builder.HasKey(x => x.Id);

            //builder.HasOne(x => x.Book)
            // .WithMany(x => x.BookLanguages)
            // .HasForeignKey(x => x.BookId)
            // .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(x => x.Language)
            // .WithMany(x => x.BookLanguages)
            // .HasForeignKey(x => x.LanguageId)
            // .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
