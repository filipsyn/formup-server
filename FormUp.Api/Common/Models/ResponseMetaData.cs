namespace FormUp.Api.Common.Models;

/// <summary>
///     Groups metadata about response payload.
/// </summary>
/// <param name="RetrievedCount">Number of currently retrieved items in array.</param>
/// <param name="PageSize">Maximum number of retrieved items in payload.</param>
/// <param name="TotalCount">Count of all available items to be retrieved.</param>
/// <remarks>
///     This metadata describes payloads that are arrays. Providing this information simplifies support for pagination
///     on client side.
/// </remarks>
public record ResponseMetaData(int RetrievedCount, int PageSize, int TotalCount);