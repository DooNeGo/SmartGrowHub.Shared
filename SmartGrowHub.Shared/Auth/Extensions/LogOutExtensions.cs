using SmartGrowHub.Application.LogOut;
using SmartGrowHub.Domain.Model;
using SmartGrowHub.Shared.Auth.Dto.LogOut;

namespace SmartGrowHub.Shared.Auth.Extensions;

public static class LogOutExtensions
{
    public static Fin<LogOutRequest> TryToDomain(this LogOutRequestDto request) =>
        from id in Domain.Common.Id<UserSession>.From(request.SessionId ?? string.Empty)
        select new LogOutRequest(id);

    public static LogOutRequestDto ToDto(this LogOutRequest request) =>
        new(request.Id.ToString());
}
