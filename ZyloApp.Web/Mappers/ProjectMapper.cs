using AppTechnoSoft.Core.ViewModels;
using ZyloApp.Web.Data.Models;

namespace AppTechnoSoft.Core.Mappers;
public static class ProjectMapper
{
    public static ProjectViewModel ToViewModel(this Project model)
    {
        var viewModel = new ProjectViewModel
        {
            Id = model.Id,
            Title = model.Title,
            BoardUrl = model.BoardUrl,
            RepoUrl = model.RepoUrl,
            Requirements = model.Requirements,
        };

        return viewModel;
    }

    public static Project ToModel(this ProjectViewModel viewModel)
    {
        var model = new Project
        {
            Id = viewModel.Id,
            Title = viewModel.Title,
            BoardUrl = viewModel.BoardUrl,
            RepoUrl = viewModel.RepoUrl,
            Requirements = viewModel.Requirements,
        };

        return model;
    }

    public static List<ProjectViewModel> ToViewModel(this List<Project> models) 
        => models.Select(x => x.ToViewModel()).ToList();
}
