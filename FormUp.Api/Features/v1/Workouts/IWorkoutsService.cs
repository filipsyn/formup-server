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
    Task<ErrorOr<ApiResponse<CreateWorkoutResponse>>> Create(CreateWorkout workout,
        CancellationToken cancellationToken = default);


    /// <summary>
    ///     Updates a workout with the specified ID.
    /// </summary>
    /// <param name="id">An ID of the workout to update.</param>
    /// <param name="request">The updated workout request.</param>
    /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
    Task<ErrorOr<ApiResponse>> Update(
        Guid id,
        UpdateWorkoutRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Deletes a workout specified by its ID.
    /// </summary>
    /// <param name="id">An ID of the workout to delete.</param>
    /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
    /// <returns></returns>
    Task<ErrorOr<ApiResponse>> Delete(
        Guid id,
        CancellationToken cancellationToken = default);
}