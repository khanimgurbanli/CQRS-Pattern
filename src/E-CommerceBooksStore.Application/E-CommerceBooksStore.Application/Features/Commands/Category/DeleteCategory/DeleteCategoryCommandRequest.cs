

using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Category.DeleteCategory
{
    public class DeleteCategoryCommandRequest : IRequest<DeleteCategoryCommandResponse>
    {
        public int Id { get; set; }
    }
}
