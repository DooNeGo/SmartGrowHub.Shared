using System.Collections.Immutable;
using SmartGrowHub.Shared.GrowHubs.Settings;

namespace SmartGrowHub.Shared.GrowHubs.Schedules;

public sealed record WeeklyScheduleDto(Ulid Id, ImmutableArray<ValueWithIntervalDto<WeekTimeOnlyDto>> Intervals);