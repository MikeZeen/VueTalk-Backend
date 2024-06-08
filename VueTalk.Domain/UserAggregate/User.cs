using VueTalk.Domain.Common.Models;
using VueTalk.Domain.UserAggregate.ValueObjects;

namespace VueTalk.Domain.UserAggregate;

public sealed class User : AggregateRoot<UserId>
{
    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public string Password { get; } // TODO: Hash this

    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private User(
        UserId userId,
        string firstName, 
        string lastName, 
        string email, 
        string password)
        : base(userId)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    public static User Create(
        string firstName, 
        string lastName, 
        string email, 
        string password)
    {
        return new User(
            UserId.CreateUnique(),
            firstName,
            lastName,
            email,
            password);
    }
}