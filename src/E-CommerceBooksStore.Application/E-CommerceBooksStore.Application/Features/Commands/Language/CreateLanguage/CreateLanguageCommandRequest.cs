
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Language.CreateLanguage
{
    public class CreateLanguageCommandRequest : IRequest<CreateLanguageCommandResponse>
    {
        public string Name { get; set; } = null!;
    }
}
