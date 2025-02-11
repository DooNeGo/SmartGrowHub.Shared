using SmartGrowHub.Shared.GrowHubs.Components;

namespace SmartGrowHub.Shared.GrowHubs;

public sealed record GrowHubDto(
    Ulid Id,
    string Name,
    string Model,
    PlantDto? Plant,
    HeaterComponentDto HeaterComponent,
    FanComponentDto FanComponent,
    DayLightComponentDto DayLightComponent,
    UvLightComponentDto UvLightComponent);
