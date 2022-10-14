using E_CommerceBooksStore.Domain.Common;

namespace E_CommerceBooksStore.Domain.Entities
{
    public class Category : BaseAuditableEntity
    {
        public Category()
        {
            this.Books = new HashSet<Book>();
        }

        public string Name { get; set; } = string.Empty;//
        public string Description { get; set; } = string.Empty;//

        public int SupCategoryId { get; set; }
        public Category SupCategory { get; set; }
        public ICollection<Category> SupCategories { get; set; }//
        public ICollection<Book> Books { get; set; } = null!;//
    }
}
