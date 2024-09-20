namespace SmartGrowHub.Shared.UserSessions.Dto.RefreshTokens;

public sealed record RefreshTokensResponseDto(
    string AccessToken,
    string RefreshToken);