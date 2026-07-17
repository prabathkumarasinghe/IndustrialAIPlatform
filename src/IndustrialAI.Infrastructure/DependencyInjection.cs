using Azure;
using Azure.Identity;
using Azure.Search.Documents;
using Azure.Storage.Blobs;
using Azure.Messaging.ServiceBus;
using Azure.AI.OpenAI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using IndustrialAI.Infrastructure.Persistence;

namespace IndustrialAI.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<IndustrialDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection")));

        // Repositories
        // services.AddScoped<IMachineRepository, MachineRepository>();

        services.AddSingleton(_ =>
            new BlobServiceClient(
                configuration["AzureStorage:ConnectionString"]));

        services.AddSingleton(_ =>
            new SearchClient(
                new Uri(configuration["AzureSearch:Endpoint"]!),
                configuration["AzureSearch:IndexName"]!,
                new AzureKeyCredential(configuration["AzureSearch:ApiKey"]!)));

        services.AddSingleton(_ =>
            new AzureOpenAIClient(
                new Uri(configuration["AzureOpenAI:Endpoint"]!),
                new DefaultAzureCredential()));

        services.AddSingleton(_ =>
            new ServiceBusClient(
                configuration["ServiceBus:ConnectionString"]));

        return services;
    }
}