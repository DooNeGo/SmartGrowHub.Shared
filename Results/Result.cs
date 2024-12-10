namespace SmartGrowHub.Shared.Results;

public record Result(
    bool Success,
    string? ErrorMessage,
    int? ErrorCode);

public sealed record Result<T>(
    T? Data,
    bool Success,
    string? ErrorMessage,
    int? ErrorCode)
{
    public Result<TNew> Map<TNew>(Func<T, TNew> map) =>
        Data is null
            ? new Result<TNew>(default, Success, ErrorMessage, ErrorCode)
            : new Result<TNew>(map(Data), Success, ErrorMessage, ErrorCode);
}