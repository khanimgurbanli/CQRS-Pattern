
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Publisher.CreatePublisher
{
    public class CreatePublisherCommandRequest : IRequest<CreatePublisherCommandResponse>
    {
        public string Name { get; set; } = null!;
    }
}
