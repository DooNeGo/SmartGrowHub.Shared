using SmartGrowHub.Domain.Common;
using SmartGrowHub.Domain.Model;
using SmartGrowHub.Domain.Requests;
using SmartGrowHub.Domain.Responses;
using SmartGrowHub.Shared.Auth.Dto.LogIn;

namespace SmartGrowHub.Shared.Auth.Extensions;

public static class LogInExtensions
{
    public static Fin<LogInRequest> TryToDomain(this LogInRequestDto request) =>
        from userName in UserName.Create(request.UserName ?? string.Empty)
        from password in Password.Create(request.Password ?? string.Empty)
        select new LogInRequest(userName, password);

    public static LogInResponse ToDomain(this LogInResponseDto request) =>
        new(new Id<User>(request.UserId), request.JwtToken);

    public static LogInRequestDto ToDto(this LogInRequest request) =>
        new(request.UserName, request.Password);

    public static LogInResponseDto ToDto(this LogInResponse response) =>
        new(response.Id.Value, response.JwtToken);
}