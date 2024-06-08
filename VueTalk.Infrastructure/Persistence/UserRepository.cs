using VueTalk.Domain.UserAggregate;
using VueTalk.Application.Common.Interfaces.Persistence;

namespace VueTalk.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();
    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
        return _users.FirstOrDefault(x => x.Email == email);
    }
}

