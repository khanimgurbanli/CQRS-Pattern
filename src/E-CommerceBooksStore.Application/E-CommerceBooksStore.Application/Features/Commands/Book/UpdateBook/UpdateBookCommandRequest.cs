using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Book.UpdateBook
{
    public class UpdateBookCommandRequest : IRequest<UpdateBookCommandResponse>
    {
        public int Id { get; set; }
    }
}
