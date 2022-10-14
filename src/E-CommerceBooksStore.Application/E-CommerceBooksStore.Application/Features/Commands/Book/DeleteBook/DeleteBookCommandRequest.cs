using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Book.DeleteBook
{
    public class DeleteBookCommandRequest : IRequest<DeleteBookCommandResponse>
    {
        public int Id { get; set; }
    }
}
