using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Orders;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Orders
{
    public class OrderWriteRepository : WriteRepository<Order, IApplicationDbContext>, IOrderWriteRepository
    {
        public OrderWriteRepository(IApplicationDbContext context) : base(context) { }
    }
}
