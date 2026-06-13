using Microsoft.AspNetCore.Identity;
using ZyloApp.Web.Data.Enums;

namespace ZyloApp.Web.Data.Models;
public class ApplicationUser : IdentityUser
{
    public string? FullName { get; set; }
    public string? Address { get; set; }
    public Gender? Gender { get; set; }
    public DateTime? Dob { get; set; }
    public string? Country { get; set; }
}
