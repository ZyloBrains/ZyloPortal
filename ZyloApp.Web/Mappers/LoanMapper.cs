using ZyloApp.Web.Data.Models;
using AppTechnoSoft.Core.ViewModels;
using Humanizer;

namespace AppTechnoSoft.Core.Mappers;
public static class LoanMapper
{
    public static Loan ToModel(this LoanViewModel viewModel)
    {
        var model = new Loan
        {
            Id = viewModel.Id,
            Borrower = viewModel.Borrower,
            Lender = viewModel.Lender,
            IssueDate = viewModel.IssueDate,
            Principal = viewModel.Principal,
            InterestRate = viewModel.InterestRate,
            RepaymentDate = viewModel.RepaymentDate,
            CompanyLending = viewModel.CompanyLending,
            LastUpdated = viewModel?.LastUpdated,
            LastUpdatedBy = viewModel?.LastUpdatedBy ?? "N/A",

        };
  
        return model;
    }
    public static LoanViewModel ToViewModel(this Loan model)
    {
        var viewModel = new LoanViewModel
        {
            Id = model.Id,
            Borrower = model.Borrower,
            Lender = model.Lender,
            IssueDate = model.IssueDate,
            Principal = model.Principal,
            InterestRate = model.InterestRate,
            RepaymentDate = model.RepaymentDate,
            CompanyLending = model.CompanyLending,
            Created = model?.Created?.Humanize() ?? "N/A",
            CreatedBy = model?.CreatedBy ?? "N/A",
            GrandTotal = CalculateGrandTotal(model.Principal,model.InterestRate,model.IssueDate),

        };
        (viewModel.DaysElapsed, _) = CalculateDaysElapsed(model.IssueDate);

        viewModel.InterestAccumulated = viewModel.GrandTotal-viewModel.Principal;
        return viewModel;
    }
    
    public static List<LoanViewModel> ToViewModel(this List<Loan> models)
    => models.Select(x => x.ToViewModel()).ToList();

    private static (double, double) CalculateDaysElapsed(DateTime? issueDate)
    {
        if (issueDate == null)
        {
            return (0,0);
        }
        DateTime d1 = DateTime.Now;
        DateTime d2 = issueDate.Value;
        double elapsedDays = (d1 - d2).TotalDays;
        double elapsedYears = elapsedDays / 365;
        return (elapsedDays,elapsedYears);
    }
   
    private static double CalculateGrandTotal(float principal, float intrestRate, DateTime? issueDate)
    {

        if (issueDate == null)
        {
            return 0;
        }

        var elapsedTime = DateTime.UtcNow - issueDate;
        (_,double t ) = CalculateDaysElapsed(issueDate.Value);
        var r = (float)intrestRate / 100;
        var n = 12; //no of times interest is compounded per year.

        var total =(principal * Math.Pow((1 + (r / n)), n * t));
        return total;
    }
}
