using E_CommerceBooksStore.Domain.Common;
using E_CommerceBooksStore.Domain.Enums;
using Microsoft.VisualBasic;

namespace E_CommerceBooksStore.Domain.Entities
{
    public class Sale : BaseAuditableEntity
    {
        public OrderStatus OrderStatus { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
