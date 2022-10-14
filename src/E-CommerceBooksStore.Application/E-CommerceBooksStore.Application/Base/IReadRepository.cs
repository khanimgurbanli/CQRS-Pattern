using E_CommerceBooksStore.Domain.Common;

namespace E_CommerceBooksStore.Application.Base
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseAuditableEntity
    {
        IQueryable<T> GetAll(bool tracking = true);
        Task<T> GetByIdAsync(int id, bool tracking = true);
    }
}
