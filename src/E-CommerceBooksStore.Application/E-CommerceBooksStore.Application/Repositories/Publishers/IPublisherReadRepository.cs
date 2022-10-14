using E_CommerceBooksStore.Application.Base;
using E_CommerceBooksStore.Domain.Entities;

namespace E_CommerceBooksStore.Application.Repositories.Publishers
{
    public interface IPublisherReadRepository : IReadRepository<Publisher>
    {
        Task<Publisher> SearchPublisherAsync(string search, bool tracking = true);
    }
}

