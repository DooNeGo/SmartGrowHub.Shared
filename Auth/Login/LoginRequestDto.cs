namespace SmartGrowHub.Shared.Auth.Login;

public sealed record LoginRequestDto(
    string UserName,
    string Password);