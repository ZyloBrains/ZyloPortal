namespace ZyloApp.Web.Data.Models;
public class TraineeTimeline
{
    public int Id { get; set; }
    public int? Order { get; set; }
    public string Date { get; set; } = string.Empty;
    public string Stage { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string? Details { get; set; }
}
