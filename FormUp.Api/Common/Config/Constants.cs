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

    /// <summary>
    ///     Declares constants related to translation.
    /// </summary>
    public static class Translation
    {
        /// <summary>
        ///     Specifies identifier for english translation.
        /// </summary>
        public const string English = "en";

        /// <summary>
        ///     Specifies identifier for czech translation.
        /// </summary>
        public const string Czech = "cs";


        /// <summary>
        ///     Stores identifier for default language translation.
        /// </summary>
        /// <remarks>This application uses English as its default translation.</remarks>
        public const string Default = English;

        /// <summary>
        ///     Specifies name of header that declares language of response.
        /// </summary>
        public const string Header = "Content-Language";
    }
}