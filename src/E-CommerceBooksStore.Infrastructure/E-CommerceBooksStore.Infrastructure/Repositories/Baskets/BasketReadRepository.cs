using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Baskets;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;

namespace BookApi.Infrastructure.Repositories.Baskets
{
    public class BasketReadRepository : ReadRepository<BasketItem, IApplicationDbContext>, IBasketReadRepository
    {
        public BasketReadRepository(IApplicationDbContext context) : base(context) { }
    }
}