using FluentValidation;
using JubaHub.Domain.Types;

namespace JubaHub.Domain.Validators;

public class PhoneNumberValidator : AbstractValidator<PhoneNumber>
{
    public PhoneNumberValidator()
    {
        RuleFor(phone => phone.Value)
            .NotEmpty().WithMessage("Phone number cannot be empty.")
            .Matches(@"^\+?\d{10,15}$").WithMessage("Phone number is not valid.");
    }
}