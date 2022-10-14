using E_CommerceBooksStore.Domain.Common;

namespace E_CommerceBooksStore.Application.Base
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseAuditableEntity
    {
        Task<T> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> datas);
        bool Remove(T model);
        bool RemoveRange(IQueryable<T> datas);
        Task<bool> RemoveAsync(int id);
        bool Update(T model);
        bool UpdateRange(List<T> datas);

        Task<int> SaveAsync();
    }
}
