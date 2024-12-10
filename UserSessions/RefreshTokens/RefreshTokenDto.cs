namespace SmartGrowHub.Shared.UserSessions.RefreshTokens;

public sealed record RefreshTokenDto(
    string Value,
    DateTime Expires);