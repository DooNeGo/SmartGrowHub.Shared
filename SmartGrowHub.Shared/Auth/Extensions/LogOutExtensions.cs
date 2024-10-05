using SmartGrowHub.Application.LogOut;
using SmartGrowHub.Domain.Common;
using SmartGrowHub.Domain.Model;
using SmartGrowHub.Shared.Auth.Dto.LogOut;

namespace SmartGrowHub.Shared.Auth.Extensions;

public static class LogOutExtensions
{
    public static LogOutRequest ToDomain(this LogOutRequestDto request) =>
        new(new Id<UserSession>(request.SessionId));
}
