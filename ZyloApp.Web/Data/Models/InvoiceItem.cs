namespace ZyloApp.Web.Data.Models;
public class InvoiceItem
{
    public int Id { get; set; }
    public int InvoiceId { get; set; }
    public string Description { get; set; } = string.Empty;
    public string? Category { get; set; }
    public int Quantity { get; set; } = 1;
    public float UnitPrice { get; set; }
    public int SortOrder { get; set; }
    public Invoice? Invoice { get; set; }
}
