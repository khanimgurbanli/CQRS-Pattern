

using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Author.UpdateAuthor
{
    public class UpdateAuthorCommandRequest : IRequest<UpdateAuthorCommandResponse>
    {
        public int Id { get; set; }
    }
}
