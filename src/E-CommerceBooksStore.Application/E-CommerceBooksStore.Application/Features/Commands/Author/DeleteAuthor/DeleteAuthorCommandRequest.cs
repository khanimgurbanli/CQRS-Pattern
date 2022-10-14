
using BookApi.Application.Features.Commands.StatusMessageResponse;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Author.DeleteAuthor
{
    public class DeleteAuthorCommandRequest : IRequest<DeleteAuthorCommandResponse>
    {
        public int Id { get; set; }
    }
}
