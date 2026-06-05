using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.GrowHubs.Model;

[JsonConverter(typeof(JsonStringEnumConverter<ModuleTypeDto>))]
public enum ModuleTypeDto
{
    Led,
    DayLight,
    UvLight,
    Heater,
    Humidifier,
    Fan,
    WaterPump,
    AirFlap
}