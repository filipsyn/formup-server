using FormUp.Api.Features.v1.Users;
using FormUp.Contracts.v1.Users;

namespace FormUp.Api.Common.Extensions.Mapping;

public static class UserEntityMappingExtensions
{
    public static UserInfoResponse ToUserInfoResponse(
        this UserEntity entity,
        WeightLogEntity? weight = null,
        HeightLogEntity? height = null)
    {
        return new UserInfoResponse
        {
            Uid = entity.Uid, DisplayName = entity.DisplayName, Height = height?.Value, Weight = weight?.Value
        };
    }

    public static UserEntity ToEntity(this CreateUserRequest request)
    {
        return new UserEntity { Uid = request.Uid, DisplayName = request.DisplayName };
    }
}