using ErrorOr;

using FormUp.Api.Common.Models;
using FormUp.Contracts.v1.Users;

namespace FormUp.Api.Features.v1.Users;

public interface IUsersService
{
    Task<ErrorOr<ApiResponse<UserInfoResponse>>> GetByUid(string uid, CancellationToken cancellationToken = default);

    Task<ApiResponse<IList<WeightLogResponse>>> GetWeights(
        string uid,
        DateTime? from = null,
        DateTime? to = null,
        CancellationToken cancellationToken = default
    );

    Task<ApiResponse<IList<HeightLogResponse>>> GetHeights(
        string uid,
        DateTime? from = null,
        DateTime? to = null,
        CancellationToken cancellationToken = default);

    Task<ErrorOr<ApiResponse<CreateUserResponse>>> Create(
        CreateUserRequest request,
        CancellationToken cancellationToken = default);

    Task<ErrorOr<ApiResponse>> LogWeight(
        string uid,
        CreateWeightLogEntryRequest request,
        CancellationToken cancellationToken = default
    );

    Task<ErrorOr<ApiResponse>> LogHeight(
        string uid,
        CreateHeightLogEntryRequest request,
        CancellationToken cancellationToken = default
    );

    Task<ErrorOr<ApiResponse>> Delete(string uid, CancellationToken cancellationToken = default);
}