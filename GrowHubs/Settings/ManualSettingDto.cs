namespace SmartGrowHub.Shared.GrowHubs.Settings;

public sealed record ManualSettingDto(Ulid Id, SettingValueDto Value) : SettingDto;
