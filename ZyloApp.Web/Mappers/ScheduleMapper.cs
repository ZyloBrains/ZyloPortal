using AppTechnoSoft.Core.ViewModels;
using ZyloApp.Web.Data.Models;

namespace AppTechnoSoft.Core.Mappers;
public static class ScheduleMapper
{
    public static ScheduleViewModel ToViewModel(this ClassSchedule model)
    {
        var viewModel = new ScheduleViewModel
        {
            Id = model.Id,
            ClassStart = model.ClassStart,
            DurationHours = model.DurationHours,
            MeetingDetails = model.MeetingDetails,
            InstructorName = model.Instructor?.Name ?? "N/A",
            InstructorId = model.Instructor?.Id ?? default
        };

        return viewModel;
    }

    public static ClassSchedule ToModel(this ScheduleViewModel viewModel)
    {
        var model = new ClassSchedule
        {
            Id = viewModel.Id,
            ClassStart = viewModel.ClassStart,
            DurationHours = viewModel.DurationHours,
            MeetingDetails = viewModel.MeetingDetails,
            InstructorId = viewModel.InstructorId,
            BatchId = viewModel.BatchId,
            WidgetId = viewModel.WidgetId
        };

        return model;
    }
}
