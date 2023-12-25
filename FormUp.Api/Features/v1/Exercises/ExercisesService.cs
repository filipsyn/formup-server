using ErrorOr;

using FormUp.Api.Common.Extensions.Mapping;
using FormUp.Api.Common.Models;
using FormUp.Api.Data;
using FormUp.Api.Features.v1.Translations;
using FormUp.Contracts.v1.Exercises;

using Microsoft.EntityFrameworkCore;

namespace FormUp.Api.Features.v1.Exercises;

/// <inheritdoc />
internal class ExercisesService : IExercisesService
{
    private readonly DataContext _context;
    private readonly ILogger<ExercisesService> _logger;
    private readonly ITranslationService _translationService;

    public ExercisesService(
        DataContext context,
        ILogger<ExercisesService> logger,
        ITranslationService translationService)
    {
        _context = context;
        _logger = logger;
        _translationService = translationService;
    }

    /// <inheritdoc />
    public async Task<ApiResponse<IList<ExerciseInfo>>> Get(
        string? searchedName = null,
        string language = "en",
        CancellationToken cancellationToken = default)
    {
        var exercises = await _context.Exercises.ToListAsync(cancellationToken);

        foreach (var exercise in exercises)
        {
            await _translationService.ApplyTranslation(exercise, e => nameof(e.Name), language);
        }

        if (searchedName is not null)
        {
            exercises = exercises
                .Where(e => e.Name.Contains(searchedName, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        IList<ExerciseInfo> result = exercises
            .Select(e => e.ToExerciseInfo())
            .ToList();

        return ApiResponse<IList<ExerciseInfo>>.Ok(result);
    }

    /// <inheritdoc />
    public async Task<ErrorOr<ApiResponse<ExerciseInfo>>> GetById(
        Guid id,
        string language = "en",
        CancellationToken cancellationToken = default)
    {
        var exercise = await _context.Exercises.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

        if (exercise is null)
        {
            _logger.LogError("Exercise with ID {@Id} was not found", id);
            return ExerciseErrors.NotFound(id);
        }

        await _translationService.ApplyTranslation(exercise, e => nameof(e.Name), language);

        return ApiResponse<ExerciseInfo>.Ok(exercise.ToExerciseInfo());
    }
}