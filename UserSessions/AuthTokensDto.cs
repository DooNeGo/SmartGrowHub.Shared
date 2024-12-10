using SmartGrowHub.Shared.UserSessions.RefreshTokens;

namespace SmartGrowHub.Shared.UserSessions;

public sealed record AuthTokensDto(
    string AccessToken,
    RefreshTokenDto RefreshToken);