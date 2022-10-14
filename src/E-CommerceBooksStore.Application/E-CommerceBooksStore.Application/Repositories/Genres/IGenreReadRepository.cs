using E_CommerceBooksStore.Application.Base;
using E_CommerceBooksStore.Domain.Entities;


namespace E_CommerceBooksStore.Application.Repositories.Genres
{
    public interface IGenreReadRepository : IReadRepository<Genre>
    {
        Task<Genre> SearchGenreAsync(string search, bool tracking = true);
    }
}
