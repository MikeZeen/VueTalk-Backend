using VueTalk.Domain.Entities;

namespace VueTalk.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}