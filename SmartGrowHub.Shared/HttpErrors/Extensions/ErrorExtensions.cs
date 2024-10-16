namespace SmartGrowHub.Shared.HttpErrors.Extensions;

public static class ErrorExtensions
{
    public static ErrorDto ToDto(this Error error) =>
        new(error.Message, error.Code);

    public static Error ToDomain(this ErrorDto error) =>
        Error.New(error.Code ?? 0, error.Message ?? string.Empty);
}
