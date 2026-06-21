using System.Security.Claims;
using System.Security.Principal;

namespace ZyloApp.Web.Extensions;
public static class IdentityExtensions
{
    public static string GetUserId(this ClaimsPrincipal? principal) =>
        principal?.FindFirst(u => u.Type.Contains("nameidentifier"))?.Value ?? string.Empty;

    public static string GetUserName(this ClaimsPrincipal? principal) =>
        principal?.Identity?.Name ?? string.Empty;

    public static IEnumerable<string> GetRoles(this ClaimsPrincipal principal) =>
        principal.Identities.SelectMany(i =>
        {
            return i.Claims
                .Where(c => c.Type == i.RoleClaimType)
                .Select(c => c.Value)
                .ToList();
        });

    public static bool IsInAnyRole(this ClaimsPrincipal user, params string[] roles)
    {
        if (user == null || roles == null || roles.Length == 0)
            return false;

        return roles.Any(user.IsInRole);
    }

    public static bool IsInAllRoles(this ClaimsPrincipal user, params string[] roles)
    {
        if (user == null || roles == null || roles.Length == 0)
            return false;

        return roles.All(user.IsInRole);
    }

    public static bool HasPermission(this ClaimsPrincipal principal, string permission)
    {
        if (principal is null)
            return false;

        return principal.HasClaim(c => c.Type == "Permission" && c.Value == permission);
    }

    public static bool HasAnyPermission(this ClaimsPrincipal principal, params string[] permissions)
    {
        if (principal is null || permissions is null || permissions.Length == 0)
            return false;

        return permissions.Any(p => principal.HasPermission(p));
    }

    public static bool HasAllPermissions(this ClaimsPrincipal principal, params string[] permissions)
    {
        if (principal is null || permissions is null || permissions.Length == 0)
            return false;

        return permissions.All(p => principal.HasPermission(p));
    }
}
