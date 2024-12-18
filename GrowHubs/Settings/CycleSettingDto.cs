namespace SmartGrowHub.Shared.GrowHubs.Settings;

public sealed record CycleSettingDto(DateTime StartTime, TimeSpan OnDuration, int Value) : ISettingDto;
