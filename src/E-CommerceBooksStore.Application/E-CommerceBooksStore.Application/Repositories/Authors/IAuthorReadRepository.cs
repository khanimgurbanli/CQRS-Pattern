

using E_CommerceBooksStore.Application.Base;
using E_CommerceBooksStore.Domain.Entities;

namespace E_CommerceBooksStore.Application.Repositories.Authors
{
    public interface IAuthorReadRepository : IReadRepository<Author>
    {
        Task<Author> SearchAuthorAsync(string firstName, string lastName, bool tracking = true);
    }
}
