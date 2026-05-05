namespace SmartCity.Contracts.Commands;

/// <summary>
/// Published by TrafficAnalyzer or EmergencyAPI → Consumed by TrafficLightController via RabbitMQ.
/// Represents an instruction to change a traffic light's state.
/// </summary>
public record ChangeTrafficLightCommand(
    int IntersectionId,
    string Direction,
    string TargetColor,      // "RED", "GREEN", "YELLOW"
    string Reason,           // "Congestion", "Emergency", "Scheduled"
    bool IsEmergency,
    DateTime IssuedAt
);