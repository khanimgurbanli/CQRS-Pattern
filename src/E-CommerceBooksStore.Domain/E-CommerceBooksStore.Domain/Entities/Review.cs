
using E_CommerceBooksStore.Domain.Common;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Domain.Identity;

namespace BookApi.Domain.Entities
{ 
    public class Review : BaseAuditableEntity
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
      //  public ApplicationUser User { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public double Rating { get; set; }
        public Book Book { get; set; }
    }
}
