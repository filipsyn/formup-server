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
            Id = entity.Id,
            At = entity.At,
            UserId = entity.UserId,
            Name = entity.Name,
            Description = entity.Description,
            Activities = entity.Activities.Select(a => a.ToActivityInfo()).ToList(),
            VerifiedAtGymId = entity.VerifiedAtGymId
        };
    }

    public static WorkoutEntity ToEntity(this CreateWorkout contract)
    {
        return new WorkoutEntity
        {
            UserId = contract.UserId,
            At = contract.At,
            Name = contract.Name,
            Description = contract.Description,
            Activities =
                contract.Activities.Select(a => a.ToEntity()).ToList(),
            VerifiedAtGymId = contract.VerifiedAtGymId
        };
    }

    public static void ApplyUpdate(this WorkoutEntity entity, UpdateWorkoutRequest contract)
    {
        entity.At = contract.At;
        entity.UserId = contract.UserId;
        entity.ModifiedAt = DateTime.UtcNow;
        entity.Activities = contract.Activities.Select(a => a.ToEntity()).ToList();
    }
}