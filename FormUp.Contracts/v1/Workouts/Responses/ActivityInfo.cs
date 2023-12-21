using FormUp.Contracts.v1.Exercises;

namespace FormUp.Contracts.v1.Workouts;

/// <summary>
///     Contract defining activity response.
/// </summary>
public record ActivityInfo
{
    /// <summary>
    ///     Id of activity.
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    ///     Exercise performed.
    /// </summary>
    public ExerciseInfo? Exercise { get; init; }

    /// <summary>
    ///     Number of sets performed of one exercise in a Workout.
    /// </summary>
    public int SetsCount { get; init; }

    /// <summary>
    ///     Number of repetitions of exercise performed in each set.
    /// </summary>
    public int RepetitionsCount { get; init; }

    /// <summary>
    ///     Weight resistance with which the exercise is performed.
    /// </summary>
    public float Weight { get; init; }

    /// <summary>
    ///     Notes relating to an activity.
    /// </summary>
    public string Notes { get; init; } = string.Empty;
}