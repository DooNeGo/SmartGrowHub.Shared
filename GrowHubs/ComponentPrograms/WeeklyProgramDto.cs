using System.Collections.Immutable;

namespace SmartGrowHub.Shared.GrowHubs.ComponentPrograms;

public sealed record WeeklyProgramDto(Ulid Id, ImmutableArray<TimedQuantityDto<WeekTimeOnlyDto>> Entries)
    : ComponentProgramDto;