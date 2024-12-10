namespace SmartGrowHub.Shared.Auth;

public sealed record LoginRequestDto(
    string UserName,
    string Password);