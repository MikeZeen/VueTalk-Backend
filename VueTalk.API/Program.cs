using VueTalk.Application;
using VueTalk.Infrastructure;
using VueTalk.Api;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddPresentation()
        .AddApplication()
        .AddInfrastructure(builder.Configuration);
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.UseAuthentication();
    app.UseAuthorization();
    app.UseExceptionHandler("/error");
    app.MapControllers();
    app.Run();
}

