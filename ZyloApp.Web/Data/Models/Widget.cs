namespace ZyloApp.Web.Data.Models;
public class Widget : BaseEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string HtmlContent { get; set; } = string.Empty;

    public List<Tag>? Tags { get; set; } = [];
}
