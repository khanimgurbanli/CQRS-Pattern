

using E_CommerceBooksStore.Domain.Common;

namespace BookApi.Domain.Entities
{
    public class Discount : BaseAuditableEntity
    {
        public decimal? DiscountPrice { get; set; }
        public ICollection<BookPrice> BookPrices { get; set; }
    }
}
