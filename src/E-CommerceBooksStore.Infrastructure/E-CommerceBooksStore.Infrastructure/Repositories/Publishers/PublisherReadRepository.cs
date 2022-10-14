using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Publishers;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;
using E_CommerceBooksStore.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Publishers
{
    public class PublisherReadRepository : ReadRepository<Publisher, ApplicationDbContext>, IPublisherReadRepository
    {
        private readonly IApplicationDbContext _applicationDbContext;
        public PublisherReadRepository(ApplicationDbContext context) : base(context) { _applicationDbContext = context;}
        public async Task<Publisher> SearchPublisherAsync(string search, bool tracking = true)
        {
            return await _applicationDbContext.Publishers.FirstOrDefaultAsync(x => x.Name == search);
        }
    }
}
