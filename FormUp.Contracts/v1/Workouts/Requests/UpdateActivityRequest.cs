namespace FormUp.Contracts.v1.Workouts.Requests;

public record UpdateActivityRequest
{
    public required Guid ExerciseId { get; set; }
    public required int SetsCount { get; set; }
    public required int RepetitionsCount { get; set; }
    public required float Weight { get; set; }
    public string? Notes { get; set; }
}