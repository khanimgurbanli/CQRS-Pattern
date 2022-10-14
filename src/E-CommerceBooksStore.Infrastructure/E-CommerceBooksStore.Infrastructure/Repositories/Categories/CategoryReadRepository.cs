
using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Categories;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Categories
{
    public class CategoryReadRepository : ReadRepository<Category, IApplicationDbContext> ,ICategoryReadRepository
    {
        private readonly IApplicationDbContext _applicationDbContext;
        public CategoryReadRepository(IApplicationDbContext context) : base(context) { this._applicationDbContext = context; }

        public async Task<Category> SearchCategoryAsync(string search, bool tracking = true)
        {
            return await _applicationDbContext.Categories.FirstOrDefaultAsync(x => x.Name == search);
        }
    }
}
