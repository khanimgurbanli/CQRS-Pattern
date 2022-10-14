
using E_CommerceBooksStore.Application.Repositories.Addresses;
using E_CommerceBooksStore.Application.Repositories.Orders;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace E_CommerceBooksStore.Application.Features.Commands.Order.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IAddressWriteRepository _addressWriteRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CreateOrderCommandHandler(IOrderWriteRepository orderWriteRepository,
                                         IHttpContextAccessor httpContextAccessor,
                                         IAddressWriteRepository addressWriteRepository)
        {
            this._httpContextAccessor = httpContextAccessor;
            this._orderWriteRepository = orderWriteRepository;
            this._addressWriteRepository = addressWriteRepository;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            ClaimsIdentity claimsIdentity = (ClaimsIdentity)_httpContextAccessor.HttpContext.User.Identity;
            var userIdClaim = claimsIdentity.Claims.SingleOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            if (userIdClaim != null)
            {
                request.UserId = userIdClaim.Value;
            }
            if (request.AddressId == null)
            {
               var address= await _addressWriteRepository.AddAsync(new()
                {
                    UserId = request.UserId,
                    Contact = request.Contact,
                    CountryRegion = request.CountryRegion,
                    AddressDetails = request.AddressDetails,
                    PostalCode = request.PostalCode,
                    City = request.City
                });
                await _addressWriteRepository.SaveAsync();
                request.AddressId=address.Id;
            }
            var order = await _orderWriteRepository.AddAsync(new()
            {
                UserId = request.UserId,
                //AddressId=request.UserId,
                Email = request.Email,
                Phone = request.Phone,
                Description = request.Description,
                OrderCode = request.OrderCode,
                Shipping = request.Shipping
            });
            return new CreateOrderCommandResponse();
        }
    }
}
