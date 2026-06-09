using System.Text.Json.Serialization;
using SmartGrowHub.Shared.Auth;
using SmartGrowHub.Shared.GrowHubs.Model;
using SmartGrowHub.Shared.GrowHubs.Requests;
using SmartGrowHub.Shared.Results;
using SmartGrowHub.Shared.Tokens;
using SmartGrowHub.Shared.Users;

namespace SmartGrowHub.Shared.SerializerContext;

[JsonSerializable(typeof(RequestOtpToEmailRequest))]
[JsonSerializable(typeof(RequestOtpToPhoneRequest))]
[JsonSerializable(typeof(RefreshTokensRequest))]
[JsonSerializable(typeof(VerifyOtpRequest))]
[JsonSerializable(typeof(UpdateScheduleRequestDto))]
[JsonSerializable(typeof(Result))]
[JsonSerializable(typeof(Result<AuthTokensDto>))]
[JsonSerializable(typeof(Result<IReadOnlyList<AuthTokensDto>>))]
[JsonSerializable(typeof(Result<IReadOnlyList<UserDto>>))]
[JsonSerializable(typeof(Result<IReadOnlyList<GrowHubDto>>))]
[JsonSerializable(typeof(Result<IReadOnlyList<SensorMeasurementDto>>))]
public sealed partial class SmartGrowHubSerializerContext : JsonSerializerContext;