namespace ZyloApp.Web.Data.Models;
public class Invoice : BaseEntity
{
    public int Id { get; set; }
    public string InvoiceNumber { get; set; } = string.Empty;
    public string ClientName { get; set; } = string.Empty;
    public string? ClientAddress { get; set; }
    public string? ClientEmail { get; set; }
    public string? ClientPhone { get; set; }
    public string CompanyName { get; set; } = "ZyloBrains";
    public string? CompanyAddress { get; set; }
    public string? CompanyPhone { get; set; }
    public string? CompanyEmail { get; set; }
    public string? CompanyPan { get; set; }
    public string? BankName { get; set; }
    public string? BankAccountNumber { get; set; }
    public string? BankAccountHolder { get; set; }
    public string Currency { get; set; } = "NPR";
    public DateTime InvoiceDate { get; set; }
    public DateTime? DueDate { get; set; }
    public float? DiscountPercent { get; set; }
    public float? TaxPercent { get; set; }
    public string PaymentStatus { get; set; } = "Unpaid";
    public string? PaymentTerms { get; set; }
    public string? Notes { get; set; }
    public List<InvoiceItem> Items { get; set; } = [];
}
