using System.Collections.Immutable;

namespace SmartGrowHub.Shared.GrowHubs.Settings;

public sealed record DayScheduleSettingDto(ImmutableArray<CycleSettingDto<TimeOnly>> Schedules) : SettingDto;