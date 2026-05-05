namespace SmartCity.Contracts.Commands;

/// <summary>
/// Scheduled by TrafficLightController (via RabbitMQ delayed message).
/// Automatically unlocks an intersection after the emergency TTL expires.
/// </summary>
public record RestoreNormalTrafficCommand(
    int IntersectionId,
    DateTime OriginalLockTime
);