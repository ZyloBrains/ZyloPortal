using ZyloApp.Web.Data.Models.Consultant;

namespace ZyloApp.Web.Data.Models.Gatherings;
public class GatheringCalendar
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int DurationHoursPerDay { get; set; } = 2;
    public GatheringStatus Status { get; set; }

    public DateTime RequestedDate { get; set; }
    public string RequestedBy { get; set; } = string.Empty;

    public Guid GatheringId { get; set; }
    public Gathering? Gathering { get; set; }

    public int OrganizationId { get; set; }
    public Organization? Organization { get; set; }

    public List<Instructor> Consultants { get; set; } = [];
}
