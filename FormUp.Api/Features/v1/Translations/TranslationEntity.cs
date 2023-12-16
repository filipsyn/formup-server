using FormUp.Api.Common.Persistence;

using Microsoft.EntityFrameworkCore;

namespace FormUp.Api.Features.v1.Translations;

/// <summary>
///     Database entity storing translations of strings.
/// </summary>
/// <remarks>
///     Translations are retrieved by combination of their <see cref="TranslationEntity.Key" /> and
///     <see cref="TranslationEntity.Locale" />.
/// </remarks>
[Index(nameof(Locale), nameof(Key))]
public class TranslationEntity : BaseEntity
{
    /// <summary>
    ///     Locale in which corresponding value is used.
    /// </summary>
    public string Locale { get; set; } = "en";

    /// <summary>
    ///     Key by which is localized resource identified.
    /// </summary>
    public string Key { get; set; } = string.Empty;

    /// <summary>
    ///     Translated value of localized resource.
    /// </summary>
    public string Value { get; set; } = string.Empty;
}