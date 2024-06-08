using VueTalk.Domain.UserAggregate;

namespace VueTalk.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}

