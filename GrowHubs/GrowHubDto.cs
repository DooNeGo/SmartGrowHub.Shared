namespace SmartGrowHub.Shared.GrowHubs;

public sealed record GrowHubDto(Ulid Id, string Name, PlantDto? Plant);

public sealed record PlantDto(Ulid Id, string Name, DateTime PlantedAt);