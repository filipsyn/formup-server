using FormUp.Api.Features.v1.Exercises;
using FormUp.Api.Features.v1.Gyms;

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
        public const string GroupUrl = $"{Prefix}/exercises";

        public const string Get = "";

        public const string GetById = "{id:guid}";
    }
}