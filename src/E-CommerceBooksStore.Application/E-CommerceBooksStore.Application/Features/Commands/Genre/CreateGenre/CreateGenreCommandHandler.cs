
using E_CommerceBooksStore.Application.Repositories.Genres;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Genre.CreateGenre
{
    public class CreateGenreCommandHandler : IRequestHandler<CreateGenreCommandRequest, CreateGenreCommandResponse>
    {
        private readonly IGenreWriteRepository _genreWriteRepository;
        private readonly IGenreReadRepository _genreReadRepository;

        public CreateGenreCommandHandler(IGenreWriteRepository genreWriteRepository,
                                       IGenreReadRepository genreReadRepository)
        {
            _genreWriteRepository = genreWriteRepository;
            _genreReadRepository = genreReadRepository;
        }
        public async Task<CreateGenreCommandResponse> Handle(CreateGenreCommandRequest request, CancellationToken cancellationToken)
        {
            var serachResult = await _genreReadRepository.SearchGenreAsync(request.Name);
            if (serachResult == null)
            {
                var genre = await _genreWriteRepository.AddAsync(new()
                {
                    Name = request.Name
                });
                await _genreWriteRepository.SaveAsync();
            }
            return new();
        }
    }
}
