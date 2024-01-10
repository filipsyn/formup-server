using ErrorOr;

namespace FormUp.Api.Features.v1.Workouts;

public static class WorkoutErrors
{
    private const string FeaturePrefix = nameof(WorkoutErrors);

    public static Error CreationFailure => Error.Failure($"{FeaturePrefix}:CreationFailure", "Unable to log workout.");

    public static Error UpdateFailure => Error.Failure($"{FeaturePrefix}:UpdateFailure", "Unable to update workout.");

    public static Error DeletionFailure =>
        Error.Failure($"{FeaturePrefix}:DeletionFailure", "Unable to delete workout.");

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
            $"User with Id {id} was not found."
        );
    }
}