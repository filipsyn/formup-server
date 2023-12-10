using ErrorOr;

namespace FormUp.Api.Features.v1.Gyms;

public static class GymErrors
{
    public static Error NotFound(Guid id)
    {
        return Error.NotFound(
            "GymErrors:NotFound",
            $"Gym with Id {id} was not found"
        );
    }
}