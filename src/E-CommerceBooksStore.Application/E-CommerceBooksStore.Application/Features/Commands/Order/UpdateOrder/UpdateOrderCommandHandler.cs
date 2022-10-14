

using E_CommerceBooksStore.Application.Repositories.Orders;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Order.UpdateOrder
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
    {
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IOrderReadRepository _orderReadRepository;

        public UpdateOrderCommandHandler(IOrderWriteRepository orderWriteRepository,
                                         IOrderReadRepository orderReadRepository)
        {
            _orderWriteRepository = orderWriteRepository;
        }

        public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var order = await _orderReadRepository.GetByIdAsync(request.UpdateCommandId);
            _orderWriteRepository.Update(order);
            await _orderWriteRepository.SaveAsync();
            return new UpdateOrderCommandResponse();
        }
    }
}
