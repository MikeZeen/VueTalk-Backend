using VueTalk.Domain.UserAggregate;

namespace VueTalk.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);