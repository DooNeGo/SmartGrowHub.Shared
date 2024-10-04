using SmartGrowHub.Shared.UserSessions.Dto.RefreshTokens;

namespace SmartGrowHub.Shared.UserSessions.Dto;

public sealed record AuthTokensDto(
    string AccessToken,
    RefreshTokenDto RefreshToken);