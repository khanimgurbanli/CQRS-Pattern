
using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Addresses;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Addresses
{
    public class AddressReadRepository : ReadRepository<Address, IApplicationDbContext>, IAddressReadRepository
    {
        private readonly IApplicationDbContext _context;

        public AddressReadRepository(IApplicationDbContext context) : base(context) { _context = context; }

        public async Task<Address> SearchAddressAsync(string userId, int adrresId, bool tracking = true)
        {
            var address = await _context.Addresses.FirstOrDefaultAsync(x => x.UserId == userId && x.Id == adrresId);
            return address;
        }
    }
}
