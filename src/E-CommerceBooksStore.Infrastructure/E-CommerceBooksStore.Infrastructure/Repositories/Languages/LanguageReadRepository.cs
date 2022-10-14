

using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Languages;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Languages
{
    public class LanguageReadRepository : ReadRepository<Language, IApplicationDbContext>, ILanguageReadRepository
    {
      private IApplicationDbContext _context;

        public LanguageReadRepository(IApplicationDbContext context) : base(context) { _context = context; }

        public async  Task<Language> SearchLanguageAsync(string search, bool tracking = true)
        {
            return await _context.Languages.FirstOrDefaultAsync(x => x.Name == search);
        }
    }
}
