using E_CommerceBooksStore.Domain.Common;
using E_CommerceBooksStore.Domain.Identity;

namespace E_CommerceBooksStore.Domain.Entities
{
    public class BasketItem : BaseAuditableEntity
    {
        public int BookId { get; set; }
        public string UserId { get; set; } = null!;
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public Book Book { get; set; } = null!;//
        public Order Order { get; set; } = null!;//
     //   public ApplicationUser User { get; set; } = null!;
    }
}
