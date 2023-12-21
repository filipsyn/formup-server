using FormUp.Api.Common.Persistence;
using FormUp.Api.Features.v1.Exercises;

namespace FormUp.Api.Features.v1.Workouts;

/// <summary>
///     Entity representing an activity logged to user's workout.
/// </summary>
public class ActivityEntity : BaseEntity
{
    /// <summary>
    ///     Exercise performed.
    /// </summary>
    public ExerciseEntity? Exercise { get; set; }

    /// <summary>
    ///     Number of sets performed of one exercise in a Workout.
    /// </summary>
    public int SetsCount { get; set; }

    /// <summary>
    ///     Number of repetitions of exercise performed in each set.
    /// </summary>
    public int RepetitionsCount { get; set; }

    /// <summary>
    ///     Weight resistance with which the exercise is performed.
    /// </summary>
    public float Weight { get; set; }

    /// <summary>
    ///     Notes relating to an activity.
    /// </summary>
    public string Notes { get; set; } = string.Empty;
}