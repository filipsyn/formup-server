using FormUp.Api.Features.v1.Workouts;
using FormUp.Contracts.v1.Workouts;
using FormUp.Contracts.v1.Workouts.Requests;

namespace FormUp.Api.Common.Extensions.Mapping;

public static class WorkoutEntityMappingExtensions
{
    public static WorkoutInfo ToWorkoutInfo(this WorkoutEntity entity)
    {
        return new WorkoutInfo
        {
            At = entity.At,
            UserId = entity.UserId,
            Activities = entity.Activities?.Select(a => a.ToActivityInfo()) as IList<ActivityInfo> ??
                         new List<ActivityInfo>()
        };
    }

    public static WorkoutEntity ToEntity(this CreateWorkout contract)
    {
        return new WorkoutEntity
        {
            UserId = contract.UserId,
            At = contract.At,
            Activities =
                contract.Activities.Select(a => a.ToEntity()).ToList()
        };
    }

    public static void ApplyUpdate(this WorkoutEntity entity, UpdateWorkoutRequest contract)
    {
        entity.At = contract.At;
        entity.UserId = contract.UserId;
        entity.ModifiedAt = DateTime.Now;
        entity.Activities = contract.Activities.Select(a => a.ToEntity()).ToList();
    }
}