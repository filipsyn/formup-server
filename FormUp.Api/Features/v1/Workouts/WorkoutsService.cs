using ErrorOr;

using FormUp.Api.Common.Config;
using FormUp.Api.Common.Extensions.Mapping;
using FormUp.Api.Common.Models;
using FormUp.Api.Data;
using FormUp.Contracts.v1.Workouts;
using FormUp.Contracts.v1.Workouts.Requests;

using Microsoft.EntityFrameworkCore;

namespace FormUp.Api.Features.v1.Workouts;

internal class WorkoutsService : IWorkoutsService
{
    private readonly DataContext _context;
    private readonly ILogger<WorkoutsService> _logger;

    public WorkoutsService(DataContext context, ILogger<WorkoutsService> logger)
    {
        _context = context;
        _logger = logger;
    }

    /// <inheritdoc />
    public async Task<ErrorOr<ApiResponse<WorkoutInfo>>> GetById(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        var workout = await _context.Workouts.FirstOrDefaultAsync(w => w.Id == id, cancellationToken);
        if (workout is null)
        {
            _logger.LogError("Workout with ID {ID} was not found", id);
            return WorkoutErrors.WorkoutNotFound(id);
        }

        return ApiResponse<WorkoutInfo>.Ok(
            workout.ToWorkoutInfo(),
            $"Workout with ID {id} successfully retrieved.");
    }


    /// <inheritdoc />
    public async Task<ErrorOr<ApiResponse<CreateWorkoutResponse>>> Create(CreateWorkout workout,
        CancellationToken cancellationToken = default)
    {
        var newWorkout = workout.ToEntity();

        try
        {
            await _context.Workouts.AddAsync(newWorkout, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }
        catch (DbUpdateException ex)
        {
            _logger.LogError(ex, "Unable to save newly created workout to database");
            return WorkoutErrors.CreationFailure;
        }
        catch (OperationCanceledException ex)
        {
            _logger.LogError(ex, "Attempt to add workout was canceled");
            return WorkoutErrors.CreationFailure;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unhandled exception has been raised during attempt to create new workout");
            return WorkoutErrors.CreationFailure;
        }

        return ApiResponse<Guid>.Created(new CreateWorkoutResponse(newWorkout.Id),
            "A workout has been successfully logged.");
    }

    /// <inheritdoc />
    public async Task<ErrorOr<ApiResponse<IList<WorkoutInfo>>>> Get(
        string userId,
        int skip = Constants.List.DefaultSkip,
        int take = Constants.List.DefaultPageSize,
        CancellationToken cancellationToken = default)
    {
        var usersWorkouts = _context.Workouts
            .Where(w => w.UserId == userId);

        if (!usersWorkouts.Any())
        {
            _logger.LogError("User with ID {ID} has no logged workouts", userId);
            return WorkoutErrors.UserNotFound(userId);
        }

        IList<WorkoutInfo> result = await usersWorkouts
            .OrderByDescending(w => w.At)
            .Take(take)
            .Skip(skip)
            .Include(w => w.Activities)
            .ThenInclude(a => a.Exercise)
            .Select(w => w.ToWorkoutInfo())
            .ToListAsync(cancellationToken);


        return ApiResponse<IList<WorkoutInfo>>.Ok(
            result,
            $"{result.Count} workouts were successfully retrieved",
            new ResponseMetaData(
                result.Count,
                take,
                usersWorkouts.Count()));
    }
}