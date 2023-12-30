using FormUp.Api.Features.v1.Users;
using FormUp.Contracts.v1.Users;

namespace FormUp.Api.Common.Extensions.Mapping;

public static class WeightLogEntityMappingExtensions
{
    public static WeightLogEntity ToEntity(this CreateWeightLogEntryRequest request, string uid)
    {
        return new WeightLogEntity { Value = request.Value, At = request.At, Uid = uid };
    }
}