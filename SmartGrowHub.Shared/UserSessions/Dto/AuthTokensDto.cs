using SmartGrowHub.Shared.UserSessions.Dto.RefreshTokens;
using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.UserSessions.Dto;

public sealed record AuthTokensDto(
    [property: JsonRequired] string AccessToken,
    [property: JsonRequired] RefreshTokenDto RefreshToken);