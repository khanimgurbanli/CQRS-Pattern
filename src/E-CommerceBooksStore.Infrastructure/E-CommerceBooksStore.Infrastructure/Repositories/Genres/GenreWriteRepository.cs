using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Genres;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Genres
{
    public class GenreWriteRepository : WriteRepository<Genre, IApplicationDbContext>, IGenreWriteRepository
    {
        public GenreWriteRepository(IApplicationDbContext context) : base(context) { }
    }
}
