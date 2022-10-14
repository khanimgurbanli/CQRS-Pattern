using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Books;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Books
{
    public class BookWriteRepository : WriteRepository<Book, IApplicationDbContext>, IBookWriteRepository
    {
        public BookWriteRepository(IApplicationDbContext context) : base(context) { }
    }
}
