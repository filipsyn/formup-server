using ErrorOr;

using FormUp.Api.Common.Extensions.Mapping;
using FormUp.Api.Common.Models;
using FormUp.Api.Data;
using FormUp.Contracts.v1.Users;

using Microsoft.EntityFrameworkCore;

namespace FormUp.Api.Features.v1.Users;

public class UserService : IUsersService
{
    private readonly DataContext _context;
    private readonly ILogger<UserService> _logger;

    public UserService(DataContext context, ILogger<UserService> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<ErrorOr<ApiResponse<UserInfoResponse>>> GetByUid(
        string uid,
        CancellationToken cancellationToken = default)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Uid == uid, cancellationToken);
        if (user is null)
        {
            _logger.LogError("User with id {Uid} was not found", uid);
            return UserErrors.NotFound;
        }

        var height = await _context.Heights
            .OrderByDescending(h => h.At)
            .FirstOrDefaultAsync(h => h.Uid == uid, cancellationToken);

        var weight = await _context.Weights
            .OrderByDescending(w => w.At)
            .FirstOrDefaultAsync(w => w.Uid == uid, cancellationToken);

        var result = user.ToUserInfoResponse(weight, height);

        return ApiResponse<UserInfoResponse>.Ok(result,
            $"Successfully retrieved info about user with uid {uid}");
    }

    public async Task<ApiResponse<IList<WeightLogResponse>>> GetWeights(string uid, DateTime? from = null,
        DateTime? to = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ErrorOr<ApiResponse<IList<HeightLogResponse>>>> GetHeights(string uid, DateTime? from = null,
        DateTime? to = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ErrorOr<ApiResponse<string>>> Create(CreateUserRequest request,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ErrorOr<ApiResponse>> LogWeight(string uid, CreateWeightLogRequest request,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ErrorOr<ApiResponse>> LogHeight(string uid, CreateHeightLogRequest request,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ErrorOr<ApiResponse>> Delete(string uid, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}