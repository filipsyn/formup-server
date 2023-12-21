namespace FormUp.Contracts.v1.Workouts;

/// <summary>
///     Contract defining workout response.
/// </summary>
public record WorkoutInfo
{
    /// <summary>
    ///     Id of user that logged given workout.
    /// </summary>
    public string UserId { get; init; } = string.Empty;

    /// <summary>
    ///     Date and time when workout took place.
    /// </summary>
    public DateTime At { get; init; } = DateTime.Now;

    /// <summary>
    ///     Activities performed during workout.
    /// </summary>
    public IList<ActivityInfo> Activities { get; init; } = new List<ActivityInfo>();
}