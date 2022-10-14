

using BookApi.Application.Features.Commands.StatusMessageResponse;
using E_CommerceBooksStore.Application.Features.Commands.Address.UpdateAddress;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Author.CreateAuthor
{
    public class CreateAuthorCommandRequest : IRequest<CreateAuthorCommandResponse>
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string? Bio { get; set; } = String.Empty;
    }
}
