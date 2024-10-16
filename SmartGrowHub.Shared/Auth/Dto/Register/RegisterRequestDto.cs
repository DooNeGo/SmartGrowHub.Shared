﻿namespace SmartGrowHub.Shared.Auth.Dto.Register;

public sealed record RegisterRequestDto(
    string? UserName,
    string? Password,
    string? EmailAddress,
    string? DisplayName);