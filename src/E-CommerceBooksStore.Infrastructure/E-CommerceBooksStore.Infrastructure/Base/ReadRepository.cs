using E_CommerceBooksStore.Application.Base;
using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceBooksStore.Infrastructure.Base
{
    public class ReadRepository<T, TContext> : IReadRepository<T> where T : BaseAuditableEntity where TContext : IApplicationDbContext
    {
        private readonly IApplicationDbContext _context;
        public ReadRepository(IApplicationDbContext context) => _context = context;

        public DbSet<T> Table => Table;

        public IQueryable<T> GetAll(bool tracking = true) => Table.AsQueryable();

        public async Task<T> GetByIdAsync(int id, bool tracking = true) => await Table.FirstOrDefaultAsync(x => x.Id == id);
    }
}
