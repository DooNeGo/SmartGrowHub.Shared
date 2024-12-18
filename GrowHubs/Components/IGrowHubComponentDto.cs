using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.GrowHubs.Components;

[JsonDerivedType(typeof(LightComponentDto), nameof(LightComponentDto))]
[JsonDerivedType(typeof(HeaterComponentDto), nameof(HeaterComponentDto))]
[JsonDerivedType(typeof(FanComponentDto), nameof(FanComponentDto))]
public interface IGrowHubComponentDto
{
    public T Match<T>(Func<FanComponentDto, T> mapFan, Func<HeaterComponentDto, T> mapHeater, Func<LightComponentDto, T> mapLight) =>
        this switch
        {
            FanComponentDto fan => mapFan(fan),
            HeaterComponentDto heater => mapHeater(heater),
            LightComponentDto light => mapLight(light),
            _ => throw new NotImplementedException()
        };
}
