

using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Language.UpdateLanguage
{
    public class UpdateLanguageCommandRequest : IRequest<UpdateLanguageCommandResponse> 
    {
        public int Id { get; set; }
    }
}
