using SmartGrowHub.Application.LogOut;
using SmartGrowHub.Application.Register;
using SmartGrowHub.Shared.Auth.Dto.LogIn;
using SmartGrowHub.Shared.Auth.Dto.LogOut;
using SmartGrowHub.Shared.Auth.Dto.Register;
using SmartGrowHub.Shared.Errors;
using SmartGrowHub.Shared.Users.Dto;
using SmartGrowHub.Shared.UserSessions.Dto.RefreshTokens;
using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.SerializerContext;

[JsonSerializable(typeof(UserDto))]
[JsonSerializable(typeof(LogInRequestDto))]
[JsonSerializable(typeof(LogInResponseDto))]
[JsonSerializable(typeof(LogOutRequestDto))]
[JsonSerializable(typeof(LogOutResponse))]
[JsonSerializable(typeof(RegisterRequestDto))]
[JsonSerializable(typeof(RegisterResponse))]
[JsonSerializable(typeof(RefreshTokensRequestDto))]
[JsonSerializable(typeof(RefreshTokensResponseDto))]
[JsonSerializable(typeof(ErrorDto))]
public sealed partial class SmartGrowHubSerializerContext
    : JsonSerializerContext;