

using E_CommerceBooksStore.Application.Repositories.Genres;
using E_CommerceBooksStore.Application.Repositories.Orders;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Genre.UpdateGenre
{
    public class DeleteGenreCommandHandler : IRequestHandler<DeleteGenreCommandRequest, DeleteGenreCommandResponse>
    {
        private readonly IGenreWriteRepository _genreWriteRepository;
        private readonly IGenreReadRepository _genreReadRepository;

        public DeleteGenreCommandHandler(IGenreWriteRepository genreWriteRepository, IGenreReadRepository genreReadRepository)
        {
            _genreWriteRepository = genreWriteRepository;
            _genreReadRepository = genreReadRepository;
        }

        public async Task<DeleteGenreCommandResponse> Handle(DeleteGenreCommandRequest request, CancellationToken cancellationToken)
        {
            var genre = await _genreReadRepository.GetByIdAsync(request.Id);
            if (genre != null)
            {
                _genreWriteRepository.Update(genre);
                await _genreWriteRepository.SaveAsync();
            }
            return new();
        }
    }
}
