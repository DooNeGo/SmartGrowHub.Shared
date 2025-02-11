namespace SmartGrowHub.Shared.GrowHubs.Settings;

public enum UnitDto
{
    Celsius,
    Percent
}

public sealed record CycleSettingDto<TTime>(SettingValueDto Value, TimePeriodDto<TTime> Period) : SettingDto;