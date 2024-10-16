using FluentValidation;
using JubaHub.Domain.Types;

namespace JubaHub.Domain.Validators;

public class EmailValidator : AbstractValidator<Email>
{
    public EmailValidator()
    {
        RuleFor(email => email.Value)
            .NotEmpty().WithMessage("Email cannot be empty.")
            .EmailAddress().WithMessage("Email is not valid.");
    }
}