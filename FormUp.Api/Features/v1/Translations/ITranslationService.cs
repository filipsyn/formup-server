using ErrorOr;

namespace FormUp.Api.Features.v1.Translations;

public interface ITranslationService
{
    /// <summary>
    ///     Retrieves a translation of resource specified by its key.
    /// </summary>
    public Task<ErrorOr<string>> GetTranslation(
        string language,
        string key,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Retrieves translations of resources specified by provided keys.
    /// </summary>
    public Task<ErrorOr<Dictionary<string, string>>> GetTranslations(
        string language,
        IEnumerable<string> keys,
        CancellationToken cancellationToken = default);
}