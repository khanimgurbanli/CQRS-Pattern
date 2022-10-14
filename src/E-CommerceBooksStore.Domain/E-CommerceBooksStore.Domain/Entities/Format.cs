using E_CommerceBooksStore.Domain.Common;

namespace BookApi.Domain.Entities
{
    public class Format : BaseAuditableEntity
    {
        public string Name { get; set; } = null!;
        public ICollection<BookFormat> BookFormats { get; set; }
    }
}
