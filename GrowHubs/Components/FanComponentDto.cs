using SmartGrowHub.Shared.GrowHubs.Settings;

namespace SmartGrowHub.Shared.GrowHubs.Components;

public sealed record FanComponentDto(Ulid Id, ISettingDto Setting) : IGrowHubComponentDto;
