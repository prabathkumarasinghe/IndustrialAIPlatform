using IndustrialAI.Domain.Common;
using IndustrialAI.Domain.Enums;

namespace IndustrialAI.Domain.Entities;

public class Machine : BaseEntity
{
    public string Name { get; private set; }

    public string SerialNumber { get; private set; }

    public EquipmentStatus Status { get; private set; }

    //public ICollection<Sensor> Sensors { get; private set; }

    public Machine(string name, string serialNumber)
    {
        Name = name;
        SerialNumber = serialNumber;
        Status = EquipmentStatus.Healthy;

       // Sensors = new List<Sensor>();
    }

    public void UpdateStatus(EquipmentStatus status)
    {
        Status = status;
        UpdateTimestamp();
    }
}