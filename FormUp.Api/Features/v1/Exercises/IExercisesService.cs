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
    Task<ApiResponse<IList<ExerciseInfo>>> Get(string? searchedName = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Retrieves exercise by its id.
    /// </summary>
    Task<ErrorOr<ApiResponse<ExerciseInfo>>> GetById(Guid id, CancellationToken cancellationToken = default);
}