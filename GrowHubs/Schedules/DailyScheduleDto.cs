using System.Collections.Immutable;
using SmartGrowHub.Shared.GrowHubs.Settings;

namespace SmartGrowHub.Shared.GrowHubs.Schedules;

public sealed record DailyScheduleDto(Ulid Id, ImmutableArray<ValueWithIntervalDto<TimeOnly>> Intervals);