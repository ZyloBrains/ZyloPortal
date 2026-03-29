namespace ZyloApp.Web.Data.Models;
public class Batch: BaseEntity
{
    public int Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Name { get; set; } = string.Empty;

    public int? TrainingId { get; set; }
    public Training? Training { get; set; }

    public List<Team>? Teams { get; set; }
    public List<Student>? Students { get; set; }
}
