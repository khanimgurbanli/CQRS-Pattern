using E_CommerceBooksStore.Domain.Common;

namespace E_CommerceBooksStore.Domain.Entities
{
    public class Genre : BaseAuditableEntity
    {
        public string Name { get; set; } = String.Empty;
        public ICollection<Book> Books { get; set; } = null!;//
    }
}
