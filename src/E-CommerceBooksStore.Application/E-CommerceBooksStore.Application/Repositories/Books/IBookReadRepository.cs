using E_CommerceBooksStore.Application.Base;
using E_CommerceBooksStore.Domain.Entities;

namespace E_CommerceBooksStore.Application.Repositories.Books
{
    public interface IBookReadRepository : IReadRepository<Book> {
        Task<Book> SearchBookAsync(string name, int authorId, int categoryId,int publisherId,bool tracking = true);
    }
}
