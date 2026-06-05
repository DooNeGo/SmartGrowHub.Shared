using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.GrowHubs.Model;

[JsonConverter(typeof(JsonStringEnumConverter<SensorTypeDto>))]
public enum SensorTypeDto
{
    RandomNumber,
    AirTemperature,
    AirPressure,
    AirHumidity,
    PlantHeight,
    SoilMoisture,
    SoilTemperature,
    Illumination
}