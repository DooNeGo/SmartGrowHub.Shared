namespace SmartGrowHub.Shared.GrowHubs.Settings;

public readonly record struct TimePeriodDto<TTime>(TTime Start, TTime End);