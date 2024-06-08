using VueTalk.Domain.Entities;

namespace VueTalk.Application.Authentication.Common;

public record AuthenticationResult(
    User User, 
    string Token);