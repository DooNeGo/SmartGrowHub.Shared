using System.Text.Json.Serialization;
using SmartGrowHub.Shared.Auth;
using SmartGrowHub.Shared.Tokens;
using SmartGrowHub.Shared.Users;

namespace SmartGrowHub.Shared.SerializerContext;

[JsonSerializable(typeof(UserDto))]
[JsonSerializable(typeof(LogInByEmailRequest))]
[JsonSerializable(typeof(LogInByPhoneRequest))]
[JsonSerializable(typeof(RefreshTokensRequest))]
public sealed partial class SmartGrowHubSerializerContext : JsonSerializerContext;