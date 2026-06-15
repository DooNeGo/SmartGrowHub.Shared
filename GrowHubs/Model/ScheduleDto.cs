using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.GrowHubs.Model;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(DisabledScheduleDto), nameof(ScheduleTypeDto.Disabled))]
[JsonDerivedType(typeof(EnabledScheduleDto), nameof(ScheduleTypeDto.Enabled))]
[JsonDerivedType(typeof(DailyScheduleDto), nameof(ScheduleTypeDto.Daily))]
[JsonDerivedType(typeof(WeeklyScheduleDto), nameof(ScheduleTypeDto.Weekly))]
public abstract record ScheduleDto(string Id)
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public T Match<T>(
        Func<DisabledScheduleDto, T> Disabled,
        Func<EnabledScheduleDto, T> Enabled,
        Func<DailyScheduleDto, T> Daily,
        Func<WeeklyScheduleDto, T> Weekly) =>
        this switch
        {
            DisabledScheduleDto program => Disabled(program),
            EnabledScheduleDto program => Enabled(program),
            DailyScheduleDto program => Daily(program),
            WeeklyScheduleDto program => Weekly(program),
            _ => throw new InvalidOperationException()
        };
}

public sealed record DisabledScheduleDto(string Id) : ScheduleDto(Id);

public sealed record EnabledScheduleDto(string Id) : ScheduleDto(Id);

public sealed record DailyScheduleDto(string Id, IReadOnlyList<ScheduleUnitDto<TimeOnly>> Entries) : ScheduleDto(Id);

public sealed record WeeklyScheduleDto(string Id, IReadOnlyList<ScheduleUnitDto<WeekTimeOnlyDto>> Entries) : ScheduleDto(Id);