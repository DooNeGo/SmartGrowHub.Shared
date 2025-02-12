namespace SmartGrowHub.Shared.GrowHubs.Settings;

public readonly record struct TimeIntervalDto<TTime>(TTime Start, TTime End);