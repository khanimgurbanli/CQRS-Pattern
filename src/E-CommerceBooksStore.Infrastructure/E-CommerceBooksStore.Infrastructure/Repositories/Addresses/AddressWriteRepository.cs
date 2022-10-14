

using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Addresses;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Addresses
{
    public class AddressWriteRepository : WriteRepository<Address, IApplicationDbContext>, IAddressWriteRepository
    {
        public AddressWriteRepository(IApplicationDbContext context) : base(context) { }
    }
}
