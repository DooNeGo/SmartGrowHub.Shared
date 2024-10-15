namespace SmartGrowHub.Shared.HttpErrors;

public static class HttpErrorExtensions
{
    public static Error ToError(this HttpError httpError) =>
        Error.New(httpError.Detail ?? string.Empty);
}
