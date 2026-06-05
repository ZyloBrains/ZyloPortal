using ZyloApp.Web.Data.Models;

namespace AppTechnoSoft.Core.ViewModels;
public class InvoiceViewModel
{
    public int Id { get; set; }
    public string InvoiceNumber { get; set; } = string.Empty;
    public string ClientName { get; set; } = string.Empty;
    public DateTime InvoiceDate { get; set; }
    public string Currency { get; set; } = "NPR";
    public float TotalAmount { get; set; }
    public string PaymentStatus { get; set; } = "Unpaid";
    public string CreatedBy { get; set; } = string.Empty;
    public string Created { get; set; } = string.Empty;

    public static InvoiceViewModel FromEntity(Invoice inv) => new()
    {
        Id = inv.Id,
        InvoiceNumber = inv.InvoiceNumber,
        ClientName = inv.ClientName,
        InvoiceDate = inv.InvoiceDate,
        Currency = inv.Currency,
        TotalAmount = inv.Items.Sum(i => i.Quantity * i.UnitPrice),
        PaymentStatus = inv.PaymentStatus,
        CreatedBy = inv.CreatedBy ?? "",
        Created = inv.Created?.ToString("yyyy-MM-dd") ?? ""
    };
}
