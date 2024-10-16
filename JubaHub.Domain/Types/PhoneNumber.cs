using FluentValidation;
using JubaHub.Domain.Validators;

namespace JubaHub.Domain.Types;

public class PhoneNumber
{
    public string Value { get; private set; }

    public PhoneNumber(string value)
    {
        Value = value;

        var validator = new PhoneNumberValidator();
        var result = validator.Validate(this);

        if (!result.IsValid)
            throw new ValidationException(result.Errors);
    }

    public override string ToString()
        => Value;

    public override bool Equals(object obj)
        => obj is PhoneNumber otherPhoneNumber && Value.Equals(otherPhoneNumber.Value);

    public override int GetHashCode()
        => Value.GetHashCode();
}