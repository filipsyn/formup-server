using ErrorOr;

namespace FormUp.Api.Features.v1.Users;

public static class UserErrors
{
    private const string FeaturePrefix = nameof(UserErrors);

    public static Error NotFound => Error.NotFound($"{FeaturePrefix}:NotFound", "User was not found");
}