using ErrorOr;

using FormUp.Api.Common.Config;
using FormUp.Api.Common.Models;
using FormUp.Contracts.v1.Workouts;
using FormUp.Contracts.v1.Workouts.Requests;

namespace FormUp.Api.Features.v1.Workouts;

public interface IWorkoutsService
{
    /// <summary>
    ///     Retrieves list of workouts for user.
    /// </summary>
    /// <param name="userId">An ID of user whose workouts are retrieved.</param>
    /// <param name="skip">Number of items that should be skipped when retrieving list.</param>
    /// <param name="take">Number of retrieved items.</param>
    /// <param name="cancellationToken">A  <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
    Task<ErrorOr<ApiResponse<IList<WorkoutInfo>>>> Get(
        string userId,
        int skip = Constants.List.DefaultSkip,
        int take = Constants.List.DefaultPageSize,
        CancellationToken cancellationToken = default);


    /// <summary>
    ///     Retrieves information about a workout by its id.
    /// </summary>
    /// <param name="id">An ID of workout which should be retrieved.</param>
    /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
    Task<ErrorOr<ApiResponse<WorkoutInfo>>> GetById(Guid id, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Attempts to create new workout log.
    /// </summary>
    /// <param name="workout">Information about newly logged workout.</param>
    /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
    /// <returns>Id of newly created workout.</returns>
    Task<ErrorOr<Guid>> Create(CreateWorkout workout, CancellationToken cancellationToken = default);
}