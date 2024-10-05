using SmartGrowHub.Application.RefreshTokens;
using SmartGrowHub.Domain.Common;
using SmartGrowHub.Domain.Model;
using SmartGrowHub.Shared.UserSessions.Dto;
using SmartGrowHub.Shared.UserSessions.Dto.RefreshTokens;

namespace SmartGrowHub.Shared.UserSessions.Extensions;

public static class UserSessionExtensions
{
    public static Fin<UserSession> TryToDomain(this UserSessionDto session) =>
        from authTokens in session.AuthTokens.TryToDomain()
        from sessionId in UlidFP.TryCreate(session.Id)
        from userId in UlidFP.TryCreate(session.UserId)
        select new UserSession(
            new Id<UserSession>(sessionId),
            new Id<User>(userId),
            authTokens);

    public static Fin<AuthTokens> TryToDomain(this AuthTokensDto authTokens) =>
        from accessToken in AccessToken.From(authTokens.AccessToken)
        from refreshToken in authTokens.RefreshToken.TryToDomain()
        select new AuthTokens(accessToken, refreshToken);

    public static Fin<RefreshTokensResponse> TryToDomain(this RefreshTokensResponseDto response) =>
        from authTokens in response.AuthTokens.TryToDomain()
        select new RefreshTokensResponse(authTokens);

    public static Fin<RefreshTokensRequest> TryToDomain(this RefreshTokensRequestDto request) =>
        from refreshToken in RefreshToken.From((request.RefreshToken ?? string.Empty, DateTime.MinValue))
        select new RefreshTokensRequest(refreshToken);

    public static Fin<RefreshToken> TryToDomain(this RefreshTokenDto token) =>
        from refreshToken in RefreshToken.From((token.Value, token.Expires))
        select refreshToken;

    public static UserSessionDto ToDto(this UserSession session) =>
        new(session.Id.ToString(), session.UserId.ToString(), session.AuthTokens.ToDto());

    public static RefreshTokensRequestDto ToDto(this RefreshTokensRequest request) =>
        new(request.RefreshToken);

    public static RefreshTokensResponseDto ToDto(this RefreshTokensResponse response) =>
        new(response.AuthTokens.ToDto());

    public static AuthTokensDto ToDto(this AuthTokens authTokens) =>
        new(authTokens.AccessToken, authTokens.RefreshToken.ToDto());

    public static RefreshTokenDto ToDto(this RefreshToken refreshToken) =>
        new(refreshToken, refreshToken.Expires);
}
