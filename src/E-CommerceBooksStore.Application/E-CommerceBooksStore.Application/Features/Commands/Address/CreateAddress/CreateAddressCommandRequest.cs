

using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Address.CreateAddress
{
    public class CreateAddressCommandRequest : IRequest<CreateAddressCommandResponse>
    {
        public string UserId { get; set; } = null!;
        public string Contact { get; set; } = String.Empty;
        public string CountryRegion { get; set; } = String.Empty;
        public string? AddressDetails { get; set; }
        public string? PostalCode { get; set; }
        public string City { get; set; } = null!;
    }
}
