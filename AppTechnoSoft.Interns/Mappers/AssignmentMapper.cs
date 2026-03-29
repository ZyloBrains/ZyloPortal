using AppTechnoSoft.Core.ViewModels;
using ZyloApp.Web.Data.Models;
using ZyloApp.Web.Extensions;
using Humanizer;

namespace AppTechnoSoft.Core.Mappers;
public static class AssignmentMapper
{
    public static AssignmentViewModel ToViewModel(this Assignment model)
    {
        var viewModel = new AssignmentViewModel
        {
            Id = model.Id,
            Title = model.Title,
            Details = model.Details,
            ModuleName = model.Module?.Description ?? "N/A",
            Created = model?.Created?.Humanize() ?? "N/A",
            CreatedBy = model?.CreatedBy ?? "N/A"
        };

        return viewModel;
    }

    public static Assignment ToModel(this AssignmentViewModel viewModel)
    {
        var model = new Assignment
        {
            Id = viewModel.Id,
            Title = viewModel.Title,
            Details = viewModel.Details
        };

        return model;
    }

    public static List<AssignmentViewModel> ToViewModel(this List<Assignment> models)
        => models.Select(x => x.ToViewModel()).ToList();
}
