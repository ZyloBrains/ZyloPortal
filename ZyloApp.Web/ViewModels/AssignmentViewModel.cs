namespace AppTechnoSoft.Core.ViewModels;
public class AssignmentViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Details { get; set; }
    public string ModuleName { get; set; } = string.Empty;
    public string Created { get; set; } = string.Empty;
    public string CreatedBy { get; set; } = string.Empty;
    public bool ShowDetails { get; set; }
}
