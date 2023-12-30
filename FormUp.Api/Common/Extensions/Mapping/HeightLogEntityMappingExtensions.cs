using FormUp.Api.Features.v1.Users;
using FormUp.Contracts.v1.Users;

namespace FormUp.Api.Common.Extensions.Mapping;

public static class HeightLogEntityMappingExtensions
{
    public static HeightLogEntity ToEntity(this CreateHeightLogEntryRequest request, string uid)
    {
        return new HeightLogEntity { Value = request.Value, At = request.At, Uid = uid };
    }

    public static HeightLogResponse ToHeightLogResponse(this HeightLogEntity entity)
    {
        return new HeightLogResponse { Value = entity.Value, At = entity.At };
    }
}