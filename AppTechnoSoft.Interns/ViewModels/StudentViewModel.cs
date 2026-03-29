using ZyloApp.Web.Data.Enums;
using Microsoft.AspNetCore.Components.Forms;

namespace AppTechnoSoft.Core.ViewModels;

public class StudentViewModel
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public GeneralProgrammingExperience GeneralProgramming { get; set; } = GeneralProgrammingExperience.None;
    public WebExperience WebExperience { get; set; } = WebExperience.None;
    public DbExperience DbExperience { get; set; } = DbExperience.None;
    public DateTime? FormSubmitted { get; set; } = DateTime.UtcNow;
    public Status Status { get; set; } = Status.Applied;
    public ApplicantType ApplicantType { get; set; } = ApplicantType.StudentInternship;
    public TrainingTrack TrainingTrack { get; set; } = TrainingTrack.None;    
    public IBrowserFile? ProfileImage { get; set; }
    public string? ProfileImagePath { get; set; }

    public int? CollegeId { get; set; }
    public string CollegeName { get; set; } = string.Empty;

    public int? TechProgramId { get; set; }
    public string ProgramName { get; set; } = string.Empty;

    public int? TeamId { get; set; }
    public string TeamName { get; set; } = string.Empty;

    public int? BatchId { get; set; }
    public string BatchName { get; set; } = string.Empty;

    public string? ApplicationUserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public bool UserCreated => ApplicationUserId is not null;

    public DateTime? Created { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? LastUpdated { get; set; }
    public string? LastUpdatedBy { get; set; }
}
