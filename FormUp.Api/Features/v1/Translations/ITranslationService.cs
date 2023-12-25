using FormUp.Api.Common.Config;

namespace FormUp.Api.Features.v1.Translations;

public interface ITranslationService
{
    /// <summary>
    ///     Applies translation to entity.
    /// </summary>
    /// <param name="entity">An entity to which is translated.</param>
    /// <param name="propertySelector">Properties which should be translated.</param>
    /// <param name="language">A language to which content is translated.</param>
    /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
    /// <typeparam name="TEntity">A type of entity which is being translated.</typeparam>
    public Task<bool> ApplyTranslation<TEntity>(
        TEntity entity,
        Func<TEntity, string> propertySelector,
        string language = Constants.Translation.Default,
        CancellationToken cancellationToken = default
    );
}