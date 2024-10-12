using SmartGrowHub.Application.LogIn;
using SmartGrowHub.Domain.Common;
using SmartGrowHub.Shared.Auth.Dto.LogIn;
using SmartGrowHub.Shared.Users.Extensions;
using SmartGrowHub.Shared.UserSessions.Extensions;

namespace SmartGrowHub.Shared.Auth.Extensions;

public static class LogInExtensions
{
    public static Fin<LogInRequest> TryToDomain(this LogInRequestDto request) =>
        from userName in UserName.From(request.UserName ?? string.Empty)
        from password in Password.FromPlainText(request.Password ?? string.Empty)
        select new LogInRequest(userName, password);

    public static Fin<LogInResponse> TryToDomain(this LogInResponseDto request) =>
        from session in request.UserSession.TryToDomain()
        select new LogInResponse(session);

    public static Fin<LogInRequestDto> TryToDto(this LogInRequest request) =>
        from password in request.Password.Match(
            plainText: FinSucc,
            hash: _ => Error.New("A password must be in plain text for the log in request"),
            empty: () => Error.New("A password must be in plain text for the log in request"))
        select new LogInRequestDto(request.UserName, password);

    public static LogInResponseDto ToDto(this LogInResponse response) =>
        new(response.UserSession.ToDto());
}