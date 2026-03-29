namespace ZyloApp.Web.Data.Models;
public class Team : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;    
    public string? Avatar { get; set; }

    public int? BatchId { get; set; }
    public Batch? Batch { get; set; }

    public int? ProjectId { get; set; }
    public Project? Project { get; set; }

    public List<Student>? Students { get; set; }
}
