using E_CommerceBooksStore.Domain.Common;
using E_CommerceBooksStore.Domain.Identity;

namespace E_CommerceBooksStore.Domain.Entities
{
    public class Order : BaseAuditableEntity
    {
        public Order()
        {
            BasketItems = new HashSet<BasketItem>();
        }
        public string UserId { get; set; } = null!;
        public int? AddressId { get; set; }//
        public int SaleId { get; set; }//
        public string? Email { get; set; } = String.Empty;
        public string Phone { get; set; } = String.Empty;
        public string? Description { get; set; } = string.Empty;
        public string OrderCode { get; set; } = null!;
        public float Shipping { get; set; }

        public ICollection<BasketItem> BasketItems { get; set; }//
       //public ApplicationUser User { get; set; }
        public Address Address { get; set; }//
        public Sale Sale { get; set; }//
    }
}
