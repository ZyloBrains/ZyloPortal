namespace ZyloApp.Web.Data.Models;
public class TechProgram : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Affliation { get; set; } = string.Empty;
}
