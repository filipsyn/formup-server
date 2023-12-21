using ErrorOr;

namespace FormUp.Api.Features.v1.Workouts;

public static class WorkoutErrors
{
    public static Error WorkoutNotFound(Guid id)
    {
        return Error.NotFound(
            "WorkoutErrors:WorkoutNotFound",
            $"Workout with Id {id} was not found."
        );
    }

    public static Error UserNotFound(string id)
    {
        return Error.NotFound(
            "WorkoutErrors:UserNotFound",
            $"User with Id {id} has no logged workouts."
        );
    }
}