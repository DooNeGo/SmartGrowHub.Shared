namespace SmartGrowHub.Shared.UserSessions.Dto;

public sealed record UserSessionDto(
    string Id,
    string UserId,
    AuthTokensDto AuthTokens);