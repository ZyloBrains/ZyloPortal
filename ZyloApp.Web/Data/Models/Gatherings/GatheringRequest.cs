namespace ZyloApp.Web.Data.Models.Gatherings;
public class GatheringRequest
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateTime When { get; set; }
    public DateTime RequestedDate { get; set; }

    public Guid GatheringId { get; set; }
    public Gathering? Gathering { get; set; }

    public int OrganizationId { get; set; }
    public Organization? Organization { get; set; }
}
    