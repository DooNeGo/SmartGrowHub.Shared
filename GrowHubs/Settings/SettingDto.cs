using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.GrowHubs.Settings;

[JsonDerivedType(typeof(ManualSettingDto), "ManualSetting")]
[JsonDerivedType(typeof(CycleSettingDto), "CycleSetting")]
[JsonDerivedType(typeof(DailySettingDto), "DailySetting")]
[JsonDerivedType(typeof(WeeklySettingDto), "WeeklySetting")]
public abstract record SettingDto
{
    public T Match<T>(
        Func<ManualSettingDto, T> mapManual,
        Func<CycleSettingDto, T> mapCycle,
        Func<DailySettingDto, T> mapDaySchedule,
        Func<WeeklySettingDto, T> mapWeekSchedule) =>
        this switch
        {
            ManualSettingDto schedule => mapManual(schedule),
            CycleSettingDto schedule => mapCycle(schedule),
            DailySettingDto schedule => mapDaySchedule(schedule),
            WeeklySettingDto schedule => mapWeekSchedule(schedule),
            _ => throw new InvalidOperationException()
        };
}
