using ErrorOr;

namespace FormUp.Api.Features.v1.Exercises;

public static class ExerciseErrors
{
    public static Error NotFound(Guid id)
    {
        return Error.NotFound(
            "ExerciseErrors:NotFound",
            $"Exercise with Id {id} was not found."
        );
    }
}