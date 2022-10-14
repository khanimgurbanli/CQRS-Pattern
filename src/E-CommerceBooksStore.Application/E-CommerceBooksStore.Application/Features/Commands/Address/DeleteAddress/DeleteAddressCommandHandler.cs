

using BookApi.Application.Common.Exceptions;
using BookApi.Application.Features.Commands.StatusMessageResponse;
using E_CommerceBooksStore.Application.Repositories.Addresses;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace E_CommerceBooksStore.Application.Features.Commands.Address.DeleteAddress
{
    public class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommandRequest, DeleteAddressCommandResponse>
    {
        private readonly IAddressReadRepository _addressReadRepository;
        private readonly IAddressWriteRepository _addressWriteRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DeleteAddressCommandHandler(IAddressReadRepository addressReadRepository,
                                           IAddressWriteRepository addressWriteRepository,
                                           IHttpContextAccessor httpContextAccessor)
        {
            _addressReadRepository = addressReadRepository;
            _addressWriteRepository = addressWriteRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<DeleteAddressCommandResponse> Handle(DeleteAddressCommandRequest request, CancellationToken cancellationToken)
        {

            ClaimsIdentity claimsIdentity = (ClaimsIdentity)_httpContextAccessor.HttpContext.User.Identity;
            var userIdClaim = claimsIdentity.Claims.SingleOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (userIdClaim != null) request.UserId = userIdClaim.Value;
            else throw new NotFoundUserException();

            var address = await _addressReadRepository.SearchAddressAsync(request.UserId, request.AddressId);
            if (address != null)
            {
                _addressWriteRepository.Remove(address);
                var addressStatus=await _addressWriteRepository.SaveAsync();
                if (addressStatus == 0)
                {
                    var resp = new DeleteAddressCommandResponse
                    {
                        Status = "Error",
                        Message = "Don't remove address"
                    };
                    return resp;
                }
                else
                {
                    var resp = new DeleteAddressCommandResponse
                    {
                        Status = "Succes",
                        Message = "Succesfully remove address"
                    };
                    return resp;
                }
            }
            else throw new NotFoundRecordException();
        }
    }
}
