namespace AppTechnoSoft.Core.ViewModels;
public class InvoiceEditViewModel
{
    public int Id { get; set; }
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
    public DateTime? InvoiceDate { get; set; } = DateTime.Now;
    public DateTime? DueDate { get; set; } = DateTime.Now.AddDays(30);
    public float? DiscountPercent { get; set; }
    public float? TaxPercent { get; set; }
    public string PaymentStatus { get; set; } = "Unpaid";
    public string? PaymentTerms { get; set; } = "Due within 30 days";
    public string? Notes { get; set; }
    public List<InvoiceItemEdit> Items { get; set; } = [];

    public float Subtotal => Items.Sum(i => i.Quantity * i.UnitPrice);
    public float DiscountAmount => Subtotal * (DiscountPercent ?? 0) / 100;
    public float TaxableAmount => Subtotal - DiscountAmount;
    public float TaxAmount => TaxableAmount * (TaxPercent ?? 0) / 100;
    public float GrandTotal => TaxableAmount + TaxAmount;
}

public class InvoiceItemEdit
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public string? Category { get; set; }
    public int Quantity { get; set; } = 1;
    public float UnitPrice { get; set; }
    public int SortOrder { get; set; }
    public float Total => Quantity * UnitPrice;
}
