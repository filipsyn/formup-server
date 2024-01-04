using System.ComponentModel.DataAnnotations.Schema;

namespace FormUp.Api.Common.Persistence;

/// <summary>
///     Base Entity for all of models to be persisted in database.
///     Provides fields that are common for all entities.
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    ///     Primary identifier of entity.
    /// </summary>
    [Column(Order = 0)]
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    ///     Timestamp of when entity was created.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    ///     Timestamp of last modification of entity.
    /// </summary>
    public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;
}