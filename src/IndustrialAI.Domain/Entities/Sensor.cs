using IndustrialAI.Domain.Common;
using IndustrialAI.Domain.Enums;

namespace IndustrialAI.Domain.Entities;

public class Sensor : BaseEntity
{
    public string Name { get; private set; }

    public SensorType Type { get; private set; }

    public Guid MachineId { get; private set; }

    public Machine Machine { get; private set; }

   // public ICollection<SensorReading> Readings { get; private set; }

    public Sensor(string name, SensorType type)
    {
        Name = name;
        Type = type;

       // Readings = new List<SensorReading>();
    }
}