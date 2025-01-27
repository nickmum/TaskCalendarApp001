namespace TaskCalendarApp001.Core.Models;

public enum TaskStatus
{
    NotStarted,
    InProgress,
    Completed,
    Cancelled
}

public class TaskItem
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskStatus Status { get; set; }

    // Future: Add properties for task categories, priority, reminders
}