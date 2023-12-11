namespace FormUp.Contracts.v1.Gyms;

/// <summary>
///     Contract defining geolocation coordinates response.
/// </summary>
public record GeolocationInfo
{
    /// <summary>
    ///     Latitude of location.
    /// </summary>
    public double Latitude { get; set; }

    /// <summary>
    ///     Longitude of location.
    /// </summary>
    public double Longitude { get; set; }
}