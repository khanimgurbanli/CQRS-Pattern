

using E_CommerceBooksStore.Domain.Common;
using E_CommerceBooksStore.Domain.Entities;

namespace BookApi.Domain.Entities
{
    public class Vendor : BaseAuditableEntity
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Contact { get; set; } = null!;

        public ICollection<Book> Books { get; set; } = null!;
    }
}




