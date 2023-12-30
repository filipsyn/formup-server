using FormUp.Api.Common.Persistence;

using Microsoft.EntityFrameworkCore;

namespace FormUp.Api.Features.v1.Users;

[Index(nameof(Uid), IsUnique = true)]
public class UserEntity : BaseEntity
{
    public string Uid { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
}