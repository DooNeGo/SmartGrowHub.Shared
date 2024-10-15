namespace SmartGrowHub.Shared.HttpErrors;

public sealed record HttpError(
    string? Type,
    string? Title,
    int? Status,
    string? Detail);
