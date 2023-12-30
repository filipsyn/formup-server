using FormUp.Api.Common.Persistence;

using Microsoft.EntityFrameworkCore;

namespace FormUp.Api.Features.v1.Users;

[Index(nameof(Uid))]
public class HeightLogEntity : BaseEntity
{
    public string Uid { get; set; } = string.Empty;
    public float Value { get; set; }
    public DateTime At { get; set; } = DateTime.Now;
}