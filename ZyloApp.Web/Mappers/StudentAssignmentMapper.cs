using AppTechnoSoft.Core.ViewModels;
using ZyloApp.Web.Data.Models;
using Humanizer;

namespace AppTechnoSoft.Core.Mappers;
public static class StudentAssignmentMapper
{
    public static StudentAssignmentViewModel ToViewModel(this StudentAssignment model)
    {
        var viewModel = new StudentAssignmentViewModel
        {
            Id = model.Id,
            Deadline = model.Deadline,
            ReturnDate = model.ReturnDate,
            SolutionUrl = model.SolutionUrl,
            Comment = model.Comment,
            Evaluation = model.Evaluation,
            Status = model.Status,
            StudentId = model.StudentId,
            StudentName = model.Student?.Name ?? "N/A",
            InstructorId = model.InstructorId,
            InstructorName = model.Instructor?.Name ?? "N/A",
            AssignmentId = model.AssignmentId,
            AssignmentTitle = model.Assignment?.Title ?? "N/A",
            AssignmentBody = model.Assignment?.Details ?? "N/A"
        };

        return viewModel;
    }

    public static StudentAssignment ToModel(this StudentAssignmentViewModel viewModel)
    {
        var model = new StudentAssignment
        {
            Id = viewModel.Id,
            SolutionUrl = viewModel.SolutionUrl,
            Comment = viewModel.Comment,
            Evaluation = viewModel.Evaluation,
            Status = viewModel.Status,
            StudentId = viewModel.StudentId,
            InstructorId = viewModel.InstructorId,
            AssignmentId = viewModel.AssignmentId
        };

        return model;
    }

    public static List<StudentAssignmentViewModel> ToViewModel(this List<StudentAssignment> models)
        => models.Select(x => x.ToViewModel()).ToList();
}
