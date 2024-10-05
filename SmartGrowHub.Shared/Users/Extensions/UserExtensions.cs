using SmartGrowHub.Domain.Common;
using SmartGrowHub.Domain.Model;
using SmartGrowHub.Shared.Users.Dto;

namespace SmartGrowHub.Shared.Users.Extensions;

public static class UserExtensions
{
    public static UserDto ToDto(this User user) =>
        new(user.Id, user.UserName, user.Email, user.DisplayName);

    public static Fin<User> TryToDomain(this UserDto user) =>
        from userName in UserName.From(user.UserName)
        from email in EmailAddress.From(user.Email)
        from displayName in NonEmptyString.From(user.DisplayName)
        let userId = new Id<User>(user.Id)
        select new User(userId, userName, Password.Empty, email, displayName);

    public static Fin<User> New(string userNameRaw, string passwordRaw, string emailRaw, string displayNameRaw) =>
        from userName in UserName.From(userNameRaw)
        from password in Password.FromPlainText(passwordRaw)
        from email in EmailAddress.From(emailRaw)
        from displayName in NonEmptyString.From(displayNameRaw)
        let userId = new Id<User>(Ulid.NewUlid())
        select new User(userId, userName, password, email, displayName);
}
