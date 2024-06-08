using ErrorOr;

namespace VueTalk.Domain.Common.DomainErrors;

public static partial class Errors
{
    public static class User
    {
        public static Error DuplicateEmail = Error.Conflict(code: "User.DuplicateEmail", description: "Email already exists");
    }
}