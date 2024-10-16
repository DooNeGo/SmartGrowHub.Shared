using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.UserSessions.Dto.RefreshTokens;

public sealed record RefreshTokensResponseDto(
    [property: JsonRequired] AuthTokensDto AuthTokens);