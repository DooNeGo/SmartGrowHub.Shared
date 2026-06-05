using SmartGrowHub.Shared.GrowHubs.Model;

namespace SmartGrowHub.Shared.GrowHubs.Requests;

public sealed record UpdateScheduleRequestDto(
    ScheduleTypeDto Type,
    IReadOnlyList<ScheduleUnitTemplateDto<TimeOnly>>? DailyEntries = null,
    IReadOnlyList<ScheduleUnitTemplateDto<WeekTimeOnlyDto>>? WeeklyEntries = null);

public sealed record ScheduleUnitTemplateDto<T>(
    ScheduleUnitKindDto Kind,
    QuantityDto Quantity,
    TimeIntervalDto<T> Interval);