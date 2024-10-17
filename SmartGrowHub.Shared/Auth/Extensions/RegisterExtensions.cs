using SmartGrowHub.Application.Register;
using SmartGrowHub.Domain.Common;
using SmartGrowHub.Domain.Common.Password;
using SmartGrowHub.Shared.Auth.Dto.Register;

namespace SmartGrowHub.Shared.Auth.Extensions;

public static class RegisterExtensions
{
    public static Fin<RegisterRequest> TryToDomain(this RegisterRequestDto request) =>
        from userName in UserName.From(request.UserName ?? string.Empty)
        from password in PlainTextPassword.From(request.Password ?? string.Empty)
        from email in EmailAddress.From(request.EmailAddress ?? string.Empty)
        from displayName in NonEmptyString.From(request.DisplayName ?? string.Empty)
        select new RegisterRequest(userName, password, email, displayName);

    public static RegisterRequestDto ToDto(this RegisterRequest request) =>
        new(request.UserName, request.Password, request.EmailAddress, request.DisplayName);
}
