using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Orders;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Orders
{
    public class OrderReadRepository :ReadRepository<Order, IApplicationDbContext> ,IOrderReadRepository
    {
        public OrderReadRepository(IApplicationDbContext context) : base(context) { }
    }
}
