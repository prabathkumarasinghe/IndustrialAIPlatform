using IndustrialAI.Domain.Common;

namespace IndustrialAI.Domain.Entities;

public class SensorReading : BaseEntity
{
    public Guid SensorId { get; private set; }

    public Sensor Sensor { get; private set; }

    public double Value { get; private set; }

    public DateTime Timestamp { get; private set; }

    public SensorReading(double value)
    {
        Value = value;
        Timestamp = DateTime.UtcNow;
    }
}