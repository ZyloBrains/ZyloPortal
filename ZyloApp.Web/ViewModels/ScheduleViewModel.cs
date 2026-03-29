namespace AppTechnoSoft.Core.ViewModels;
public class ScheduleViewModel
{
    public int Id { get; set; }
    public DateTime ClassStart { get; set; }
    public float DurationHours { get; set; }
    public string? MeetingDetails { get; set; }

    public string BatchName { get; set; } = string.Empty;
    public int BatchId { get; set; }

    public string ModuleDescription { get; set; } = string.Empty;
    public int? WidgetId { get; set; }

    public string InstructorName { get; set; } = string.Empty;
    public int? InstructorId { get; set; }
}
