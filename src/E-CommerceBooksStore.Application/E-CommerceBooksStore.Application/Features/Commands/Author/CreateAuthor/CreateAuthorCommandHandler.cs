

using BookApi.Application.Common.Exceptions;
using BookApi.Application.Features.Commands.StatusMessageResponse;
using E_CommerceBooksStore.Application.Repositories.Authors;
using E_CommerceBooksStore.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace E_CommerceBooksStore.Application.Features.Commands.Author.CreateAuthor
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommandRequest, CreateAuthorCommandResponse>
    {
        private readonly IAuthorWriteRepository _authorWriteRepository;
        private readonly IAuthorReadRepository _authorReadRepository;

        public CreateAuthorCommandHandler(IAuthorWriteRepository authorWriteRepository, IAuthorReadRepository authorReadRepository)
        {
            this._authorWriteRepository = authorWriteRepository;
            this._authorReadRepository = authorReadRepository;
        }

        public async Task<CreateAuthorCommandResponse> Handle(CreateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            var serachResult = await _authorReadRepository.SearchAuthorAsync(request.FirstName, request.LastName);
            if (serachResult == null)
            {
                var author = await _authorWriteRepository.AddAsync(new()
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Bio = request.Bio
                });
                var statusCode = await _authorWriteRepository.SaveAsync();

                if (statusCode == 0)
                {
                    var resp = new CreateAuthorCommandResponse
                    {
                        Status = "Error",
                        Message = "Don't save author"
                    };
                    return resp;
                }
                else
                {
                    var resp = new CreateAuthorCommandResponse
                    {
                        Status = "Succes",
                        Message = "Succesfully save author"
                    };
                    return resp;
                }
            }
            else
            throw new AlreadyExistingException();
        }
    }
}
