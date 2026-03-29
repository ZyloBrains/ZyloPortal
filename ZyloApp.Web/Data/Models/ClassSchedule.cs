using ZyloApp.Web.Data.Models.Consultant;

namespace ZyloApp.Web.Data.Models;
public class ClassSchedule: BaseEntity
{
    public int Id { get; set; }
    public DateTime ClassStart { get; set; }
    public float DurationHours { get; set; } = 1.0f;
    public string? MeetingDetails { get; set; }

    public Batch? Batch { get; set; }
    public int BatchId { get; set; }

    public Widget? Module { get; set; }
    public int? WidgetId { get; set; }

    public Instructor? Instructor { get; set; }
    public int? InstructorId { get; set; }
}
