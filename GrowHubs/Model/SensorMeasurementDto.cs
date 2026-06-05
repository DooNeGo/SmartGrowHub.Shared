namespace SmartGrowHub.Shared.GrowHubs.Model;

public sealed record SensorMeasurementDto(
    string Id,
    string SensorId,
    SensorTypeDto Type,
    QuantityDto Quantity,
    DateTime CreatedAt);