
using E_CommerceBooksStore.Application.Repositories.Languages;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Language.DeleteLanguage
{
    public class DeleteLanguageCommandHandler : IRequestHandler<DeleteLanguageCommandRequest, DeleteLanguageCommandResponse>
    {
        private readonly ILanguageWriteRepository _languageWriteRepository;
        private readonly ILanguageReadRepository _languageReadRepository;

        public DeleteLanguageCommandHandler(ILanguageWriteRepository languageWriteRepository,
                                           ILanguageReadRepository languageReadRepository)
        {
            _languageWriteRepository = languageWriteRepository;
            _languageReadRepository = languageReadRepository;
        }

        public async Task<DeleteLanguageCommandResponse> Handle(DeleteLanguageCommandRequest request, CancellationToken cancellationToken)
        {
            var language = await _languageReadRepository.GetByIdAsync(request.Id);
            if (language != null)
            {
                _languageWriteRepository.Remove(language);
                await _languageWriteRepository.SaveAsync();
            }
            return new();
        }
    }
}
