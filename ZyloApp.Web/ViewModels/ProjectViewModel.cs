namespace AppTechnoSoft.Core.ViewModels;
public class ProjectViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Requirements { get; set; } = string.Empty;
    public string? RepoUrl { get; set; }
    public string? BoardUrl { get; set; }
    public bool ShowDetails { get; set; }
}
