

using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Authors;
using E_CommerceBooksStore.Application.Repositories.Baskets;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;

namespace BookApi.Infrastructure.Repositories.Baskets
{
    public class BasketWriteRepository : WriteRepository<BasketItem, IApplicationDbContext>, IBasketWritedRepository
    {
        public BasketWriteRepository(IApplicationDbContext context) : base(context) { }
    }
}
