using ZyloApp.Web.Data.Enums;

namespace AppTechnoSoft.Core.ViewModels;
public class AccountViewModel
{
    public string Title { get; set; } = string.Empty;
    public float? Credit { get; set; }
    public float? Debit { get; set; }
    public float? Balance { get; set; }
    public string Notes { get; set; } = string.Empty;
    public DateTime? Date { get; set; }
    public string MonthYear => Date?.ToString("MMMM yyyy") ?? "No Date";
    public FundStatus Status { get; set; } = FundStatus.None;
}
