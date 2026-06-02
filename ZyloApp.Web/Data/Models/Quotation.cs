namespace ZyloApp.Web.Data.Models;
public class Quotation : BaseEntity
{
    public int Id { get; set; }
    public string QuoteNumber { get; set; } = string.Empty;
    public string ClientName { get; set; } = string.Empty;
    public string? ClientAddress { get; set; }
    public string? ClientEmail { get; set; }
    public string? ClientPhone { get; set; }
    public string ProjectName { get; set; } = string.Empty;
    public string Currency { get; set; } = "NPR";
    public DateTime QuoteDate { get; set; }
    public DateTime? ValidUntil { get; set; }
    public string? PaymentTerms { get; set; }
    public string? Notes { get; set; }
    public float? DiscountPercent { get; set; }
    public float? TaxPercent { get; set; }
    public List<QuotationItem> Items { get; set; } = [];
}
