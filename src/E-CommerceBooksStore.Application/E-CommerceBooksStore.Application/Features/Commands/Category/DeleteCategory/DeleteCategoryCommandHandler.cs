using E_CommerceBooksStore.Application.Repositories.Categories;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Category.DeleteCategory
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest, DeleteCategoryCommandResponse>
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;

        public DeleteCategoryCommandHandler(ICategoryReadRepository categoryReadRepository,
                                            ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
        }

        public async Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var serachResult = await _categoryReadRepository.GetByIdAsync(request.Id);
            if (serachResult != null)
            {
                var author =  _categoryWriteRepository.Remove(serachResult);
                await _categoryWriteRepository.SaveAsync();
            }
            else return new();
            return new();
        }
    }
}
