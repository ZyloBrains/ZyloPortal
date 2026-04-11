using AppTechnoSoft.Core.ViewModels;
using ZyloApp.Web.Data.Models;

namespace AppTechnoSoft.Core.Mappers;
public static class StudentMapper
{
    public static StudentViewModel ToViewModel(this Student model)
    {
        var viewModel = new StudentViewModel
        {
            Id = model.Id,
            Name = model.Name,
            Phone = model.Phone,
            Email = model.Email,
            Status = model.Status,
            ApplicantType = model.ApplicantType,
            TrainingTrack = model.TrainingTrack,
            ProfileImagePath = model.ProfileImagePath,
            CollegeId = model.CollegeId,
            CollegeName = model.College?.Name ?? "None",
            TechProgramId = model.TechProgramId,
            ProgramName = model.TechProgram?.Name ?? "None",
            TeamId = model.TeamId,
            TeamName = model.Team?.Name ?? "None",
            BatchId = model.BatchId,
            BatchName = model.Batch?.Name ?? "None",
            ApplicationUserId = model.ApplicationUserId,
            UserName = model.User?.UserName ?? "None",
            FormSubmitted = model.FormSubmitted,
            Created = model.Created,
            CreatedBy = model.CreatedBy,
            LastUpdated = model.LastUpdated,
            LastUpdatedBy = model.LastUpdatedBy
        };

        return viewModel;
    }

    public static List<StudentViewModel> ToViewModel(this List<Student> models)
        => [.. models.Select(x => x.ToViewModel())];
}
