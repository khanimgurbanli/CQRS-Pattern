using BookApi.Domain.Entities;
using E_CommerceBooksStore.Domain.Common;

namespace E_CommerceBooksStore.Domain.Entities
{
    public class Book : BaseAuditableEntity
    {
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int PubliserId { get; set; }
        public int VendorId { get; set; }
        public int GenreId { get; set; }
        public string Name { get; set; } = String.Empty;
        public string? Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;//iformfilee
        public DateTime PublicationYear { get; set; }
        public int PriceId { get; set; }
        public int? NumPages { get; set; }
        public double? Discount { get; set; }
        public int Stock { get; set; }
        public Category Category { get; set; }//
        public Author Author { get; set; }//
        public Publisher Publiser { get; set; }//
        public Genre Genre { get; set; }//
        public Vendor Vendor { get; set; }//
        public BookPrice BookPrice { get; set; }//
        public ICollection<BookFormat> BookFormats { get; set; }//
        public ICollection<BasketItem> BasketItems { get; set; }//
        public ICollection<BookLanguage> BookLanguages { get; set; }//
        public ICollection<Review> Reviews { get; set; } = null!;//
    }
}
