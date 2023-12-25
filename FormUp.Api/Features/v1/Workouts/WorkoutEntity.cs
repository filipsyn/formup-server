using FormUp.Api.Common.Persistence;

namespace FormUp.Api.Features.v1.Workouts;

/// <summary>
///     Entity representing user's logged workout.
/// </summary>
public class WorkoutEntity : BaseEntity
{
    /// <summary>
    ///     Id of user that logged given workout.
    /// </summary>
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    ///     Date and time when workout took place.
    /// </summary>
    public DateTime At { get; set; } = DateTime.Now;

    /// <summary>
    ///     Activities performed during workout.
    /// </summary>
    public IList<ActivityEntity> Activities { get; set; } = new List<ActivityEntity>();
}