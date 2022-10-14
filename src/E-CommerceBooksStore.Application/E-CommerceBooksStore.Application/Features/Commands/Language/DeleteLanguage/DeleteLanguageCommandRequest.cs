using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Language.DeleteLanguage
{
    public class DeleteLanguageCommandRequest : IRequest<DeleteLanguageCommandResponse> 
    {
        public int Id { get; set; }
    }
}
