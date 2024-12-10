using System.Text.Json.Serialization;
using SmartGrowHub.Shared.Auth.Login;
using SmartGrowHub.Shared.Auth.Register;
using SmartGrowHub.Shared.Users;
using SmartGrowHub.Shared.UserSessions.RefreshTokens;

namespace SmartGrowHub.Shared.SerializerContext;

[JsonSerializable(typeof(UserDto))]
[JsonSerializable(typeof(LoginRequestDto))]
[JsonSerializable(typeof(RegisterRequestDto))]
[JsonSerializable(typeof(RefreshTokensRequestDto))]
public sealed partial class SmartGrowHubSerializerContext : JsonSerializerContext;