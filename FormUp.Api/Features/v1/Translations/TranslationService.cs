using ErrorOr;

using FormUp.Api.Data;

using Microsoft.EntityFrameworkCore;

namespace FormUp.Api.Features.v1.Translations;

internal class TranslationService : ITranslationService
{
    private readonly DataContext _context;

    public TranslationService(DataContext context)
    {
        _context = context;
    }

    public async Task<ErrorOr<string>> GetTranslation(
        string language,
        string key,
        CancellationToken cancellationToken = default)
    {
        var translation = await _context.Translations
            .FirstOrDefaultAsync(t => t.Locale == language && t.Key == key, cancellationToken);

        if (translation is null)
        {
            return TranslationErrors.NotFound;
        }

        return translation.Value;
    }

    public async Task<ErrorOr<Dictionary<string, string>>> GetTranslations(
        string language,
        IEnumerable<string> keys,
        CancellationToken cancellationToken = default)
    {
        var translations = await _context.Translations
            .Where(t => t.Locale == language)
            .Join<TranslationEntity, string, string, TranslationEntity>(
                keys,
                translation => translation.Key,
                key => key,
                (translation, key) => translation)
            .ToDictionaryAsync<TranslationEntity, string, string>(
                t => t.Key,
                t => t.Value,
                cancellationToken);

        return translations;
    }
}