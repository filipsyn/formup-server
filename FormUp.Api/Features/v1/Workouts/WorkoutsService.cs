using ErrorOr;

using FormUp.Api.Common.Config;
using FormUp.Api.Common.Extensions.Mapping;
using FormUp.Api.Common.Models;
using FormUp.Api.Data;
using FormUp.Contracts.v1.Workouts;

using Microsoft.EntityFrameworkCore;

namespace FormUp.Api.Features.v1.Workouts;

internal class WorkoutsService : IWorkoutsService
{
    private readonly DataContext _context;

    public WorkoutsService(DataContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<ErrorOr<ApiResponse<WorkoutInfo>>> GetById(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        var workout = await _context.Workouts.FirstOrDefaultAsync(w => w.Id == id, cancellationToken);
        if (workout is null)
        {
            return WorkoutErrors.WorkoutNotFound(id);
        }

        return ApiResponse<WorkoutInfo>.Ok(
            workout.ToWorkoutInfo(),
            $"Workout with ID {id} successfully retrieved.");
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