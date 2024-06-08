﻿using VueTalk.Application.Common.Interfaces.Authentication;
using VueTalk.Application.Common.Interfaces.Persistence;
using VueTalk.Domain.Entities;
using VueTalk.Domain.Common.Errors;
using ErrorOr;
using MediatR;
using VueTalk.Application.Authentication.Common;

namespace VueTalk.Application.Authentication.Commands.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        if (_userRepository.GetUserByEmail(command.Email) is not null)
        {
            return Errors.User.DuplicateEmail;
        }

        var user = new User
        {
            Email = command.Email,
            Password = command.Password,
            FirstName = command.FirstName,
            LastName = command.LastName
        };

        _userRepository.AddUser(user);

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
}