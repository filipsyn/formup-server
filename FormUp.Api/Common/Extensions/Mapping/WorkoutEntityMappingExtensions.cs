using FormUp.Api.Features.v1.Workouts;
using FormUp.Contracts.v1.Workouts;

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
}