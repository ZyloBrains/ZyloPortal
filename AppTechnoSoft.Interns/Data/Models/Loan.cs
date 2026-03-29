namespace ZyloApp.Web.Data.Models;
public class Loan: BaseEntity
{
    public int Id { get; set; }
    public string Borrower { get; set; } = string.Empty;
    public string Lender { get; set; } = string.Empty;
    public DateTime? IssueDate { get; set; }
    public float Principal { get; set; }
    public float InterestRate { get; set; }
    public DateTime? RepaymentDate { get; set; }
    public bool CompanyLending { get; set; } = true;
}
