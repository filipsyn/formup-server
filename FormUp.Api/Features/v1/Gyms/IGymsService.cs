using ErrorOr;
using FormUp.Api.Common.Config;

namespace FormUp.Api.Features.v1.Gyms;

/// <summary>
///     Service providing business logic related to <see cref="GymEntity" />.
/// </summary>
public interface IGymsService
{
    /// <summary>
    ///     Retrieves list of all Gyms
    /// </summary>
    /// <remarks>
    ///     This method implements support for pagination. Default sizes of pages are specified in
    ///     <see cref="Constants.List" />.
    /// </remarks>
    public Task<IList<GymEntity>> Get(
        int skip = Constants.List.DefaultSkip,
        int take = Constants.List.DefaultPageSize,
        CancellationToken cancellationToken = default);

    /// <summary>Retrieves a specific <see cref="GymEntity" /> by its <see cref="GymEntity.Id" />.</summary>
    public Task<ErrorOr<GymEntity>> Get(Guid id, CancellationToken cancellationToken = default);
}