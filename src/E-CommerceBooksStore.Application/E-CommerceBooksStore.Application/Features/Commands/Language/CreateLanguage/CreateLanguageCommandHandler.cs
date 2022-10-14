
using E_CommerceBooksStore.Application.Repositories.Languages;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Language.CreateLanguage
{
    public class CreateLanguageCommandHandler : IRequestHandler<CreateLanguageCommandRequest, CreateLanguageCommandResponse>
    {
        private readonly ILanguageWriteRepository _languageWriteRepository;
        private readonly ILanguageReadRepository _languageReadRepository;

        public CreateLanguageCommandHandler(ILanguageWriteRepository languageWriteRepository,
                                           ILanguageReadRepository languageReadRepository)
        {
            _languageWriteRepository = languageWriteRepository;
            _languageReadRepository = languageReadRepository;
        }

        public async Task<CreateLanguageCommandResponse> Handle(CreateLanguageCommandRequest request, CancellationToken cancellationToken)
        {

            var serachResult = await _languageReadRepository.SearchLanguageAsync(request.Name);
            if (serachResult == null)
            {
                var genre = await _languageWriteRepository.AddAsync(new()
                {
                    Name = request.Name
                });
                await _languageWriteRepository.SaveAsync();
            }
            return new();
        }
    }
}
