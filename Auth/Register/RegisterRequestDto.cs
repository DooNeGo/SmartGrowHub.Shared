namespace SmartGrowHub.Shared.Auth.Register;

public sealed record RegisterRequestDto(
    string UserName,
    string Password,
    string EmailAddress,
    string DisplayName);