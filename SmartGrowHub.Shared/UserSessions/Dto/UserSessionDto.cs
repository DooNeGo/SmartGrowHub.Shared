namespace SmartGrowHub.Shared.UserSessions.Dto;

public sealed record UserSessionDto(
    Ulid Id,
    Ulid UserId,
    string AccessToken,
    string RefreshToken);