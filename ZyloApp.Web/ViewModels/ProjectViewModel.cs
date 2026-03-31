using ZyloApp.Web.Data.Enums;

namespace AppTechnoSoft.Core.ViewModels;
public class ProjectViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Requirements { get; set; } = string.Empty;
    public string? RepoUrl { get; set; }
    public string? BoardUrl { get; set; }
    public float AllocatedBudget { get; set; }
    public float? SpentBudget { get; set; }
    public ProjectProgressStatus ProgressStatus { get; set; } = ProjectProgressStatus.NotStarted;
    public ProjectBusinessDomain BusinessDomain { get; set; } = ProjectBusinessDomain.Other;
    
    public string? LeadId { get; set; }
    public string? LeadName { get; set; }
    
    public int OrganizationId { get; set; }
    public string? OrganizationName { get; set; }
    
    public bool ShowDetails { get; set; }
}
