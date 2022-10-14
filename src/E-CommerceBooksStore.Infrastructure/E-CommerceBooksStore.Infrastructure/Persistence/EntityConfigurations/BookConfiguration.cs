

using E_CommerceBooksStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_CommerceBooksStore.Infrastructure.Persistence.EntityConfigurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CategoryId).IsRequired(true);
            builder.Property(x => x.AuthorId).IsRequired(true);
            builder.Property(x => x.PubliserId).IsRequired(true);
            builder.Property(x => x.GenreId).IsRequired(true);
            builder.Property(x => x.Name).IsRequired(true)
                                         .HasMaxLength(100);
            builder.Property(x => x.ImageUrl).IsRequired(true);
            builder.Property(x => x.PublicationYear).IsRequired(true);
            builder.Property(x => x.PriceId).IsRequired(true);
            builder.Property(x => x.Title).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired(true).HasMaxLength(700);
            builder.Property(x => x.NumPages).IsRequired(false);
            builder.Property(x => x.Stock).IsRequired(true);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Publiser)
               .WithMany(x => x.Books)
               .HasForeignKey(x => x.PubliserId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Genre)
             .WithMany(x => x.Books)
             .HasForeignKey(x => x.GenreId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.BookPrice)
             .WithMany(x => x.Book)
             .HasForeignKey(x => x.PriceId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Vendor)
             .WithMany(x => x.Books)
             .HasForeignKey(x => x.VendorId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.BookLanguages)
                .WithOne(x => x.Book)
                .HasForeignKey(x => x.BookId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
