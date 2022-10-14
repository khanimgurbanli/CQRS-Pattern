
using BookApi.Application.Common.Exceptions;
using BookApi.Application.Features.Commands.StatusMessageResponse;
using E_CommerceBooksStore.Application.Repositories.Authors;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Author.DeleteAuthor
{
    public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommandRequest, DeleteAuthorCommandResponse>
    {
        private readonly IAuthorWriteRepository _authorWriteRepository;
        private readonly IAuthorReadRepository _authorReadRepository;

        public DeleteAuthorCommandHandler(IAuthorWriteRepository authorWriteRepository, IAuthorReadRepository authorReadRepository)
        {
            this._authorWriteRepository = authorWriteRepository;
            this._authorReadRepository = authorReadRepository;
        }

        public async Task<DeleteAuthorCommandResponse> Handle(DeleteAuthorCommandRequest request, CancellationToken cancellationToken)
        {

            var author = await _authorReadRepository.GetByIdAsync(request.Id);
            if (author != null)
            {
                _authorWriteRepository.Remove(author);
                var addressStatus = await _authorWriteRepository.SaveAsync();

                if (addressStatus == 0)
                {
                    var resp = new DeleteAuthorCommandResponse
                    {
                        Status = "Error",
                        Message = "Don't remove author"
                    };
                    return resp;
                }
                else
                {
                    var resp = new DeleteAuthorCommandResponse
                    {
                        Status = "Success",
                        Message = "Succesfully remove author"
                    };
                    return resp;
                }
            }
            else throw new NotFoundRecordException();
        }
    }
}
