

using E_CommerceBooksStore.Application.Base;
using E_CommerceBooksStore.Domain.Entities;

namespace E_CommerceBooksStore.Application.Repositories.Languages
{
    public interface ILanguageReadRepository : IReadRepository<Language>
    {
        Task<Language> SearchLanguageAsync(string search, bool tracking = true);
    }
}
