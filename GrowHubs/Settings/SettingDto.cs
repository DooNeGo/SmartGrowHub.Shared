using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.GrowHubs.Settings;

[JsonDerivedType(typeof(ManualSettingDto), "Manual")]
[JsonDerivedType(typeof(CycleSettingDto<TimeOnly>), "Cycle")]
[JsonDerivedType(typeof(DayScheduleSettingDto), "DaySchedule")]
[JsonDerivedType(typeof(WeekScheduleSettingDto), "WeekSchedule")]
public abstract record SettingDto
{
    public T Match<T>(
        Func<ManualSettingDto, T> mapManual,
        Func<CycleSettingDto<TimeOnly>, T> mapCycle,
        Func<DayScheduleSettingDto, T> mapDaySchedule,
        Func<WeekScheduleSettingDto, T> mapWeekSchedule) =>
        this switch
        {
            ManualSettingDto schedule => mapManual(schedule),
            CycleSettingDto<TimeOnly> schedule => mapCycle(schedule),
            DayScheduleSettingDto schedule => mapDaySchedule(schedule),
            WeekScheduleSettingDto schedule => mapWeekSchedule(schedule),
            _ => throw new NotImplementedException()
        };
}
