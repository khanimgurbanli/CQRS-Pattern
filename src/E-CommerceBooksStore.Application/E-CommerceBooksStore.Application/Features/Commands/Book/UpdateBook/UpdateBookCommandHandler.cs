
using E_CommerceBooksStore.Application.Repositories.Books;
using MediatR;
using MediatR.Pipeline;
using Microsoft.AspNetCore.Http;

namespace E_CommerceBooksStore.Application.Features.Commands.Book.UpdateBook
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommandRequest, UpdateBookCommandResponse>
    {
        private readonly IBookWriteRepository _bookWriteRepository;
        private readonly IBookReadRepository _bookReadRepository;

        public UpdateBookCommandHandler(IBookWriteRepository bookWriteRepository,
                                        IBookReadRepository _readRepository)
        {
            _bookWriteRepository = bookWriteRepository;
        }

        public async Task<UpdateBookCommandResponse> Handle(UpdateBookCommandRequest request, CancellationToken cancellationToken)
        {
            var book = await _bookReadRepository.GetByIdAsync(request.Id);
            var statusCode = await _bookWriteRepository.SaveAsync();

            if (statusCode == 0)
            {
                var resp = new UpdateBookCommandResponse
                {
                    Status = "Error",
                    Message = "Don't save book"
                };
                return resp;
            }
            else
            {
                var resp = new UpdateBookCommandResponse
                {
                    Status = "Succes",
                    Message = "Succesfully save book"
                };
                return resp;
            }
        }
    }
}
