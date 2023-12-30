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

    Task<ErrorOr<ApiResponse<IList<HeightLogResponse>>>> GetHeights(
        string uid,
        DateTime? from = null,
        DateTime? to = null,
        CancellationToken cancellationToken = default
    );

    Task<ErrorOr<ApiResponse<string>>> Create(CreateUserRequest request, CancellationToken cancellationToken = default);

    Task<ErrorOr<ApiResponse>> LogWeight(
        string uid,
        CreateWeightLogRequest request,
        CancellationToken cancellationToken = default
    );

    Task<ErrorOr<ApiResponse>> LogHeight(
        string uid,
        CreateHeightLogRequest request,
        CancellationToken cancellationToken = default
    );

    Task<ErrorOr<ApiResponse>> Delete(string uid, CancellationToken cancellationToken = default);
}