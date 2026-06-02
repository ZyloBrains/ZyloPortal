using ZyloApp.Web.Data.Models;

namespace AppTechnoSoft.Core.ViewModels;
public class QuotationViewModel
{
    public int Id { get; set; }
    public string QuoteNumber { get; set; } = string.Empty;
    public string ClientName { get; set; } = string.Empty;
    public string ProjectName { get; set; } = string.Empty;
    public DateTime QuoteDate { get; set; }
    public string Currency { get; set; } = "NPR";
    public float TotalAmount { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public string Created { get; set; } = string.Empty;

    public static QuotationViewModel FromEntity(Quotation q) => new()
    {
        Id = q.Id,
        QuoteNumber = q.QuoteNumber,
        ClientName = q.ClientName,
        ProjectName = q.ProjectName,
        QuoteDate = q.QuoteDate,
        Currency = q.Currency,
        TotalAmount = q.Items.Sum(i => i.Quantity * i.UnitPrice),
        CreatedBy = q.CreatedBy ?? "",
        Created = q.Created?.ToString("yyyy-MM-dd") ?? ""
    };
}
