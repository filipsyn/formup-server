using FormUp.Api.Common.Persistence;
using FormUp.Api.Features.v1.Gyms;
using FormUp.Contracts.v1.Gyms;

namespace FormUp.Api.Common.Extensions.Mapping;

/// <summary>
///     Class collecting extension methods used for mapping from <see cref="GeolocationEntity" /> to DTOs and vice versa.
/// </summary>
public static class GeolocationEntityMappingExtensions
{
    /// <summary>
    ///     Maps a <see cref="GeolocationEntity" /> to <see cref="GeolocationInfo" />.
    /// </summary>
    public static GeolocationInfo ToGeolocationInfo(this GeolocationEntity entity)
    {
        return new GeolocationInfo { Latitude = entity.Latitude, Longitude = entity.Longitude };
    }
}