using IndustrialAI.API.Filters;

namespace IndustrialAI.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApiServices(
        this IServiceCollection services)
    {
        services.AddScoped<ValidationFilter>();

        services.AddControllers(options =>
        {
            options.Filters.Add<ValidationFilter>();
        });

        return services;
    }
}