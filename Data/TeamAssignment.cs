namespace ConquestOfLords.Data;

public class TeamAssignment
{
    public int Id { get; set; }
    public string AssignmentText { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}