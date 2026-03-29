using ZyloApp.Web.Data.Enums;

namespace AppTechnoSoft.Core.ViewModels;
public class StudentFeeViewModel
{
    public int Id { get; set; }
    public string StudentId { get; set; } = string.Empty;
    public string? ProfileImagePath { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Batch { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Status Status { get; set; }
    public float? FeeAmount { get; set; }
    public float? Discount { get; set; }
    public float? PaidAmount { get; set; }
    public string? AddedBy { get; set; }
    public DateTime? Added { get; set; }
    public bool Enabled { get; set; }
    public float? DiscountAmount => FeeAmount * Discount / 100.0f;
    public float? TotalAmount => FeeAmount - DiscountAmount;
    public float? RemainingAmount => TotalAmount - PaidAmount;
}
