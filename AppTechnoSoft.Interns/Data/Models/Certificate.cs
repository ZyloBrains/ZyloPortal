using ZyloApp.Web.Data.Models.Gatherings;

namespace ZyloApp.Web.Data.Models;
public class Certificate
{
    public Certificate() => Id = Guid.NewGuid();

    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string EventDate { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Signataire1 { get; set; } = string.Empty;
    public string Signataire1SignPath { get; set; } = string.Empty;
    public string Signataire2 { get; set; } = string.Empty;
    public string Signataire2SignPath { get; set; } = string.Empty;

    public DateTime IssueDate { get; set; }

    public Guid AttendeeId { get; set; }
    public Attendee? Attendee { get; set; }
}
