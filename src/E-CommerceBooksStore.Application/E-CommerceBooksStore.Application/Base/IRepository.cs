using E_CommerceBooksStore.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceBooksStore.Application.Base
{
    public interface IRepository<T> where T : BaseAuditableEntity
    {
        DbSet<T> Table { get; }
    }
}
