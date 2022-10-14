using E_CommerceBooksStore.Domain.Common;

namespace E_CommerceBooksStore.Domain.Entities
{
    public class Publisher : BaseAuditableEntity
    {
        public string Name { get; set; } = null!;
        public ICollection<Book> Books { get; set; } = null!;
    }
}
