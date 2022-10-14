

using BookApi.Domain.Entities;
using E_CommerceBooksStore.Application.Base;
using E_CommerceBooksStore.Domain.Entities;
    
namespace BookApi.Application.Repositories.Formats
{
    public interface IFormatReadRepository : IReadRepository<Format>
    {
        Task<Format> SearchFormatAsync(string search, bool tracking = true);
    }
}
