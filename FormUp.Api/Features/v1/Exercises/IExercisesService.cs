using ErrorOr;

using FormUp.Api.Common.Models;
using FormUp.Contracts.v1.Exercises;

namespace FormUp.Api.Features.v1.Exercises;

/// <summary>
///     Service providing business logic related to the <see cref="ExerciseEntity" />.
/// </summary>
public interface IExercisesService
{
    /// <summary>
    ///     Retrieves list of all exercises
    /// </summary>
    /// <param name="searchedName">An optional parameter which allows filtering by name of the exercise.</param>
    /// <param name="cancellationToken">A  <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
    Task<ApiResponse<IList<ExerciseInfo>>> Get(string? searchedName = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Retrieves exercise by its id.
    /// </summary>
    Task<ErrorOr<ApiResponse<ExerciseInfo>>> GetById(Guid id, CancellationToken cancellationToken = default);
}