
using E_CommerceBooksStore.Application.Features.Commands.Author.CreateAuthor;
using FluentValidation;

namespace BookApi.Application.Features.Commands.Author.CreateAuthor
{
    public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommandRequest>
    {
        public CreateAuthorCommandValidator()
        {
            RuleFor(p => p.FirstName)
                .NotEmpty()
                .NotNull()
              .MaximumLength(150)
              .MinimumLength(5)
                  .WithMessage("please,the firstname in the correct format");

            RuleFor(p => p.LastName)
              .NotEmpty()
              .NotNull()
            .MaximumLength(150)
            .MinimumLength(5)
                .WithMessage("please,the lastname in the correct format");

            RuleFor(p => p.Bio)
            .MaximumLength(150)
            .MinimumLength(5)
                .WithMessage("please,the bio infos in the correct format");
        }
    }
}
