using SmartGrowHub.Domain.Common;
using SmartGrowHub.Domain.Model;
using SmartGrowHub.Shared.Users.Dto;

namespace SmartGrowHub.Shared.Users.Extensions;

public static class UserExtensions
{
    public static UserDto ToDto(this User user)
    {
        string? password = user.Password.Match(
            plainText: password => (string?)password,
            hash: _ => null,
            empty: () => null);

        return new UserDto(
            user.Id.ToString(),
            user.UserName,
            password,
            user.Email,
            user.DisplayName);
    }

    public static Fin<User> TryToDomain(this UserDto user) =>
        from userId in Domain.Common.Id<User>.From(user.Id ?? string.Empty)
        from userName in UserName.From(user.UserName ?? string.Empty)
        from password in string.IsNullOrEmpty(user.Password)
            ? Password.Empty
            : Password.FromPlainText(user.Password)
        from email in EmailAddress.From(user.Email ?? string.Empty)
        from displayName in NonEmptyString.From(user.DisplayName ?? string.Empty)
        select new User(userId, userName, password, email, displayName);
}
