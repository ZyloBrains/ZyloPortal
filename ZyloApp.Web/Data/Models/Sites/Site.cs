namespace ZyloApp.Web.Data.Models.Sites;
public class Site: BaseEntity
{
    public Site() => Id = Guid.CreateVersion7().ToString();
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Domain { get; set; }
    public string? Client { get; set; }
    public string? Content { get; set; }

    public List<Section>? Sections { get; set; }
}
