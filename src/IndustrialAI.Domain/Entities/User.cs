using IndustrialAI.Domain.Common;

namespace IndustrialAI.Domain.Entities;

public class User : BaseEntity
{
    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string Email { get; private set; }

    public string Role { get; private set; }

    public User(
        string firstName,
        string lastName,
        string email,
        string role)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Role = role;
    }
}