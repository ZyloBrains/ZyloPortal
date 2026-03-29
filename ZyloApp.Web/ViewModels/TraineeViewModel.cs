using ZyloApp.Web.Data.Enums;

namespace AppTechnoSoft.Core.ViewModels;
public record TraineeViewModel(string Id, string Name, int? BatchId, Status Status, string AvatarPath, string Program, string College);
