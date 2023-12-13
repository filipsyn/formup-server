using ErrorOr;

using FormUp.Api.Common.Config;
using FormUp.Api.Common.Models;
using FormUp.Contracts.v1.Gyms;

namespace FormUp.Api.Features.v1.Gyms;

/// <summary>
///     Service providing business logic related to <see cref="GymEntity" />.
/// </summary>
public interface IGymsService
{
    /// <summary>
    ///     Retrieves list of Gyms
    /// </summary>
    /// <remarks>
    ///     This method implements support for pagination. Default sizes of pages are specified in
    ///     <see cref="Constants.List" />.
    /// </remarks>
    public Task<ApiResponse<IList<GymInfo>>> Get(
        int skip = Constants.List.DefaultSkip,
        int take = Constants.List.DefaultPageSize,
        CancellationToken cancellationToken = default);

    /// <summary>Retrieves a specific <see cref="GymInfo" /> by its <see cref="GymEntity.Id" />.</summary>
    public Task<ErrorOr<ApiResponse<GymInfo>>> Get(Guid id, CancellationToken cancellationToken = default);
}