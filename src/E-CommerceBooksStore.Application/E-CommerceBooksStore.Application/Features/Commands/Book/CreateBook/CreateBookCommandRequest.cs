
using MediatR;

namespace E_CommerceBooksStore.Application.Features.Commands.Book.CreateBook
{
    public class CreateBookCommandRequest : IRequest<CreateBookCommandResponse>
    {
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int PubliserId { get; set; }
        public int VendorId { get; set; }
        public int GenreId { get; set; }
        public string Name { get; set; } = String.Empty;
        public string? Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;//iformfilee
        public DateTime PublicationYear { get; set; }
        public int PriceId { get; set; }
        public int? NumPages { get; set; }
        public double? Discount { get; set; }
        public double? Rate { get; set; }
        public int Stock { get; set; }
    }
}
