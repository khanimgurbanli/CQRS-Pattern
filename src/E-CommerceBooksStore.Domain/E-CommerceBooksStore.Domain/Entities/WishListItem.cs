using E_CommerceBooksStore.Domain.Common;
using E_CommerceBooksStore.Domain.Identity;

namespace E_CommerceBooksStore.Domain.Entities
{
    public class WishListItem : BaseAuditableEntity
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
       // public ApplicationUser? User { get; set; }
       // public Book? Book { get; set; }
        public byte Quantity { get; set; }
    }
}
