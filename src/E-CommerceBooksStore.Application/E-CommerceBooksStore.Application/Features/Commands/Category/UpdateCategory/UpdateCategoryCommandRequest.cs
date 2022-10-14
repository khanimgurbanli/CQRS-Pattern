
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Category.UpdateCategory
{
    public class UpdateCategoryCommandRequest : IRequest<UpdateCategoryCommandResponse>
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
    }
}
