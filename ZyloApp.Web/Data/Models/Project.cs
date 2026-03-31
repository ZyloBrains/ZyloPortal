using ZyloApp.Web.Data.Enums;

namespace ZyloApp.Web.Data.Models;
public class Project: BaseEntity
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

    public int OrganizationId { get; set; }
    public Organization? Organization { get; set; }

    public string? LeadId { get; set; }
    public ApplicationUser? Lead { get; set; }
}
