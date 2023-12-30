namespace FormUp.Contracts.v1.Users;

public record CreateUserRequest
{
    public string Uid { get; set; }
    public string DisplayName { get; set; }
}