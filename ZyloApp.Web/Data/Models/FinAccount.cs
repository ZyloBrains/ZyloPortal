namespace ZyloApp.Web.Data.Models;
public class FinAccount : BaseEntity
{
    public int Id { get; set; }
    public float FeeAmount { get; set; }
    public float Discount { get; set; } = 0.0f;
    public float PaidAmount { get; set; }
    public bool Enabled { get; set; } = true;

    public string StudentId { get; set; } = null!;
    public Student Student { get; set; } = null!;
}
