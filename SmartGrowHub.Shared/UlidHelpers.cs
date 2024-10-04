namespace SmartGrowHub.Shared;

public static class UlidFP
{
    public static Fin<Ulid> TryCreate(string rawUlid) =>
        Ulid.TryParse(rawUlid, out Ulid ulid)
            ? ulid
            : Error.New("Invalid ulid");
}