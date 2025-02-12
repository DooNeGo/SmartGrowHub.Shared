using SmartGrowHub.Shared.GrowHubs.Schedules;

namespace SmartGrowHub.Shared.GrowHubs.Settings;

public sealed record WeeklySettingDto(Ulid Id, WeeklyScheduleDto Schedule) : SettingDto;