using ErrorOr;

using FormUp.Api.Common.Config;
using FormUp.Api.Common.Extensions.Mapping;
using FormUp.Api.Common.Models;
using FormUp.Api.Data;
using FormUp.Contracts.v1.Gyms;

using Microsoft.EntityFrameworkCore;

namespace FormUp.Api.Features.v1.Gyms;

/// <inheritdoc />
internal class GymsService : IGymsService
{
    private readonly DataContext _context;
    private readonly ILogger<GymsService> _logger;

    /// <summary>
    ///     Creates new instance of <see cref="GymsService" />
    /// </summary>
    public GymsService(DataContext context, ILogger<GymsService> logger)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _logger = logger;
    }

    /// <inheritdoc />
    public async Task<ApiResponse<IList<GymInfo>>> Get(int skip = Constants.List.DefaultSkip,
        int take = Constants.List.DefaultPageSize,
        CancellationToken cancellationToken = default)
    {
        IList<GymInfo> gyms = await _context.Gyms
            .OrderBy(g => g.Name)
            .Skip(skip)
            .Take(take)
            .Select(g => g.ToGymInfo())
            .ToListAsync(cancellationToken);

        var count = await _context.Gyms.CountAsync(cancellationToken);

        return ApiResponse<IList<GymInfo>>.Ok(
            gyms,
            "Gyms were successfully retrieved.",
            new ResponseMetaData(gyms.Count, take, count));
    }

    /// <inheritdoc />
    public async Task<ErrorOr<ApiResponse<GymInfo>>> GetById(Guid id, CancellationToken cancellationToken = default)
    {
        var gym = await _context.Gyms
            .FirstOrDefaultAsync(g => g.Id == id, cancellationToken);

        if (gym is null)
        {
            _logger.LogError("Gym with ID {@Id} was not found", id);
            return GymErrors.NotFound(id);
        }

        _logger.LogDebug("Successfully retrieved {@Gym}", gym);
        return ApiResponse<GymInfo>.Ok(gym.ToGymInfo(), "Gym was successfully retrieved.");
    }
}