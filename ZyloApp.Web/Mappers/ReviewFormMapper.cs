using ZyloApp.Web.Data.Models;
using AppTechnoSoft.Core.ViewModels;
using Humanizer;

namespace AppTechnoSoft.Core.Mappers;
public static class ReviewFormMapper
{
    public static ReviewFormViewModel ToViewModel(this ReviewForm model)
    {
        if (model is null)
            return new();

        var viewModel = new ReviewFormViewModel
        {
            Id = model.Id,
            Title = model.Title,
            Expiration = model.Expiration?.Humanize() ?? "None",
            InstructorId = model.InstructorId,
            InstructorName = model.Instructor?.Name ?? "None",
            InstructorRole = model.Instructor?.Role ?? "None",
            InstructorOrg = model.Instructor?.Organization ?? "None",
            TrainingId = model.TrainingId,
            TrainingName = model.Training?.Title ?? "None",
            TrainingOrgName = model.Training?.Organization?.Name ?? "None",
            Link = $"/ats/feedback/{model?.Id}"
        };

        var ratings = model?.ConsultantRatings ?? [];
        if (ratings.Count != 0)
        {
            viewModel.ResponseCount = ratings.Count;
            viewModel.CourseContentScoreAverage = ratings.Average(x => x.CourseContentScore);
            viewModel.TimeManagementScoreAverage = ratings.Average(x => x.TimeManagementScore);
            viewModel.GuidingApproachScoreAverage = ratings.Average(x => x.GuidingApproachScore);
            viewModel.AssignmentsQualityScoreAverage = ratings.Average(x => x.AssignmentsQualityScore);
            viewModel.RecommendToOthersCount = ratings.Count(x => x.RecommendToOthers);
            viewModel.Comments = ratings.Select(x => (x.Reviewer, x.Comments)).ToList();
        }

        return viewModel;
    }

    public static List<ReviewFormViewModel> ToViewModel(this List<ReviewForm> models) =>
        models.Select(x => x.ToViewModel()).ToList();
}
