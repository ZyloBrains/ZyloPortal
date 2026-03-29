using System.ComponentModel.DataAnnotations;

namespace AppTechnoSoft.Core.ViewModels;
public class AttendanceViewModel
{
    public int Id { get; set; }
    public DateTime? Date { get; set; }
    public TimeSpan? PunchIn { get; set; }
    public TimeSpan? PunchOut { get; set; }

    [Required(ErrorMessage = "Please add what you did for selected date")]
    public string Task { get; set; } = string.Empty;
    
    public string StudentId { get; set; } = string.Empty;
}
