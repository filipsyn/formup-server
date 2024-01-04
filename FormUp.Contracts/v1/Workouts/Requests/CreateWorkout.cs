namespace FormUp.Contracts.v1.Workouts.Requests;

public record CreateWorkout
{
    public required string UserId { get; set; }
    public required DateTime At { get; set; } = DateTime.UtcNow;
    public string? Name { get; set; } = String.Empty;
    public string Description { get; set; } = string.Empty;
    public IList<CreateActivity> Activities { get; set; } = new List<CreateActivity>();
}