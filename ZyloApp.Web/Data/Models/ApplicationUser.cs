using Microsoft.AspNetCore.Identity;

namespace ZyloApp.Web.Data.Models;

public class ApplicationUser : IdentityUser
{
    public Guid? ClientId { get; set; }
    public ClientApplication? ClientApplication { get; set; }
}
