using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Authors;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Authors
{
    public class AuthorWriteRepository : WriteRepository<Author, IApplicationDbContext>, IAuthorWriteRepository
    {
        public AuthorWriteRepository(IApplicationDbContext context) : base(context) { }
    }
}
