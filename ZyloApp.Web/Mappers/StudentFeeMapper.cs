using AppTechnoSoft.Core.ViewModels;
using ZyloApp.Web.Data.Models;

namespace AppTechnoSoft.Core.Mappers;
public static class StudentFeeMapper
{
    public static FinAccount ToModel(this StudentFeeViewModel viewModel)
    {
        var model = new FinAccount
        {
            Id = viewModel.Id,
            FeeAmount = viewModel.FeeAmount!.Value,
            Discount = viewModel.Discount!.Value,
            PaidAmount = viewModel.PaidAmount!.Value,
            StudentId = viewModel.StudentId,
            Created = viewModel.Added,
            CreatedBy = viewModel.AddedBy,
            Enabled = viewModel.Enabled
        };

        return model;
    }

    public static StudentFeeViewModel ToViewModel(this FinAccount model)
    {
        var viewModel = new StudentFeeViewModel
        {
            Id = model.Id,
            StudentId = model.Student.Id,
            ProfileImagePath = model.Student.ProfileImagePath,
            Batch = model.Student?.Batch?.Name ?? "No Batch",
            Name = model.Student.Name,
            Email = model.Student.Email,
            Phone = model.Student.Phone,
            Status = model.Student.Status,
            FeeAmount = model.FeeAmount,
            Discount = model.Discount,
            PaidAmount = model.PaidAmount,
            AddedBy = model.CreatedBy,
            Enabled = model.Enabled
        };

        return viewModel;
    }
}
