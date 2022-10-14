using E_CommerceBooksStore.Domain.Common;

namespace E_CommerceBooksStore.Domain.Entities
{
    public class Language : BaseAuditableEntity
    {
        public string Name { get; set; } = null!;
        public ICollection<BookLanguage> BookLanguages { get; set; }//
    }
}
