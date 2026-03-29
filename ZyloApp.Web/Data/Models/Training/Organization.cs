using ZyloApp.Web.Data.Enums;

namespace ZyloApp.Web.Data.Models;
public class Organization
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;
    public OrganizationType OrganizationType { get; set; } = OrganizationType.Private;
}
