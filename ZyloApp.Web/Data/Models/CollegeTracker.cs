
using ZyloApp.Web.Data.Enums;

namespace ZyloApp.Web.Data.Models;
public class CollegeTracker : BaseEntity
{
    public int Id { get; set; }
    public CollegeTrackerStatus Status { get; set; }
    public string Contact { get; set; }
    public string ContactPerson { get; set; }
    public string Notes { get; set; } = string.Empty;

    public int CollegeId { get; set; }
    public Organization? College { get; set; }
}
