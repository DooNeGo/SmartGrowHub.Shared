using SmartGrowHub.Shared.GrowHubs.Schedules;

namespace SmartGrowHub.Shared.GrowHubs.Settings;

public sealed record DailySettingDto(Ulid Id, DailyScheduleDto Schedule) : SettingDto;