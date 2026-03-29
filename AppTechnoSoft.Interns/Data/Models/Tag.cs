namespace ZyloApp.Web.Data.Models;
public class Tag: BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string ColorCode { get; set; } = string.Empty;

    public List<Widget>? Widgets { get; set; } = [];
}
