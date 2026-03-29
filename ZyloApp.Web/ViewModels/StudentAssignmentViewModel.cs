using ZyloApp.Web.Data.Enums;

namespace AppTechnoSoft.Core.ViewModels;
public class StudentAssignmentViewModel
{
    public int Id { get; set; }
    public AssignmentStatus Status { get; set; }
    public string? SolutionUrl { get; set; }
    public string? Comment { get; set; }
    public DateTime? Deadline { get; set; }
    public DateTime? ReturnDate { get; set; }
    public byte Evaluation { get; set; } = 0;  //Out of 100

    public int InstructorId { get; set; }
    public string InstructorName { get; set; } = string.Empty;
    public string StudentId { get; set; } = string.Empty;
    public string StudentName { get; set; } = string.Empty;
    public int AssignmentId { get; set; }
    public string AssignmentTitle { get; set; } = string.Empty;
    public string AssignmentBody { get; set; } = string.Empty;

    public bool ShowDetails { get; set; }
}
