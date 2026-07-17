using IndustrialAI.Domain.Common;
using IndustrialAI.Domain.Enums;

namespace IndustrialAI.Domain.Entities;

public class Prediction : BaseEntity
{
    public Guid MachineId { get; private set; }

    public PredictionType Result { get; private set; }

    public double Confidence { get; private set; }

    public DateTime PredictedAt { get; private set; }

    public Prediction(
        PredictionType result,
        double confidence)
    {
        Result = result;
        Confidence = confidence;
        PredictedAt = DateTime.UtcNow;
    }
}