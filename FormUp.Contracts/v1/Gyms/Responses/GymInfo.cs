namespace FormUp.Contracts.v1.Gyms;

/// <summary>
///     Contract defining response carrying basic information about Gym.
/// </summary>
public record GymInfo
{
    /// <summary>
    ///     Primary identifier of a gym.
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    ///     Name of a gym.
    /// </summary>
    public string Name { get; init; } = String.Empty;

    /// <summary>
    ///     Coordinates of gym's location.
    /// </summary>
    public GeolocationInfo? Location { get; init; }
}