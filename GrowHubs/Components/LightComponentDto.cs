using SmartGrowHub.Shared.GrowHubs.Settings;

namespace SmartGrowHub.Shared.GrowHubs.Components;

public sealed record LightComponentDto(Ulid Id, ISettingDto Setting, int LightType) : IGrowHubComponentDto;
