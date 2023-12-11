using FormUp.Api.Features.v1.Gyms;
using FormUp.Contracts.v1.Gyms;

namespace FormUp.Api.Common.Extensions.Mapping;

/// <summary>
///     Class collecting extension methods used for mapping from <see cref="GymEntity" /> to DTOs and vice versa.
/// </summary>
public static class GymEntityMappingExtensions
{
    /// <summary>
    ///     Maps a <see cref="GymEntity" /> to <see cref="GymInfo" />.
    /// </summary>
    public static GymInfo ToGymInfo(this GymEntity entity)
    {
        return new GymInfo { Id = entity.Id, Name = entity.Name, Location = entity.Location?.ToGeolocationInfo() };
    }
}