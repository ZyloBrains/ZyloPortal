namespace ZyloApp.Web.Data.Models.Gatherings;
public class Gathering : BaseEntity
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Agenda { get; set; } = string.Empty;
    public float Quote { get; set; } = 20000;
    public bool QuotePerAttendee { get; set; } = false;
    public int MaxAttendees { get; set; } = 100;
    public GatheringType Type { get; set; } = GatheringType.Workshop;

    public override string ToString()
    {
        return $"{Type} - {Title}";
    }
}
