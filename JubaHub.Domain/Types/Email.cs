using FluentValidation;
using JubaHub.Domain.Validators;

namespace JubaHub.Domain.Types;

public class Email
{
    public string Value { get; private set; }

    public Email(string value)
    {
        Value = value;

        var validator = new EmailValidator();
        var result = validator.Validate(this);

        if (!result.IsValid)
            throw new ValidationException(result.Errors);
    }

    public override string ToString()
        => Value;

    public override bool Equals(object obj)
        => obj is Email otherEmail && Value.Equals(otherEmail.Value, StringComparison.OrdinalIgnoreCase);

    public override int GetHashCode()
        => Value.GetHashCode();
}