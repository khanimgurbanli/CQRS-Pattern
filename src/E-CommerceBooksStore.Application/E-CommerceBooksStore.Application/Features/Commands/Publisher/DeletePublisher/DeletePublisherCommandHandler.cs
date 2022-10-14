
using E_CommerceBooksStore.Application.Repositories.Publishers;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Publisher.DeletePublisher
{
    public class DeletePublisherCommandHandler : IRequestHandler<DeletePublisherCommandRequest, DeletePublisherCommandResponse>
    {
        private readonly IPublisherWriteRepository _publisherWriteRepository;
        private readonly IPublisherReadRepository _publisherReadRepository;

        public DeletePublisherCommandHandler(IPublisherWriteRepository publisherWriteRepository,
                                             IPublisherReadRepository publisherReadRepository)
        {
            _publisherWriteRepository = publisherWriteRepository;
            _publisherReadRepository = publisherReadRepository;
        }
        public async Task<DeletePublisherCommandResponse> Handle(DeletePublisherCommandRequest request, CancellationToken cancellationToken)
        {
            var publisher = await _publisherReadRepository.GetByIdAsync(request.Id);
            _publisherWriteRepository.Remove(publisher);
            await _publisherWriteRepository.SaveAsync();

            return new();
        }
    }
}
