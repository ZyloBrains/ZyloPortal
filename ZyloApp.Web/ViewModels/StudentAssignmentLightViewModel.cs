using ZyloApp.Web.Data.Enums;

namespace AppTechnoSoft.Core.ViewModels;
public record StudentAssignmentLightViewModel(
    string Title,
    string Module,
    DateTime? ReturnDate,
    DateTime? Deadline,
    byte Score,
    AssignmentStatus Status)
{
}
