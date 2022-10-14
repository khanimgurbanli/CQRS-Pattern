
using E_CommerceBooksStore.Application.Features.Commands.Order.CreateOrder;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Order.DeleteOrder
{
    public class DeleteOrderCommandRequest : IRequest<CreateOrderCommandResponse>
    {
        public int DeleteCoomandId { get; set; }
    }
}
