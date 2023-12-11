using ErrorOr;

using FormUp.Api.Common.Config;
using FormUp.Api.Common.Extensions.Mapping;
using FormUp.Api.Data;
using FormUp.Contracts.v1.Gyms;

using Microsoft.EntityFrameworkCore;

namespace FormUp.Api.Features.v1.Gyms;

/// <inheritdoc />
internal class GymsService : IGymsService
{
    private readonly DataContext _context;

    /// <summary>
    ///     Creates new instance of <see cref="GymsService" />
    /// </summary>
    public GymsService(DataContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    /// <inheritdoc />
    public async Task<IList<GymInfo>> Get(int skip = Constants.List.DefaultSkip,
        int take = Constants.List.DefaultPageSize,
        CancellationToken cancellationToken = default)
    {
        return await _context.Gyms
            .OrderBy(g => g.Name)
            .Skip(skip)
            .Take(take)
            .Include(g => g.Location)
            .Select(g => g.ToGymInfo())
            .ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ErrorOr<GymInfo>> Get(Guid id, CancellationToken cancellationToken = default)
    {
        GymEntity? gym = await _context.Gyms
            .Include(g => g.Location)
            .FirstOrDefaultAsync(g => g.Id == id, cancellationToken);

        if (gym is null)
        {
            return GymErrors.NotFound(id);
        }

        return gym.ToGymInfo();
    }
}