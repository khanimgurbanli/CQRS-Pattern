

using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Publisher.DeletePublisher
{
    public class DeletePublisherCommandRequest : IRequest<DeletePublisherCommandResponse>
    {
        public int Id { get; set; }
    }
}
