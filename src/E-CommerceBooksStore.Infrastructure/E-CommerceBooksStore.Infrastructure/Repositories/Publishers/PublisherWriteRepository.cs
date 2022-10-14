using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Publishers;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Publishers
{
    public class PublisherWriteRepository : WriteRepository<Publisher, IApplicationDbContext>, IPublisherWriteRepository
    {
        public PublisherWriteRepository(IApplicationDbContext context) : base(context) { }
    }
}
