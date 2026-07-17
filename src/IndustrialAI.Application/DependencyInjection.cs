using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace IndustrialAI.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Register MediatR
        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        // Register AutoMapper
       // services.AddAutoMapper(Assembly.GetExecutingAssembly());

        // Register FluentValidation
       // object value = services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());



        return services;
    }
}