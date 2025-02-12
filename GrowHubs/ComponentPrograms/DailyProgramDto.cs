using System.Collections.Immutable;

namespace SmartGrowHub.Shared.GrowHubs.ComponentPrograms;

public sealed record DailyProgramDto(Ulid Id, ImmutableArray<TimedQuantityDto<TimeOnly>> Entries)
    : ComponentProgramDto;