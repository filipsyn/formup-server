namespace FormUp.Api.Common.Config;

/// <summary>
///     Declares all of project's constants
/// </summary>
public static class Constants
{
    /// <summary>
    ///     Declares constants related to producing list of information
    /// </summary>
    public static class List
    {
        /// <summary>
        ///     Specifies how many items should be fetched in one request
        /// </summary>
        public const int DefaultPageSize = 20;

        /// <summary>
        ///     Specifies how many items should be skipped by default when requesting list of information
        /// </summary>
        public const int DefaultSkip = 0;
    }
}