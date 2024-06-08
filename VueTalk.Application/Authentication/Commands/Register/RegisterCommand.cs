using ErrorOr;
using MediatR;
using VueTalk.Application.Authentication.Common;

namespace VueTalk.Application.Authentication.Commands.Register;


public record RegisterCommand(string FirstName, string LastName, string Email, string Password) : IRequest<ErrorOr<AuthenticationResult>>;
