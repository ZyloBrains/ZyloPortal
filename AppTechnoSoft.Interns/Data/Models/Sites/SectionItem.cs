namespace ZyloApp.Web.Data.Models.Sites;
public class SectionItem : BaseEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public int Order { get; set; }
    public bool Enabled { get; set; } = true;

    public int SectionId { get; set; }
    public Section Section { get; set; }
}
