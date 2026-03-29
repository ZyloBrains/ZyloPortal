using ZyloApp.Web.Data.Enums;
using ZyloApp.Web.Data.Models;

namespace AppTechnoSoft.Core.ViewModels;
public record ProfessionalViewModel(string Id, 
    string Name, 
    string AvatarPath,
    Status Status,
    string Training = "", 
    string Organization = "",
    float TrainingHours = 0.0f,
    StudentAssignment[]? Assignments = null,
    Project[]? Projects = null);
