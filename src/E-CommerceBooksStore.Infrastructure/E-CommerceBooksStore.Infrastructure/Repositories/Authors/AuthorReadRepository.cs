
using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Authors;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Authors
{
    public class AuthorReadRepository : ReadRepository<Author, IApplicationDbContext>, IAuthorReadRepository
    {
        private readonly IApplicationDbContext _applicationDbContext;
        public AuthorReadRepository(IApplicationDbContext context) : base(context) { _applicationDbContext = context; }

        public async Task<Author> SearchAuthorAsync(string firstName, string lastName, bool tracking = true)
        {
            var author = await _applicationDbContext.Authors.FirstOrDefaultAsync(x => x.FirstName == firstName && x.LastName == lastName);
            return author;
        }
    }
}
