using JubaHub.Domain.Interfaces;
using JubaHub.Domain.Types;

namespace JubaHub.Domain.Models;

public class Youth(string firstName, string lastName, Email email, PhoneNumber phone, DateTime dateOfBirth) : IPerson
{
    public Guid PersonId { get; private set; } = Guid.NewGuid();
    public string FirstName { get; private set; } = firstName;
    public string LastName { get; private set; } = lastName;
    public Email Email { get; private set; } = email;
    public PhoneNumber Phone { get; private set; } = phone;
    public DateTime DateOfBirth { get; private set; } = dateOfBirth;

    public void UpdatePhone(PhoneNumber newPhone)
        => Phone = newPhone;
}