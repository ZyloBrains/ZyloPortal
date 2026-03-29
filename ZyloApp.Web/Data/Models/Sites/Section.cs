namespace ZyloApp.Web.Data.Models.Sites;

public class Section
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Content { get; set; }
    public int Order { get; set; }
    public bool Enabled { get; set; } = true;
    public string? Slug { get; set; }

    public string? SiteId { get; set; }
    public Site? Site { get; set; }

    public List<SectionItem>? SectionItems { get; set; }
}
