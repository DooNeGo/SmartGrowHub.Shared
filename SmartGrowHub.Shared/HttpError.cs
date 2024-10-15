namespace SmartGrowHub.Shared;

public sealed record HttpError(
    string? Type,
    string? Title,
    int? Status,
    string? Detail);
