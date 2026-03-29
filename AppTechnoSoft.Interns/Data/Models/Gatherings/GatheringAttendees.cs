using ZyloApp.Web.Data.Models.Consultant;

namespace ZyloApp.Web.Data.Models.Gatherings;
public class GatheringAttendees
{
    public int Id { get; set; }

    public int GatheringCalendarId { get; set; }
    public GatheringCalendar? GatheringCalendar { get; set; }

    public int StudentId { get; set; }
    public Student? Student { get; set; }
}
