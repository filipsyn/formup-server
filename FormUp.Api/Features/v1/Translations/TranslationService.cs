using ErrorOr;

using FormUp.Api.Data;

using Microsoft.EntityFrameworkCore;

namespace FormUp.Api.Features.v1.Translations;

internal class TranslationService : ITranslationService
{
    private readonly DataContext _context;
    private readonly ILogger<TranslationService> _logger;

    public TranslationService(DataContext context, ILogger<TranslationService> logger)
    {
        _context = context;
        _logger = logger;
    }

    /// <inheritdocs />
    public async Task<bool> ApplyTranslation<TEntity>(
        TEntity entity,
        Func<TEntity, string> propertySelector,
        string language = "en",
        CancellationToken cancellationToken = default)
    {
        var propertyName = propertySelector(entity);

        if (entity?.GetType().GetProperty(propertyName)?.GetValue(entity) is not string translationKey)
        {
            throw new InvalidOperationException();
        }

        var translation = await GetTranslation(language, translationKey);

        if (translation.IsError)
        {
            _logger.LogError(
                "Could not apply translation because there is no available translation of {Key} in language {Language}",
                translationKey, language);
            return false;
        }

        try
        {
            entity
                .GetType()
                .GetProperty(propertyName)?
                .SetValue(entity, translation.Value);
        }
        catch (ArgumentException ex)
        {
            _logger.LogError(ex,
                "Could not set new value of {PropertyName} property on {@Entity} entity",
                propertyName, entity);
            return false;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,
                "Unexpected exception has been raised during process of applying translation to {@Entity} entity",
                entity);
            return false;
        }

        return true;
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
}