using SmartGrowHub.Domain.Features.RefreshTokens;
using SmartGrowHub.Domain.Model;
using SmartGrowHub.Shared.UserSessions.Dto.RefreshTokens;

namespace SmartGrowHub.Shared.UserSessions.Dto;

public static class UserSessionExtensions
{
    public static Fin<UserSession> TryToDomain(this UserSessionDto session) =>
        UserSession.Create(session.Id, session.UserId, session.AccessToken, session.RefreshToken);

    public static UserSessionDto ToDto(this UserSession session) =>
        new(session.Id, session.UserId,
            session.AuthTokens.AccessToken,
            session.AuthTokens.RefreshToken);

    public static RefreshTokensRequestDto ToDto(this RefreshTokensRequest request) =>
        new(request.RefreshToken);

    public static RefreshTokensResponseDto ToDto(this RefreshTokensResponse response) =>
        new(response.AuthTokens.AccessToken, response.AuthTokens.RefreshToken);

    public static Fin<RefreshTokensResponse> TryToDomain(this RefreshTokensResponseDto response) =>
        from accessToken in AccessToken.Create(response.AccessToken)
        from refreshToken in RefreshToken.Create(response.RefreshToken)
        select new RefreshTokensResponse(new AuthTokens(accessToken, refreshToken));
}
