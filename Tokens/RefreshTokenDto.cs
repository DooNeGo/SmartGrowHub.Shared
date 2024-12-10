namespace SmartGrowHub.Shared.Tokens;

public sealed record RefreshTokenDto(
    string Value,
    DateTime Expires);