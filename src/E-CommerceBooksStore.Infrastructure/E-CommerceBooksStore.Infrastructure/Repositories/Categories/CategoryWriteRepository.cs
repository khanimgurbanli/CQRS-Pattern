using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Categories;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Infrastructure.Base;

namespace E_CommerceBooksStore.Infrastructure.Repositories.Categories
{
    public class CategoryWriteRepository : WriteRepository<Category, IApplicationDbContext>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(IApplicationDbContext context) : base(context) { }
    }
}
