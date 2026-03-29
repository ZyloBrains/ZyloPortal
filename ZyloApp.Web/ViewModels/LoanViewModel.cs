namespace AppTechnoSoft.Core.ViewModels;
public class LoanViewModel
{
    public int Id { get; set; }
    public string Borrower { get; set; } = string.Empty;
    public string Lender { get; set; } = string.Empty;
    public DateTime? IssueDate { get; set; }
    public float Principal { get; set; }
    public float InterestRate { get; set; }
    public DateTime? RepaymentDate { get; set; }
    public bool CompanyLending { get; set; } = true;
    public string Created { get; set; } = string.Empty;
    public string CreatedBy { get; set; } = string.Empty;
    public double DaysElapsed { get; set; }
    public double InterestAccumulated { get; set; }
    public double GrandTotal { get; set; }
    public DateTime LastUpdated { get; set; }
    public string LastUpdatedBy { get; set; } = string.Empty;

}
