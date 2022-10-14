
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Genre.CreateGenre
{
    public class CreateGenreCommandRequest : IRequest<CreateGenreCommandResponse>
    {
        public string Name { get; set; } = null!;
    }
}
