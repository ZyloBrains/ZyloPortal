using ZyloApp.Web.Data.Enums;

namespace AppTechnoSoft.Core.ViewModels;
public record StudentLightViewModel(string Name, string UserId, string ProfilePath, Status? Status = null, string TeamName="", string BatchName="");

