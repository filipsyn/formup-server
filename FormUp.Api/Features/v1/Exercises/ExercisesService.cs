using ErrorOr;

using FormUp.Api.Common.Extensions.Mapping;
using FormUp.Api.Common.Models;
using FormUp.Api.Data;
using FormUp.Contracts.v1.Exercises;

using Microsoft.EntityFrameworkCore;

namespace FormUp.Api.Features.v1.Exercises;

/// <inheritdoc />
internal class ExercisesService : IExercisesService
{
    private readonly DataContext _context;
    private readonly ILogger<ExercisesService> _logger;

    public ExercisesService(DataContext context, ILogger<ExercisesService> logger)
    {
        _context = context;
        _logger = logger;
    }

    /// <inheritdoc />
    public async Task<ApiResponse<IList<ExerciseInfo>>> Get(
        string? searchedName = null,
        CancellationToken cancellationToken = default)
    {
        var exercises = _context.Exercises.AsQueryable();

        if (searchedName is not null)
        {
            exercises = exercises.Where(e => e.Name.Contains(searchedName));
        }

        IList<ExerciseInfo> result = await exercises
            .Select(e => e.ToExerciseInfo())
            .ToListAsync(cancellationToken);

        return ApiResponse<IList<ExerciseInfo>>.Ok(result);
    }

    /// <inheritdoc />
    public async Task<ErrorOr<ApiResponse<ExerciseInfo>>> GetById(Guid id,
        CancellationToken cancellationToken = default)
    {
        var exercise = await _context.Exercises.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

        if (exercise is null)
        {
            _logger.LogError("Exercise with ID {@Id} was not found", id);
            return ExerciseErrors.NotFound(id);
        }

        return ApiResponse<ExerciseInfo>.Ok(exercise.ToExerciseInfo());
    }
}