namespace ZyloApp.Web.Data.Models;
public class Assignment: BaseEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Details { get; set; }

    public int ModuleId { get; set; }
    public Widget? Module { get; set; }
}
