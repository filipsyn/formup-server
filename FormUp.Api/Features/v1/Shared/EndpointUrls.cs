using FormUp.Api.Features.v1.Exercises;
using FormUp.Api.Features.v1.Gyms;
using FormUp.Api.Features.v1.Workouts;

namespace FormUp.Api.Features.v1.Shared;

/// <summary>
///     Class containing URLs for endpoints
/// </summary>
/// <remarks>
///     Endpoint URLs are typically in following format:
///     <c>[host url]/[version]/[controller]</c>
/// </remarks>
internal static class EndpointUrls
{
    private const string Version = "v1";

    private const string Prefix = $"/{Version}";


    /// <summary>
    ///     Class containing URLs for endpoints on <see cref="GymsController" />
    /// </summary>
    public static class Gyms
    {
        /// <summary>
        ///     Common URL prefix for all endpoints in <see cref="GymsController" />
        /// </summary>
        public const string GroupUrl = $"{Prefix}/gyms";

        /// <summary>
        ///     URL for <see cref="GymsController.GetById" /> method
        /// </summary>
        public const string Get = "";

        public const string GetById = "{id:guid}";
    }

    /// <summary>
    ///     Class containing URLs for endpoints on <see cref="ExercisesController" />.
    /// </summary>
    public static class Exercises
    {
        /// <summary>
        ///     Common URL prefix for all endpoints in <see cref="ExercisesController" />.
        /// </summary>
        public const string GroupUrl = $"{Prefix}/exercises";

        /// <summary>
        ///     URL for <see cref="ExercisesController.Get" /> method.
        /// </summary>
        public const string Get = "";

        /// <summary>
        ///     URL for <see cref="ExercisesController.GetById" /> method.
        /// </summary>
        public const string GetById = "{id:guid}";
    }

    /// <summary>
    ///     Class containing URLs for endpoints on <see cref="WorkoutsController" />.
    /// </summary>
    public static class Workouts
    {
        /// <summary>
        ///     Common URL prefix for all endpoints in <see cref="WorkoutsController" />.
        /// </summary>
        public const string GroupUrl = $"{Prefix}/workouts";

        /// <summary>
        ///     URL for <see cref="WorkoutsController.Get" /> method.
        /// </summary>
        public const string Get = "{userId}";

        /// <summary>
        ///     URL for <see cref="WorkoutsController.GetById" /> method.
        /// </summary>
        public const string GetById = "{id:guid}";

        /// <summary>
        ///     URL for <see cref="WorkoutsController.Create" /> method.
        /// </summary>
        public const string Create = "";

        /// <summary>
        ///     URL for <see cref="WorkoutsController.Update" /> method.
        /// </summary>
        public const string Update = "{id:guid}";

        /// <summary>
        ///     URL for <see cref="WorkoutsController.Delete" /> method.
        /// </summary>
        public const string Delete = "{id:guid}";
    }

    public static class Users
    {
        public const string GroupUrl = $"{Prefix}/users";

        public const string GetByUid = "{uid}";

        public const string Create = "";

        public const string LogWeight = "{uid}/weight";

        public const string LogHeight = "{uid}/height";
    }
}