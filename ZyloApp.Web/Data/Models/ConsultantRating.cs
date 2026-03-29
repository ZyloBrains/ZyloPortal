namespace ZyloApp.Web.Data.Models;
public class ConsultantRating
{
    public int Id { get; set; }
    public bool IsAnonymous { get; set; } = false;
    public bool RecommendToOthers { get; set; } = true;
    public byte CourseContentScore { get; set; }
    public byte TimeManagementScore { get; set; }
    public byte GuidingApproachScore { get; set; }
    public byte AssignmentsQualityScore { get; set; }

    public string Reviewer { get; set; } = string.Empty;
    public string Comments { get; set; } = string.Empty;

    public string ReviewFormId { get; set; }
    public ReviewForm ReviewForm { get; set; }
}
