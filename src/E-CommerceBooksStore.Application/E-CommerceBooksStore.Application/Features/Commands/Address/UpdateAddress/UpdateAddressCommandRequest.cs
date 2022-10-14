
using BookApi.Application.Features.Commands.StatusMessageResponse;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Address.UpdateAddress
{
    public class UpdateAddressCommandRequest  : IRequest<UpdateAddressCommandResponse>
    {
        public string UserId { get; set; } = null!;
        public int AddressId { get; set; }
        public string Contact { get; set; } = String.Empty;
        public string CountryRegion { get; set; } = String.Empty;
        public string? AddressDetails { get; set; }
        public string PostalCode { get; set; }=String.Empty;
        public string City { get; set; } = null!;
    }
}
