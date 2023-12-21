using FormUp.Api.Features.v1.Workouts;
using FormUp.Contracts.v1.Workouts;

namespace FormUp.Api.Common.Extensions.Mapping;

public static class ActivityEntityMappingExtensions
{
    public static ActivityInfo ToActivityInfo(this ActivityEntity entity)
    {
        return new ActivityInfo
        {
            Id = entity.Id,
            Exercise = entity.Exercise?.ToExerciseInfo(),
            Notes = entity.Notes,
            RepetitionsCount = entity.RepetitionsCount,
            SetsCount = entity.SetsCount,
            Weight = entity.Weight
        };
    }
}