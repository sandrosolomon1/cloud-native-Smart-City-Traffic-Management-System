namespace SmartCity.Contracts.Events;

//<summary>
// published by sensorsimulator → consumed by trafficanalyzer via kafka.
// represents raw telemetry from an iot sensor.
//</summary>
public record TrafficDataReceived(
    int IntersectionId,
    string Direction,
    int VehicleCount,
    double AverageSpeedKmh,
    DateTime Timestamp
);