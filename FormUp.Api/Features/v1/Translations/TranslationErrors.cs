using ErrorOr;

namespace FormUp.Api.Features.v1.Translations;

public static class TranslationErrors
{
    public static Error NotFound => Error.NotFound("TranslationErrors:NotFound", "Translation was not found.");
}