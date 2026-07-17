using IndustrialAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IndustrialAI.Infrastructure.Persistence;

public class IndustrialDbContext : DbContext
{
    public IndustrialDbContext(DbContextOptions<IndustrialDbContext> options)
        : base(options)
    {
    }

    public DbSet<Machine> Machines => Set<Machine>();

    public DbSet<Sensor> Sensors => Set<Sensor>();

    public DbSet<SensorReading> SensorReadings => Set<SensorReading>();

    public DbSet<Prediction> Predictions => Set<Prediction>();

    public DbSet<Alert> Alerts => Set<Alert>();

    public DbSet<MaintenanceRecord> MaintenanceRecords => Set<MaintenanceRecord>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IndustrialDbContext).Assembly);
    }
}