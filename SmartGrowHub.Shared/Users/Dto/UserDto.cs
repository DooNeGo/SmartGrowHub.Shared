﻿using System.Text.Json.Serialization;

namespace SmartGrowHub.Shared.Users.Dto;

public sealed record UserDto(
    string? Id,
    string? UserName,
    [property: JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] string? Password,
    string? Email,
    string? DisplayName);
