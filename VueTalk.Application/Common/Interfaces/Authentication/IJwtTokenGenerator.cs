

using VueTalk.Domain.UserAggregate;

namespace VueTalk.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}