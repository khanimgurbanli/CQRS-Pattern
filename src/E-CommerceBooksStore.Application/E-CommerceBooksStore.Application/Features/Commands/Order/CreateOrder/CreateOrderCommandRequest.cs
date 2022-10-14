using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Order.CreateOrder
{
    public class CreateOrderCommandRequest : IRequest<CreateOrderCommandResponse>
    {
        public string UserId { get; set; } = null!;
        public int AddressId { get; set; }
        public string? Email { get; set; } = String.Empty;
        public string Phone { get; set; } = String.Empty;
        public string Description { get; set; } = string.Empty;
        public string OrderCode { get; set; } = null!;
        public float DiscountPrice { get; set; }
        public float Shipping { get; set; }
        public string? Contact { get; set; } = String.Empty;
        public string? CountryRegion { get; set; } = String.Empty;
        public string? AddressDetails { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; } = null!;
    }
}
