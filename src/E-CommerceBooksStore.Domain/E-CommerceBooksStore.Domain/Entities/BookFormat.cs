
using E_CommerceBooksStore.Domain.Common;
using E_CommerceBooksStore.Domain.Entities;

namespace BookApi.Domain.Entities
{
    public class BookFormat : BaseAuditableEntity
    {
        public int BookId { get; set; }
        public int FormatId { get; set; }
        public Book Book { get; set; }
        public Format Format { get; set; }
    }
}
