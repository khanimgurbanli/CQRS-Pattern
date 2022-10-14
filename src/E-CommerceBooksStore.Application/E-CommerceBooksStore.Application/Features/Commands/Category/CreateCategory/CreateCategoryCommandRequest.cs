

using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Category.CreateCategory
{
    public class CreateCategoryCommandRequest : IRequest<CreateCategoryCommandResponse>
    {
        public int CategoryId { get; set; } 
        public string Name { get; set; } = null!;
    }
}
