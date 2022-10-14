using E_CommerceBooksStore.Application.Base;
using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace E_CommerceBooksStore.Infrastructure.Base
{
    public class WriteRepository<T, Tcontext> : IWriteRepository<T> where T : BaseAuditableEntity where Tcontext : IApplicationDbContext
    {
        private readonly IApplicationDbContext _context;
        public WriteRepository(IApplicationDbContext context) => _context = context;

        //public DbSet<T> Table1 => _context.Set<T>();

        public DbSet<T> Table => Table;

        public async Task<T> AddAsync(T model)
        {
            //EntityEntry<T> entityEntry = await Table.AddAsync(model);
            EntityEntry entityEntry = await Table.AddAsync(model);
            await SaveAsync();//save edende yoxla
            return (T)entityEntry.Entity;
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool RemoveRange(IQueryable<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            T model = await Table.FirstOrDefaultAsync(data => data.Id == id);
            return Remove(model);
        }

        public bool Update(T model)
        {
            EntityEntry entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }

        public bool UpdateRange(List<T> datas)
        {
            Table.UpdateRange(datas);
            return true;
        }

        public async Task<int> SaveAsync()
          => await _context.SaveChangesAsync();
    }
}
