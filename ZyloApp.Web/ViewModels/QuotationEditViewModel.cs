namespace AppTechnoSoft.Core.ViewModels;
public class QuotationEditViewModel
{
    public int Id { get; set; }
    public string ClientName { get; set; } = string.Empty;
    public string? ClientAddress { get; set; }
    public string? ClientEmail { get; set; }
    public string? ClientPhone { get; set; }
    public string ProjectName { get; set; } = string.Empty;
    public string Currency { get; set; } = "NPR";
    public DateTime? QuoteDate { get; set; } = DateTime.Now;
    public DateTime? ValidUntil { get; set; } = DateTime.Now.AddDays(30);
    public string? PaymentTerms { get; set; } = "50% advance, 50% on delivery";
    public string? Notes { get; set; }
    public float? DiscountPercent { get; set; }
    public float? TaxPercent { get; set; }
    public List<QuotationItemEdit> Items { get; set; } = [];

    public float Subtotal => Items.Sum(i => i.Quantity * i.UnitPrice);
    public float DiscountAmount => Subtotal * (DiscountPercent ?? 0) / 100;
    public float TaxableAmount => Subtotal - DiscountAmount;
    public float TaxAmount => TaxableAmount * (TaxPercent ?? 0) / 100;
    public float GrandTotal => TaxableAmount + TaxAmount;
}

public class QuotationItemEdit
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public string? Category { get; set; }
    public int Quantity { get; set; } = 1;
    public float UnitPrice { get; set; }
    public int SortOrder { get; set; }
    public float Total => Quantity * UnitPrice;
}
