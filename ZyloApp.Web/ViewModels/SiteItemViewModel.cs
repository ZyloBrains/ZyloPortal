namespace AppTechnoSoft.Core.ViewModels;
public record SiteItemViewModel(int Id, string LastUpdated = "", string UpdatedBy = "")
{
    public string Label { get; set; } = string.Empty;
    public bool Enabled { get; set; }
    public int Order { get; set; }
    public string? Content { get; set; }
    public bool Editing { get; set; }
    public List<SiteItemViewModel>? Widgets { get; set; }
}
