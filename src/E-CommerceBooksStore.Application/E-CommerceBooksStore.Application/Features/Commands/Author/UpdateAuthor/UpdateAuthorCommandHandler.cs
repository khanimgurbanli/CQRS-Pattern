

using BookApi.Application.Common.Exceptions;
using BookApi.Application.Features.Commands.StatusMessageResponse;
using E_CommerceBooksStore.Application.Repositories.Authors;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Author.UpdateAuthor
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommandRequest, UpdateAuthorCommandResponse>
    {
        private readonly IAuthorWriteRepository _authorWriteRepository;
        private readonly IAuthorReadRepository _authorReadRepository;

        public UpdateAuthorCommandHandler(IAuthorWriteRepository authorWriteRepository, IAuthorReadRepository authorReadRepository)
        {
            this._authorWriteRepository = authorWriteRepository;
            this._authorReadRepository = authorReadRepository;
        }

        public async Task<UpdateAuthorCommandResponse> Handle(UpdateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            var author = await _authorReadRepository.GetByIdAsync(request.Id);
            if (author != null)
            {
                _authorWriteRepository.Update(author);
                var addressStatus = await _authorWriteRepository.SaveAsync();

                if (addressStatus == 0)
                {
                    var resp = new UpdateAuthorCommandResponse
                    {
                        Status = "Error",
                        Message = "Don't update author"
                    };
                    return resp;
                }
                else
                {
                    var resp = new UpdateAuthorCommandResponse
                    {
                        Status = "Success",
                        Message = "Succesfully update author"
                    };
                    return resp;
                }
            }
            else throw new NotFoundRecordException();
        }
    }
}
