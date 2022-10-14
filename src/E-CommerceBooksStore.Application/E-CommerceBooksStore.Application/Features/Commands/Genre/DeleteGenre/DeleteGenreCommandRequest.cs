

using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Genre.DeleteGenre
{
    public class DeleteGenreCommandRequest : IRequest<DeleteGenreCommandResponse>
    {
        public int Id { get; set; }
    }
}
