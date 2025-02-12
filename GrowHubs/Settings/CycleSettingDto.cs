namespace SmartGrowHub.Shared.GrowHubs.Settings;

public sealed record CycleSettingDto(Ulid Id, ValueWithIntervalDto<TimeOnly> Interval) : SettingDto;