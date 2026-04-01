using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZyloApp.Web.Data.Models.Gatherings;
public class Attendee
{
    public Attendee() => Id = Guid.CreateVersion7();

    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    [NotMapped]
    public IBrowserFile? ProfileImage { get; set; }
    public string? ProfileImagePath { get; set; }

    public int? OrganizationId { get; set; }
    public Organization? Organization { get; set; }

    public List<Certificate>? Certificates { get; set; }
}
