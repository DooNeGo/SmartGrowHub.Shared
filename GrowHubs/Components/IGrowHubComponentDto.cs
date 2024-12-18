using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.GrowHubs.Components;

[JsonDerivedType(typeof(LightComponentDto), nameof(LightComponentDto))]
[JsonDerivedType(typeof(HeaterComponentDto), nameof(HeaterComponentDto))]
[JsonDerivedType(typeof(FanComponentDto), nameof(FanComponentDto))]
public interface IGrowHubComponentDto;
