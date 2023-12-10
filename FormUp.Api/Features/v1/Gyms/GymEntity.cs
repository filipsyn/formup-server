using FormUp.Api.Common.Persistence;

namespace FormUp.Api.Features.v1.Gyms;

/// <summary>
///     An entity representing Gym in database.
/// </summary>
public class GymEntity : BaseEntity
{
    /// <summary>
    ///     A name of gym.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     Coordinates of gym.
    /// </summary>
    public GeolocationEntity? Location { get; set; }
}