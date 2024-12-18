using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.GrowHubs.Settings;

[JsonDerivedType(typeof(ManualSettingDto), nameof(ManualSettingDto))]
[JsonDerivedType(typeof(CycleSettingDto), nameof(CycleSettingDto))]
public interface ISettingDto;
