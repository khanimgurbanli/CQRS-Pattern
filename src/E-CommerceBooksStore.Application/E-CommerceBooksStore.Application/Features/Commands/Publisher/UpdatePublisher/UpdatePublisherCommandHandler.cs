
using E_CommerceBooksStore.Application.Features.Commands.Publisher.DeletePublisher;
using E_CommerceBooksStore.Application.Repositories.Publishers;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Publisher.UpdatePublisher
{
    public class UpdatePublisherCommandHandler : IRequestHandler<UpdatePublisherCommandRequest, UpdatePublisherCommandResponse>
    {
        private readonly IPublisherWriteRepository _publisherWriteRepository;
        private readonly IPublisherReadRepository _publisherReadRepository;

        public UpdatePublisherCommandHandler(IPublisherWriteRepository publisherWriteRepository,
                                             IPublisherReadRepository publisherReadRepository)
        {
            _publisherWriteRepository = publisherWriteRepository;
            _publisherReadRepository = publisherReadRepository;
        }

        public async Task<UpdatePublisherCommandResponse> Handle(UpdatePublisherCommandRequest request, CancellationToken cancellationToken)
        {
            var publisher = await _publisherReadRepository.GetByIdAsync(request.Id);
            _publisherWriteRepository.Update(publisher);//update bax
            await _publisherWriteRepository.SaveAsync();

            return new();
        }
    }
}
