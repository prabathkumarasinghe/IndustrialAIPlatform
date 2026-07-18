using IndustrialAI.API.Extensions;
using IndustrialAI.Application;
using IndustrialAI.Infrastructure;
using IndustrialAI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiServices();

builder.Services.AddSwaggerDocumentation();

builder.Services.AddApplication();

builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddDbContext<IndustrialDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddJwtAuthentication(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseApplicationMiddleware();

app.MapControllers();

app.Run();