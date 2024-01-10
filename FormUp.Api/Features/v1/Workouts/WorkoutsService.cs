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
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Uid == userId);

        if (user is null)
        {
            _logger.LogError("User with ID {ID} was not found", userId);
            return WorkoutErrors.UserNotFound(userId);
        }

        IList<WorkoutInfo> result = await _context.Workouts
            .Where(w => w.UserId == userId)
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
                result.Count()));
    }

    /// <inheritdoc />
    public async Task<ErrorOr<ApiResponse>> Update(
        Guid id,
        UpdateWorkoutRequest request,
        CancellationToken cancellationToken = default)
    {
        var workout = await _context.Workouts
            .Include(w => w.Activities)
            .FirstOrDefaultAsync(w => w.Id == id, cancellationToken);

        if (workout is null)
        {
            _logger.LogError("Workout with ID {ID} not found", id);
            return WorkoutErrors.WorkoutNotFound(id);
        }

        workout.ApplyUpdate(request);

        int changedRowsCounts;

        try
        {
            _context.Workouts.Update(workout);
            changedRowsCounts = await _context.SaveChangesAsync(cancellationToken);
        }
        catch (DbUpdateException ex)
        {
            _logger.LogError(ex, "Updated workout entity could not be saved into the database");
            return WorkoutErrors.UpdateFailure;
        }

        if (changedRowsCounts == 0)
        {
            _logger.LogError("No changes were made to the underlying entity");
            return WorkoutErrors.UpdateFailure;
        }

        return ApiResponse.Created($"Workout with ID {workout.Id} and its activities were successfully updated");
    }

    /// <inheritdoc />
    public async Task<ErrorOr<ApiResponse>> Delete(Guid id, CancellationToken cancellationToken = default)
    {
        var workout = await _context.Workouts.FirstOrDefaultAsync(w => w.Id == id, cancellationToken);
        if (workout is null)
        {
            _logger.LogWarning("Could not find workout with ID {@ID}", id);
            return WorkoutErrors.WorkoutNotFound(id);
        }

        _context.Workouts.Remove(workout);

        int changedRowsCount;

        try
        {
            changedRowsCount = await _context.SaveChangesAsync(cancellationToken);
        }
        catch (DbUpdateException ex)
        {
            _logger.LogError(ex, "Deletion of workout couldn't be processed on the database level");
            return WorkoutErrors.DeletionFailure;
        }

        if (changedRowsCount is not 1)
        {
            return WorkoutErrors.DeletionFailure;
        }

        return ApiResponse.NoContent();
    }
}