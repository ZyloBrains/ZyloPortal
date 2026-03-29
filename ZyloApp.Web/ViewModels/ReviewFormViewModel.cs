namespace AppTechnoSoft.Core.ViewModels;
public class ReviewFormViewModel
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = "";
    public string Expiration { get; set; } = string.Empty;

    public int InstructorId { get; set; }
    public string? InstructorName { get; set; }
    public string? InstructorOrg { get; set; }
    public string? InstructorRole { get; set; }

    public int TrainingId { get; set; }
    public string? TrainingName { get; set; }
    public string? TrainingOrgName { get; set; }
    public string Link { get; set; } = "";
    public int ResponseCount { get; set; }
    public int RecommendToOthersCount { get; set; }
    public double CourseContentScoreAverage { get; set; }
    public double TimeManagementScoreAverage { get; set; }
    public double GuidingApproachScoreAverage { get; set; }
    public double AssignmentsQualityScoreAverage { get; set; }
    public List<(string, string)> Comments { get; set; } = [];
}
