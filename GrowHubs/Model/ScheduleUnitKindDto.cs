using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.GrowHubs.Model;

[JsonConverter(typeof(JsonStringEnumConverter<ScheduleUnitKindDto>))]
public enum ScheduleUnitKindDto
{
    Prefer,
    Power
}