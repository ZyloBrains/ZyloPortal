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
}
