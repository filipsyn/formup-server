namespace FormUp.Api.Features.v1.Translations;

public interface ITranslationService
{

    public Task<bool> ApplyTranslation<TEntity>(TEntity entity, Func<TEntity, string> propertySelector,
        string language);
}