
using E_CommerceBooksStore.Application.Features.Commands.Book.CreateBook;
using FluentValidation;

namespace BookApi.Application.Features.Commands.Book.CreateBook
{
    public class CreateBookCommandValidator : AbstractValidator<CreateBookCommandRequest>
    {
        public CreateBookCommandValidator()
        {
            RuleFor(p => p.Name)
                    .NotEmpty()
                    .NotNull()
                  .MaximumLength(150)
                  .MinimumLength(5)
                      .WithMessage("please, enter the name in the correct format");

            RuleFor(p => p.CategoryId)
                  .NotEmpty()
                  .NotNull()
                    .WithMessage("please, select book any category");

            RuleFor(p => p.AuthorId)
                 .NotEmpty()
                 .NotNull()
                   .WithMessage("please, select any author");

            RuleFor(p => p.PubliserId)
                 .NotEmpty()
                 .NotNull()
                   .WithMessage("please, select any publisher");

            RuleFor(p => p.VendorId)
                .NotEmpty()
                .NotNull()
                  .WithMessage("please, select any vendor");

            RuleFor(p => p.GenreId)
               .NotEmpty()
               .NotNull()
                 .WithMessage("please, select any genre");

            RuleFor(p => p.Title)
                   .NotEmpty()
                   .NotNull()
                 .MaximumLength(150)
                 .MinimumLength(5)
                     .WithMessage("please,enter the title text min 5 max 150 caracter");

            RuleFor(p => p.Description)
                   .NotEmpty()
                   .NotNull()
                 .MaximumLength(150)
                 .MinimumLength(5)
                     .WithMessage("please,enter the description text min 5 max 150 caracter");

            RuleFor(p => p.PublicationYear)
            .NotEmpty()
            .NotNull()
              .WithMessage("please,enter the publisher year in the correct format");

            RuleFor(p => p.NumPages)
               .NotEmpty()
               .NotNull()
                     .WithMessage("please,enter book of page count in the correct ")
                      .Must(s => s >= 0)
                    .WithMessage("Book of page count information cannot be negative!");


            RuleFor(p => p.Stock)
               .NotEmpty()
               .NotNull()
                     .WithMessage("please,enter book of amount in the correct ")
                     .Must(s => s >= 0)
                    .WithMessage("Price information cannot be negative!");
        }
    }
}
