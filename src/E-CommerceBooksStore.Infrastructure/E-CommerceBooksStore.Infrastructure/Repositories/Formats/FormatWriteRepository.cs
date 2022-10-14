

using BookApi.Application.Repositories.Formats;
using BookApi.Domain.Entities;
using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Infrastructure.Base;

namespace BookApi.Infrastructure.Repositories.Formats
{
    public class FormatWriteRepository : WriteRepository<Format, IApplicationDbContext>, IFormatWriteRepository
    {
        public FormatWriteRepository(IApplicationDbContext context) : base(context) { }
    }
}
