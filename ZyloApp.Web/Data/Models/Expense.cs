using ZyloApp.Web.Data.Enums;

namespace ZyloApp.Web.Data.Models;
public class Expense : BaseEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime? Date { get; set; } = DateTime.UtcNow;
    public string Description { get; set; } = string.Empty;
    public float Amount { get; set; }
    public string? PaidBy { get; set; }
    public ExpenseType ExpenseType { get; set; }
    public Frequency Frequency { get; set; } = Frequency.OneTime;
    public string? BillImagePath { get; set; }
}
