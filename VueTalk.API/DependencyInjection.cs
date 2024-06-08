using Microsoft.AspNetCore.Mvc.Infrastructure;
using VueTalk.API.Common.Errors;
using VueTalk.API.Common.Mapping;

namespace VueTalk.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();

        services.AddSingleton<ProblemDetailsFactory, VueTalkProblemDetailsFactory>();

        services.AddMappings();
        return services;
    }
}
