using ErrorOr;
using MediatR;
using VueTalk.Application.Authentication.Common;

namespace VueTalk.Application.Authentication.Queries.Login;



public record LoginQuery(string Email, string Password) : IRequest<ErrorOr<AuthenticationResult>>;
