using IndustrialAI.Domain.Common;
using IndustrialAI.Domain.Enums;

namespace IndustrialAI.Domain.Entities;

public class Alert : BaseEntity
{
    public string Message { get; private set; }

    public AlertSeverity Severity { get; private set; }

    public bool IsResolved { get; private set; }

    public Alert(
        string message,
        AlertSeverity severity)
    {
        Message = message;
        Severity = severity;
    }

    public void Resolve()
    {
        IsResolved = true;
    }
}