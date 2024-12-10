namespace SmartGrowHub.Shared.Auth;

public sealed record RegisterRequestDto(
    string UserName,
    string Password,
    string EmailAddress,
    string DisplayName);