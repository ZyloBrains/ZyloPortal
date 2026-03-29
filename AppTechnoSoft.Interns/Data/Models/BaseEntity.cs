namespace ZyloApp.Web.Data.Models;
public class BaseEntity
{    
    public DateTime? Created { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? LastUpdated { get; set; }
    public string? LastUpdatedBy { get; set; }

    public BaseEntity AddLastUpdatedStamps(string? lastUpdateUserName)
    {
        LastUpdated = DateTime.UtcNow;
        LastUpdatedBy = lastUpdateUserName;
        return this;
    }

    public BaseEntity AddCreatedStamps(string? createUserName)
    {
        Created = DateTime.UtcNow;
        CreatedBy = createUserName;
        return this;
    }
}
