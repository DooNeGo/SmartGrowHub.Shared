namespace SmartGrowHub.Shared.UserSessions.Dto.RefreshTokens;

public sealed record RefreshTokenDto(
    string Value,
    DateTime Expires);