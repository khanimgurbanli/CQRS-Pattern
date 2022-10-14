using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Order.UpdateOrder
{
    public class UpdateOrderCommandRequest : IRequest<UpdateOrderCommandResponse>
    {
        public int UpdateCommandId { get; set; }
    }
}
