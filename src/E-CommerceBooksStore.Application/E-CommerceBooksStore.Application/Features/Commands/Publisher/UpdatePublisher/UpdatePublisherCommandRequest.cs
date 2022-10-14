
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Publisher.UpdatePublisher
{
    public class UpdatePublisherCommandRequest :  IRequest<UpdatePublisherCommandResponse>
    {
        public int Id { get; set; }
    }
}
