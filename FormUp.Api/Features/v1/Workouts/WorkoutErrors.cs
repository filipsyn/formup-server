using ErrorOr;

namespace FormUp.Api.Features.v1.Workouts;

public static class WorkoutErrors
{
    private const string FeaturePrefix = nameof(WorkoutErrors);

    public static Error CreationFailure => Error.Failure("WorkoutErrors", "Unable to log workout");

    public static Error WorkoutNotFound(Guid id)
    {
        return Error.NotFound(
            $"{FeaturePrefix}:WorkoutNotFound",
            $"Workout with Id {id} was not found."
        );
    }

    public static Error UserNotFound(string id)
    {
        return Error.NotFound(
            $"{FeaturePrefix}:UserNotFound",
            $"User with Id {id} has no logged workouts."
        );
    }
}