

using BookApi.Application.Common.Exceptions;
using E_CommerceBooksStore.Application.Repositories.Addresses;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace E_CommerceBooksStore.Application.Features.Commands.Address.CreateAddress
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommandRequest, CreateAddressCommandResponse>
    {
        private readonly IAddressWriteRepository _addressWriteRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CreateAddressCommandHandler(IAddressWriteRepository addressWriteRepository,
                                           IHttpContextAccessor httpContextAccessor)

        {
            _addressWriteRepository = addressWriteRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<CreateAddressCommandResponse> Handle(CreateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            ClaimsIdentity claimsIdentity = (ClaimsIdentity)_httpContextAccessor.HttpContext.User.Identity;
            var userIdClaim = claimsIdentity.Claims.SingleOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (userIdClaim != null) request.UserId = userIdClaim.Value;
            else throw new NotFoundUserException();

            var book = await _addressWriteRepository.AddAsync(new()
            {
                UserId = request.UserId,
                Contact = request.Contact,
                CountryRegion = request.CountryRegion,
                AddressDetails = request.AddressDetails,
                PostalCode = request.PostalCode,
                City = request.City
            });

            if (book == null)
            {
                var resp = new CreateAddressCommandResponse
                {
                    Status = "Error",
                    Message = "Don't save address"
                };
                return resp;
            }
            else
            {
                var resp = new CreateAddressCommandResponse
                {
                    Status = "Succes",
                    Message = "Succesfully save address"
                };
                return resp;
            }
        }
    }
}
