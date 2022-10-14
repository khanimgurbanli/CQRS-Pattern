using E_CommerceBooksStore.Domain.Common;

namespace E_CommerceBooksStore.Domain.Entities
{
    public class Author : BaseAuditableEntity
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Bio { get; set; } = String.Empty;

        public ICollection<Book>? Books { get; set; }
    }
}
