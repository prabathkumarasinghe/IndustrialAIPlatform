using IndustrialAI.API.Middlewares;

namespace IndustrialAI.API.Extensions;

public static class MiddlewareExtensions
{
    public static IApplicationBuilder UseApplicationMiddleware(
        this IApplicationBuilder app)
    {
        app.UseMiddleware<LoggingMiddleware>();

        app.UseMiddleware<ExceptionMiddleware>();

        app.UseHttpsRedirection();

        app.UseAuthentication();

        app.UseAuthorization();

        return app;
    }
}