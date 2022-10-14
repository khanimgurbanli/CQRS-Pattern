using E_CommerceBooksStore.Domain.Common;

namespace E_CommerceBooksStore.Domain.Entities
{
    public class Address : BaseAuditableEntity
    {
        public string UserId { get; set; } = null!;
        public string? CountryRegion { get; set; } = string.Empty;
        public string Contact { get; set; } = String.Empty;
        public string? AddressDetails { get; set; } = String.Empty;
        public string PostalCode { get; set; } = String.Empty;
        public string City { get; set; } = null!;

        //public ApplicationUser ApplicationUser { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
