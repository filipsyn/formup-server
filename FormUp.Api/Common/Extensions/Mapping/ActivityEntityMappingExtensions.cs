using FormUp.Api.Features.v1.Workouts;
using FormUp.Contracts.v1.Workouts;
using FormUp.Contracts.v1.Workouts.Requests;

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

    public static ActivityEntity ToEntity(this CreateActivity contract)
    {
        return new ActivityEntity
        {
            ExerciseId = contract.ExerciseId,
            Weight = contract.Weight,
            RepetitionsCount = contract.RepetitionsCount,
            SetsCount = contract.SetsCount,
            Notes = contract.Notes ?? string.Empty
        };
    }
}