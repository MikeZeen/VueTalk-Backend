using VueTalk.Domain.Common.Models;

namespace VueTalk.Domain.AuthorAggregate.ValueObjects;

public sealed class AuthorId : ValueObject
{
    public Guid Value { get; }

    private AuthorId(Guid value)
    {
        Value = value;
    }

    public static AuthorId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
