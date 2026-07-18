namespace IndustrialAI.API.Middlewares;

public sealed class LoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<LoggingMiddleware> _logger;

    public LoggingMiddleware(
        RequestDelegate next,
        ILogger<LoggingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        _logger.LogInformation(
            "Incoming Request: {Method} {Path}",
            context.Request.Method,
            context.Request.Path);

        var start = DateTime.UtcNow;

        await _next(context);

        var elapsed = DateTime.UtcNow - start;

        _logger.LogInformation(
            "Outgoing Response: {StatusCode} ({Elapsed} ms)",
            context.Response.StatusCode,
            elapsed.TotalMilliseconds);
    }
}