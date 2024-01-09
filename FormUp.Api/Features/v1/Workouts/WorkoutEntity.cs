using FormUp.Api.Common.Persistence;
using FormUp.Api.Features.v1.Gyms;

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
    public DateTime At { get; set; } = DateTime.UtcNow;

    /// <summary>
    ///     Name of the workout.
    /// </summary>
    public string? Name { get; set; } = String.Empty;

    /// <summary>
    ///     Description of the workout.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    ///     Activities performed during workout.
    /// </summary>
    public IList<ActivityEntity> Activities { get; set; } = new List<ActivityEntity>();

    /// <summary>
    ///     <see cref="GymEntity.Id" /> of <see cref="GymEntity" /> at which the workout has been verified.
    /// </summary>
    /// <remarks>
    ///     If value is <c>null</c> that means, given workout has not been verified.
    /// </remarks>
    public Guid? VerifiedAtGymId { get; set; } = null;
}