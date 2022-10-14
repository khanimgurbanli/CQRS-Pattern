

using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Genres;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Genres
{
    public class GenreReadRepository : ReadRepository<Genre, IApplicationDbContext>, IGenreReadRepository
    {
        private readonly IApplicationDbContext _applicationDbContext;
        public GenreReadRepository(IApplicationDbContext context) : base(context) { _applicationDbContext = context; }

        public async Task<Genre> SearchGenreAsync(string search, bool tracking = true)
        {
            return await _applicationDbContext.Genres.FirstOrDefaultAsync(x => x.Name == search);
        }
    }
}
