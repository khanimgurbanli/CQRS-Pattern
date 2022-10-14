
using E_CommerceBooksStore.Application.Features.Commands.Address.CreateAddress;
using E_CommerceBooksStore.Application.Features.Commands.Book.CreateBook;
using E_CommerceBooksStore.Application.Repositories.Books;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Book.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommandRequest, DeleteBookCommandResponse>
    {
        private readonly IBookWriteRepository _bookWriteRepository;

        public DeleteBookCommandHandler(IBookWriteRepository bookWriteRepository)
        {
            _bookWriteRepository = bookWriteRepository;
        }

        public async Task<DeleteBookCommandResponse> Handle(DeleteBookCommandRequest request, CancellationToken cancellationToken)
        {
            await _bookWriteRepository.RemoveAsync(request.Id);
            var statusCode = await _bookWriteRepository.SaveAsync();
            if (statusCode == 0)
            {
                var resp = new DeleteBookCommandResponse
                {
                    Status = "Error",
                    Message = "Don't save book"
                };
                return resp;
            }
            else
            {
                var resp = new DeleteBookCommandResponse
                {
                    Status = "Succes",
                    Message = "Succesfully save book"
                };
                return resp;
            }
        }
    }
}
