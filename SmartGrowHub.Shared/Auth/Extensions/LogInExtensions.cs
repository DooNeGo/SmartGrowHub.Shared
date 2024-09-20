using SmartGrowHub.Domain.Common;
using SmartGrowHub.Domain.Features.LogIn;
using SmartGrowHub.Shared.Auth.Dto.LogIn;
using SmartGrowHub.Shared.Users.Extensions;
using SmartGrowHub.Shared.UserSessions.Dto;

namespace SmartGrowHub.Shared.Auth.Extensions;

public static class LogInExtensions
{
    public static Fin<LogInRequest> TryToDomain(this LogInRequestDto request) =>
        from userName in UserName.Create(request.UserName ?? string.Empty)
        from password in Password.Create(request.Password ?? string.Empty)
        select new LogInRequest(userName, password);

    public static Fin<LogInResponse> TryToDomain(this LogInResponseDto request) =>
        from session in request.UserSession.TryToDomain()
        select new LogInResponse(session);

    public static LogInRequestDto ToDto(this LogInRequest request) =>
        new(request.UserName, request.Password);

    public static LogInResponseDto ToDto(this LogInResponse response) =>
        new(response.UserSession.ToDto());
}