using System.ComponentModel.DataAnnotations;

namespace ZyloApp.Web.Data.Models;

public class ClientApplication
{
    [Key]
    public Guid Id { get; set; } = Guid.CreateVersion7();

    [Required, MaxLength(100)]
    public string ClientId { get; set; } = string.Empty;

    [Required, MaxLength(200)]
    public string DisplayName { get; set; } = string.Empty;

    [MaxLength(2000)]
    public string? RedirectUris { get; set; }

    [MaxLength(2000)]
    public string? PostLogoutRedirectUris { get; set; }

    [MaxLength(4000)]
    public string? AllowedScopes { get; set; }

    public bool RequireConsent { get; set; } = true;

    public bool Enabled { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public List<string> RedirectUriList =>
        (RedirectUris ?? "").Split('\n', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList();

    public List<string> PostLogoutRedirectUriList =>
        (PostLogoutRedirectUris ?? "").Split('\n', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList();

    public List<string> AllowedScopeList =>
        (AllowedScopes ?? "").Split('\n', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList();
}
