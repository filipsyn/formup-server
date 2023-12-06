namespace FormUp.Api.Common.Models;

/// <summary>
///     Model for storing location expressed in WGS-84 coordinates.
/// </summary>
public class Geolocation
{
    /// <summary>
    ///     Gets or sets a latitude of location.
    /// </summary>
    public double Latitude { get; set; }

    /// <summary>
    ///     Gets or sets longitude of location.
    /// </summary>
    public double Longitude { get; set; }
}