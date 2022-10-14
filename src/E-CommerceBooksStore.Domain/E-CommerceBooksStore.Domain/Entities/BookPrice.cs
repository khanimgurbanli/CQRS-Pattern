

using E_CommerceBooksStore.Domain.Common;
using E_CommerceBooksStore.Domain.Entities;

namespace BookApi.Domain.Entities
{
    public class BookPrice : BaseAuditableEntity
    {
        public decimal Price { get; set; }

        public ICollection<Book> Book { get; set; }
        public ICollection<Discount> Discounts { get; set; }
    }
}
