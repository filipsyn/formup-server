namespace FormUp.Contracts.v1.Users;

public record CreateUserRequest
{
    public string Uid { get; set; }
    public string DisplayName { get; set; }
    public float Weight { get; set; }
    public float Height { get; set; }
}