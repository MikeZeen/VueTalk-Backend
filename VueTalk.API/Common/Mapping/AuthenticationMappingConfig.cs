using Mapster;
using VueTalk.Application.Authentication.Commands.Register;
using VueTalk.Application.Authentication.Common;
using VueTalk.Application.Authentication.Queries.Login;
using VueTalk.Contracts.Authentication;

namespace VueTalk.API.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();

        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest.Id, src => src.User.Id.Value)
            .Map(dest => dest, src => src.User);
    }
}
