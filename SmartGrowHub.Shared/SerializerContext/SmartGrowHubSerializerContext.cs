using SmartGrowHub.Shared.Auth.Dto.LogIn;
using SmartGrowHub.Shared.Auth.Dto.Register;
using SmartGrowHub.Shared.HttpErrors;
using SmartGrowHub.Shared.Users.Dto;
using SmartGrowHub.Shared.UserSessions.Dto.RefreshTokens;
using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.SerializerContext;

[JsonSerializable(typeof(UserDto))]
[JsonSerializable(typeof(LogInResponseDto))]
[JsonSerializable(typeof(LogInRequestDto))]
[JsonSerializable(typeof(RegisterRequestDto))]
[JsonSerializable(typeof(RefreshTokensRequestDto))]
[JsonSerializable(typeof(RefreshTokensResponseDto))]
[JsonSerializable(typeof(HttpError))]
[JsonSerializable(typeof(ErrorDto))]
public sealed partial class SmartGrowHubSerializerContext
    : JsonSerializerContext;