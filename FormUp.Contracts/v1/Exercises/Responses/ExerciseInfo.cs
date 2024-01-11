namespace FormUp.Contracts.v1.Exercises;

/// <summary>
///     Contract defining exercise response.
/// </summary>
public record ExerciseInfo
{
    /// <summary>
    ///     Id of exercise.
    /// </summary>
    public required Guid Id { get; init; }

    /// <summary>
    ///     Name of exercise.
    /// </summary>
    public required string Name { get; set; }

    public string? Description { get; set; }

    public string? ImageURL { get; set; }

    public string? VideoURL { get; set; }
}