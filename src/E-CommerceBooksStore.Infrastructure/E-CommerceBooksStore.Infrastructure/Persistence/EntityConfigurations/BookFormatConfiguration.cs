
using BookApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApi.Infrastructure.Persistence.EntityConfigurations
{
    public class BookFormatConfiguration : IEntityTypeConfiguration<BookFormat>
    {
        public void Configure(EntityTypeBuilder<BookFormat> builder)
        {
            builder.ToTable("BookFormats");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Book)
             .WithMany(x => x.BookFormats)
             .HasForeignKey(x => x.BookId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Format)
            .WithMany(x => x.BookFormats)
            .HasForeignKey(x => x.FormatId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
