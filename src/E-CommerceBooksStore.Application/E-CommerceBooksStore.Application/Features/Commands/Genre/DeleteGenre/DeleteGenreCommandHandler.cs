

using E_CommerceBooksStore.Application.Repositories.Genres;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Genre.DeleteGenre
{
    public class DeleteGenreCommandHandler : IRequestHandler<DeleteGenreCommandRequest, DeleteGenreCommandResponse>
    {
        private readonly IGenreReadRepository _genreReadRepository;
        private readonly IGenreWriteRepository _genreWriteRepository;

        public DeleteGenreCommandHandler(IGenreReadRepository genreReadRepository, IGenreWriteRepository genreWriteRepository)
        {
            _genreReadRepository = genreReadRepository;
            _genreWriteRepository = genreWriteRepository;
        }

        public async Task<DeleteGenreCommandResponse> Handle(DeleteGenreCommandRequest request, CancellationToken cancellationToken)
        {
            var genre = await _genreReadRepository.GetByIdAsync(request.Id);
            if (genre != null)
            {
                _genreWriteRepository.Remove(genre);
                await _genreWriteRepository.SaveAsync();
            }
            return new();
        }
    }
}
