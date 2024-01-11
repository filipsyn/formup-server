using FormUp.Api.Features.v1.Exercises;
using FormUp.Contracts.v1.Exercises;

namespace FormUp.Api.Common.Extensions.Mapping;

/// <summary>
///     Class collecting extension methods used for mapping from <see cref="ExerciseEntity" /> to DTOs and vice versa.
/// </summary>
public static class ExerciseEntityMappingExtensions
{
    /// <summary>
    ///     Maps a <see cref="ExerciseEntity" /> to <see cref="ExerciseInfo" />.
    /// </summary>
    public static ExerciseInfo ToExerciseInfo(this ExerciseEntity entity)
    {
        return new ExerciseInfo
        {
            Id = entity.Id,
            Name = entity.Name,
            NormalizedName = entity.NormalizedName,
            Description = entity.Description,
            ImageURL = entity.ImageURL,
            VideoURL = entity.VideoURL
        };
    }
}