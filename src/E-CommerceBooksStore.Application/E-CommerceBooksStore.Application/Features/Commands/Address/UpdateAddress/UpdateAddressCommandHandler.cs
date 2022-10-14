

using BookApi.Application.Common.Exceptions;
using BookApi.Application.Features.Commands.StatusMessageResponse;
using E_CommerceBooksStore.Application.Repositories.Addresses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace E_CommerceBooksStore.Application.Features.Commands.Address.UpdateAddress
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommandRequest, UpdateAddressCommandResponse>
    {
        private readonly IAddressReadRepository _addressReadRepository;
        private readonly IAddressWriteRepository _addressWriteRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        readonly ILogger<UpdateAddressCommandHandler> _logger;

        public UpdateAddressCommandHandler(IAddressReadRepository addressReadRepository,
                                           IAddressWriteRepository addressWriteRepository,
                                           IHttpContextAccessor httpContextAccessor,
                                           ILogger<UpdateAddressCommandHandler> logger)
        {
            _addressReadRepository = addressReadRepository;
            _addressWriteRepository = addressWriteRepository;
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;
        }

        public async Task<UpdateAddressCommandResponse> Handle(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {

            ClaimsIdentity claimsIdentity = (ClaimsIdentity)_httpContextAccessor.HttpContext.User.Identity;
            var userIdClaim = claimsIdentity.Claims.SingleOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (userIdClaim != null) request.UserId = userIdClaim.Value;
            else return new();

            var address = await _addressReadRepository.SearchAddressAsync(request.UserId, request.AddressId);
            if (address != null)
            {
                _addressWriteRepository.Update(address);
                var addressStatus = await _addressWriteRepository.SaveAsync();

                if (addressStatus == 0)
                {
                    var resp = new UpdateAddressCommandResponse
                    {
                        Status = "Error",
                        Message = "Don't update address"
                    };
                    _logger.LogInformation("Address updated");
                    return resp;
                }
                else
                {
                    var resp = new UpdateAddressCommandResponse
                    {
                        Status = "Succes",
                        Message = "Succesfully update address"
                    };
                    return resp;
                }
            }
            else throw new NotFoundRecordException();
        }
    }
}
