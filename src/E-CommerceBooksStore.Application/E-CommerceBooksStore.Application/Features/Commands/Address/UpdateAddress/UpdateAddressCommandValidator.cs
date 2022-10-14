﻿

using E_CommerceBooksStore.Application.Features.Commands.Address.UpdateAddress;
using FluentValidation;

namespace BookApi.Application.Features.Commands.Address.UpdateAddress
{
    public class UpdateAddressCommandValidator :  AbstractValidator<UpdateAddressCommandRequest>
    {
        public UpdateAddressCommandValidator()
        {
            RuleFor(p => p.CountryRegion)
               .MaximumLength(150)
               .MinimumLength(5)
                   .WithMessage("please,the country or region name in the correct format");

            RuleFor(p => p.Contact)
                .NotEmpty()
                .NotNull()
              .MaximumLength(150)
              .MinimumLength(5)
                  .WithMessage("please,the phone or email in the correct format");

            RuleFor(p => p.AddressDetails)
              .MaximumLength(150)
              .MinimumLength(5)
                  .WithMessage("please,the address details in the correct format");

            RuleFor(p => p.PostalCode)
                .NotEmpty()
                .NotNull()
              .MaximumLength(150)
              .MinimumLength(5)
                  .WithMessage("please,the postal code the correct format");
        }
    }
}
