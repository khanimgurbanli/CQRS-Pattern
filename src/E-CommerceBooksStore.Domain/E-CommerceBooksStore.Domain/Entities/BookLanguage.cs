using E_CommerceBooksStore.Domain.Common;

namespace E_CommerceBooksStore.Domain.Entities
{
    public class BookLanguage : BaseAuditableEntity
    {
        public int BookId { get; set; }
        public int LanguageId { get; set; }
        public Book Book { get; set; }
        public Language Language { get; set; }
    }
}
