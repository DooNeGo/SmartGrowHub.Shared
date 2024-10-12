using SmartGrowHub.Application.Register;
using SmartGrowHub.Domain.Common;
using SmartGrowHub.Shared.Auth.Dto.Register;

namespace SmartGrowHub.Shared.Auth.Extensions;

public static class RegisterExtensions
{
    public static Fin<RegisterRequest> TryToDomain(this RegisterRequestDto request) =>
        from userName in UserName.From(request.UserName ?? string.Empty)
        from password in Password.FromPlainText(request.Password ?? string.Empty)
        from email in EmailAddress.From(request.EmailAddress ?? string.Empty)
        from displayName in NonEmptyString.From(request.DisplayName ?? string.Empty)
        select new RegisterRequest(userName, password, email, displayName);

    public static Fin<RegisterRequestDto> TryToDto(this RegisterRequest request) =>
        request.Password
            .Match(
                plainText: text => FinSucc(text),
                hash: _ => Error.New("The password must be in plain text"),
                empty: () => Error.New("The password must be in plain text"))
            .Map(password => new RegisterRequestDto(request.UserName, password,
                request.EmailAddress, request.DisplayName));
}
