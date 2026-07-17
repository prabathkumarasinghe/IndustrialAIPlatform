using IndustrialAI.Domain.Common;

namespace IndustrialAI.Domain.Entities;

public class MaintenanceRecord : BaseEntity
{
    // Required by EF Core
    private MaintenanceRecord()
    {
    }

    public Guid MachineId { get; private set; }

    public DateTime MaintenanceDate { get; private set; }

    public string Description { get; private set; }

    public MaintenanceRecord(DateTime maintenanceDate, string description)
    {
        MaintenanceDate = maintenanceDate;
        Description = description;
    }
}