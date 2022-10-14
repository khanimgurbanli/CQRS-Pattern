

using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Languages;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Languages
{
    public class LanguageWriteRepository : WriteRepository<Language, IApplicationDbContext>, ILanguageWriteRepository
    {
        private readonly IApplicationDbContext _context;

        public LanguageWriteRepository(IApplicationDbContext context) : base(context) { _context = context; }
    }
}
