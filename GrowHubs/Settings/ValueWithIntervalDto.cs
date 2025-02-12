namespace SmartGrowHub.Shared.GrowHubs.Settings;

public sealed record ValueWithIntervalDto<TTime>(Ulid Id,  SettingValueDto Value, TimeIntervalDto<TTime> Interval);