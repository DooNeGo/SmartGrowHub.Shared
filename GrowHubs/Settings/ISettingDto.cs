using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.GrowHubs.Settings;

[JsonDerivedType(typeof(ManualSettingDto), nameof(ManualSettingDto))]
[JsonDerivedType(typeof(CycleSettingDto), nameof(CycleSettingDto))]
public interface ISettingDto
{
    public T Match<T>(Func<ManualSettingDto, T> mapManual, Func<CycleSettingDto, T> mapCycle) =>
        this switch
        {
            ManualSettingDto manual => mapManual(manual),
            CycleSettingDto cycle => mapCycle(cycle),
            _ => throw new NotImplementedException()
        };
}
