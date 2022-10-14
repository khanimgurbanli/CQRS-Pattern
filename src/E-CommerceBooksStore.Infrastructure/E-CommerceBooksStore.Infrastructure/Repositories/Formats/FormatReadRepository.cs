

using BookApi.Application.Repositories.Formats;
using BookApi.Domain.Entities;
using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Infrastructure.Base;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Infrastructure.Repositories.Formats
{
    public class FormatReadRepository : ReadRepository<Format, IApplicationDbContext>, IFormatReadRepository
    {
        private readonly IApplicationDbContext _applicationDbContext;
        public FormatReadRepository(IApplicationDbContext context) : base(context) { this._applicationDbContext = context; }

        public async Task<Format> SearchFormatAsync(string search, bool tracking = true)
        {
            return await _applicationDbContext.Formats.FirstOrDefaultAsync(x => x.Name == search);
        }
    }
}
