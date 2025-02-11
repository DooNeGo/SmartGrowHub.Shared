using System.Collections.Immutable;

namespace SmartGrowHub.Shared.GrowHubs.Settings;

public sealed record WeekScheduleSettingDto(ImmutableArray<CycleSettingDto<WeekTimeOnlyDto>> Schedules) : SettingDto;