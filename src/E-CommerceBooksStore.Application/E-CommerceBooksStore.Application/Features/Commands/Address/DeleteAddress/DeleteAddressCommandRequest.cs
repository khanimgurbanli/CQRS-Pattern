
using BookApi.Application.Features.Commands.StatusMessageResponse;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Address.DeleteAddress
{
    public class DeleteAddressCommandRequest : IRequest<DeleteAddressCommandResponse>
    {
        public string UserId { get; set; } = null!;
        public int AddressId { get; set; }
    }
}
