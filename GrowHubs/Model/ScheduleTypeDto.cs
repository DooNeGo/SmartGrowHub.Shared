using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.GrowHubs.Model;

[JsonConverter(typeof(JsonStringEnumConverter<ScheduleTypeDto>))]
public enum ScheduleTypeDto
{
    Disabled,
    Enabled,
    Daily,
    Weekly,
}