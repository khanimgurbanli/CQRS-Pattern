using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Books;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Books
{
    public class BookReadRepository : ReadRepository<Book, IApplicationDbContext>, IBookReadRepository
    {
        private readonly IApplicationDbContext _context;
        public BookReadRepository(IApplicationDbContext context) : base(context) { _context = context; }

        public async  Task<Book> SearchBookAsync(string name, int authorId, int categoryId, int publisherId, bool tracking = true)
        {
            var book = await _context.Books.FirstOrDefaultAsync(x => x.Name == name && 
                                                                      x.AuthorId == authorId &&
                                                                      x.CategoryId==categoryId &&
                                                                      x.PubliserId== publisherId);
            return book;
        }
    }
}
