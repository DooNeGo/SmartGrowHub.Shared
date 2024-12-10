namespace SmartGrowHub.Shared.Tokens;

public sealed record AuthTokensDto(
    string AccessToken,
    RefreshTokenDto RefreshToken);