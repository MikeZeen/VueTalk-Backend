using VueTalk.Domain.Entities;

namespace VueTalk.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void AddUser(User user);
}

