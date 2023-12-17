using FormUp.Api.Common.Persistence;

namespace FormUp.Api.Features.v1.Exercises;

/// <summary>
///     Entity representing exercise in the database.
/// </summary>
public class ExerciseEntity : BaseEntity
{
    /// <summary>
    ///     Name of the exercise.
    /// </summary>
    public string Name { get; set; } = string.Empty;
}