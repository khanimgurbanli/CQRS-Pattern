

using E_CommerceBooksStore.Application.Repositories.Languages;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Language.UpdateLanguage
{
    public class UpdateLanguageCommandHandler : IRequestHandler<UpdateLanguageCommandRequest, UpdateLanguageCommandResponse>
    {
        private readonly ILanguageWriteRepository _languageWriteRepository;
        private readonly ILanguageReadRepository _languageReadRepository;

        public UpdateLanguageCommandHandler(ILanguageWriteRepository languageWriteRepository,
                                            ILanguageReadRepository languageReadRepository)
        {
            _languageWriteRepository = languageWriteRepository;
            _languageReadRepository = languageReadRepository;
        }

        public async Task<UpdateLanguageCommandResponse> Handle(UpdateLanguageCommandRequest request, CancellationToken cancellationToken)
        {

            var language = await _languageReadRepository.GetByIdAsync(request.Id);
            if (language != null)
            {
                _languageWriteRepository.Update(language);
                await _languageWriteRepository.SaveAsync();
            }
            return new();
        }
    }
}
