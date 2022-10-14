
using E_CommerceBooksStore.Application.Repositories.Categories;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Category.UpdateCategory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest, UpdateCategoryCommandResponse>
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;

        public UpdateCategoryCommandHandler(ICategoryReadRepository categoryReadRepository,
                                            ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
        }

        public async Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var serachResult = await _categoryReadRepository.SearchCategoryAsync(request.Name);
            if (serachResult != null)
            {
                var author = await _categoryWriteRepository.AddAsync(new()
                {
                    SupCategoryId = request.CategoryId,
                    Name = request.Name,
                });
                await _categoryWriteRepository.SaveAsync();
            }
            else return new();
            return new();
        }
    }
}
