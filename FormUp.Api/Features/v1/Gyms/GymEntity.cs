using FormUp.Api.Common.Persistence;

namespace FormUp.Api.Features.v1.Gyms;

/// <summary>
///     An entity representing Gym in database.
/// </summary>
public class GymEntity : BaseEntity, ILocalizable
{
    /// <summary>
    ///     A name of gym.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     Latitude of gym
    /// </summary>
    public double Latitude { get; set; }

    /// <summary>
    ///     Longitude of gym.
    /// </summary>
    public double Longitude { get; set; }
}