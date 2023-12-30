using ErrorOr;

namespace FormUp.Api.Features.v1.Users;

public static class UserErrors
{
    private const string FeaturePrefix = nameof(UserErrors);

    public static Error NotFound => Error.NotFound($"{FeaturePrefix}:{nameof(NotFound)}", "User was not found");

    public static Error CreationFailure =>
        Error.Failure($"{FeaturePrefix}:{nameof(CreationFailure)}", "Unable to create user");

    public static Error WeightLogFailure =>
        Error.Failure($"{FeaturePrefix}:{nameof(WeightLogFailure)}", "Could not add weight log entry");

    public static Error HeightLogFailure =>
        Error.Failure($"{FeaturePrefix}:{nameof(HeightLogFailure)}", "Could not add height log entry");
}