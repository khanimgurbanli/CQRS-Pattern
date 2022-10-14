using s = E_CommerceBooksStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using E_CommerceBooksStore.Domain.Entities;
using BookApi.Domain.Entities;

namespace E_CommerceBooksStore.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Address> Addresses { get; }
        DbSet<Author> Authors { get; }
        DbSet<BasketItem> BasketItems { get; }
        DbSet<Book> Books { get; }
        DbSet<BookLanguage> BookLanguages { get; }
        DbSet<BookFormat> BookFormats { get; }
        DbSet<BookPrice> BookPrices { get; }
        DbSet<Category> Categories { get; }
        DbSet<Discount> Discounts { get; }
        DbSet<s.File> Files { get; }
        DbSet<Format> Formats { get; }
        DbSet<Genre> Genres { get; }
        DbSet<Language> Languages { get; }
        DbSet<Order> Orders { get; }
        DbSet<Publisher> Publishers { get; }
        DbSet<Review> Reviews { get; }
        DbSet<Sale> Sales { get; }
        DbSet<Vendor> Vendor { get; }
        DbSet<WishListItem> WishListItems { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
