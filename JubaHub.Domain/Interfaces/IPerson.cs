using JubaHub.Domain.Types;

namespace JubaHub.Domain.Interfaces;

public interface IPerson
{
    Guid PersonId { get; }
    string FirstName { get; }
    string LastName { get; }
    Email Email { get; }
    PhoneNumber Phone { get; }

    void UpdatePhone(PhoneNumber newPhone);
}