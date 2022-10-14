using E_CommerceBooksStore.Application.Base;
using E_CommerceBooksStore.Domain.Entities;

namespace E_CommerceBooksStore.Application.Repositories.Categories
{
    public interface ICategoryReadRepository : IReadRepository<Category>
    {
        Task<Category> SearchCategoryAsync(string search, bool tracking = true);
    }
}
