
using E_CommerceBooksStore.Application.Features.Commands.Order.CreateOrder;
using E_CommerceBooksStore.Application.Repositories.Orders;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Order.DeleteOrder
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommandRequest, CreateOrderCommandResponse>
    {
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IOrderReadRepository _orderReadRepository;

        public DeleteOrderCommandHandler(IOrderWriteRepository orderWriteRepository,
                                         IOrderReadRepository orderReadRepository)
        {
            _orderWriteRepository = orderWriteRepository;
        }

        public async Task<CreateOrderCommandResponse> Handle(DeleteOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var order = await _orderReadRepository.GetByIdAsync(request.DeleteCoomandId);
            if (order != null)
            {
                _orderWriteRepository.Remove(order);
                await _orderWriteRepository.SaveAsync();
            }
            return new();
        }
    }
}
