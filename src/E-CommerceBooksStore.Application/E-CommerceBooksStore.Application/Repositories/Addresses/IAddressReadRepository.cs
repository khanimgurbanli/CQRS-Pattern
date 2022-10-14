
using E_CommerceBooksStore.Application.Base;
using E_CommerceBooksStore.Domain.Entities;

namespace E_CommerceBooksStore.Application.Repositories.Addresses
{
    public interface IAddressReadRepository : IReadRepository<Address>
    {
        Task<Address> SearchAddressAsync(string userId, int adrresId, bool tracking = true);
    }
}
