using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.GrowHubs.Settings;

public sealed record SettingValueDto(
    float Value,
    [property: JsonConverter(typeof(JsonStringEnumConverter))]UnitDto Unit);