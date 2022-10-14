using BookApi.Application.Common.Exceptions;
using E_CommerceBooksStore.Application.Repositories.Books;
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Book.CreateBook
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommandRequest, CreateBookCommandResponse>
    {
        private readonly IBookWriteRepository _bookWriteRepository;
        private readonly IBookReadRepository _bookReadRepository;


        public CreateBookCommandHandler(IBookWriteRepository bookWriteRepository,
                                        IBookReadRepository bookReadRepository)
        {
            this._bookWriteRepository = bookWriteRepository;
            this._bookReadRepository = bookReadRepository;
        }

        public async Task<CreateBookCommandResponse> Handle(CreateBookCommandRequest request, CancellationToken cancellationToken)
        {
            var book = await _bookReadRepository.SearchBookAsync(request.Name, request.AuthorId, request.CategoryId, request.PubliserId);
           
            if (book == null) throw new NotFoundRecordException();

            await _bookWriteRepository.AddAsync(new()
            {
                CategoryId = request.CategoryId,
                AuthorId = request.AuthorId,
                PubliserId = request.PubliserId,
                VendorId = request.VendorId,
                ImageUrl = request.ImageUrl,
                GenreId = request.GenreId,
                PriceId = request.PriceId,
                Name = request.Name.Trim(),
                Title = request.Title.Trim(),
                Description = request.Description.Trim(),
                PublicationYear = request.PublicationYear,
                NumPages = request.NumPages,
                Stock = request.Stock
            });
            await _bookWriteRepository.SaveAsync();
            return new CreateBookCommandResponse(); //helelik ----> bax
        }
    }
}
