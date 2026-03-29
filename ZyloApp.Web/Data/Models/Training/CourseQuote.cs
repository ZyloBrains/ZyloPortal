namespace ZyloApp.Web.Data.Models;
public class CourseQuote
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public float PricePerUnit { get; set; }

    public List<Widget>? Modules { get; set; }
}
