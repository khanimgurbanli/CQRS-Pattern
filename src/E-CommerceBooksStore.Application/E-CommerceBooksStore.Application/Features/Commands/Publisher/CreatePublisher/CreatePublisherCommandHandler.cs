
using E_CommerceBooksStore.Application.Repositories.Publishers;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Publisher.CreatePublisher
{
    public class CreatePublisherCommandHandler : IRequestHandler<CreatePublisherCommandRequest, CreatePublisherCommandResponse>
    {
        private readonly IPublisherWriteRepository _publisherWriteRepository;
        private readonly IPublisherReadRepository _publisherReadepository;

        public CreatePublisherCommandHandler(IPublisherWriteRepository publisherWriteRepository, IPublisherReadRepository publisherReadepository)
        {
            this._publisherWriteRepository = publisherWriteRepository;
            this._publisherReadepository = publisherReadepository;
        }

        public async Task<CreatePublisherCommandResponse> Handle(CreatePublisherCommandRequest request, CancellationToken cancellationToken)
        {
            var serachResult = await _publisherReadepository.SearchPublisherAsync(request.Name);
            if (serachResult == null)
            {
                var publisher = await _publisherWriteRepository.AddAsync(new()
                {
                    Name = request.Name
                });
                await _publisherWriteRepository.SaveAsync();
            }
            return new();
        }
    }
}
