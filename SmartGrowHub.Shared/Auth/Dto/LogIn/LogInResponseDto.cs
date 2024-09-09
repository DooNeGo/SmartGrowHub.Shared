namespace SmartGrowHub.Shared.Auth.Dto.LogIn;

public sealed record LogInResponseDto(
    Ulid UserId,
    string JwtToken);