using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Caching.Memory;
using ZyloApp.Web.Data.Models;

namespace ZyloApp.Web.Components.Account;

public class PermissionClaimsTransformation : Microsoft.AspNetCore.Authentication.IClaimsTransformation
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IMemoryCache _cache;

    private static readonly MemoryCacheEntryOptions CacheOptions = new()
    {
        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5),
        SlidingExpiration = TimeSpan.FromMinutes(2)
    };

    public PermissionClaimsTransformation(
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IMemoryCache cache)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _cache = cache;
    }

    public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
    {
        if (principal.Identity is not { IsAuthenticated: true })
            return principal;

        var userId = principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
            return principal;

        var cacheKey = $"user_permissions_{userId}";
        if (_cache.TryGetValue<IReadOnlyList<Claim>>(cacheKey, out var cachedClaims) && cachedClaims is not null)
        {
            var identity = principal.Identity as ClaimsIdentity;
            if (identity is not null)
            {
                foreach (var claim in cachedClaims)
                {
                    if (!identity.HasClaim(c => c.Type == "Permission" && c.Value == claim.Value))
                    {
                        identity.AddClaim(claim);
                    }
                }
            }
            return principal;
        }

        var user = await _userManager.GetUserAsync(principal);
        if (user is null)
            return principal;

        var roles = await _userManager.GetRolesAsync(user);
        var permissionClaims = new List<Claim>();

        foreach (var roleName in roles)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role is null) continue;

            var roleClaims = await _roleManager.GetClaimsAsync(role);
            foreach (var claim in roleClaims.Where(c => c.Type == "Permission"))
            {
                if (!permissionClaims.Any(c => c.Value == claim.Value))
                {
                    permissionClaims.Add(claim);
                }
            }
        }

        _cache.Set(cacheKey, permissionClaims, CacheOptions);

        var identity2 = principal.Identity as ClaimsIdentity;
        if (identity2 is not null)
        {
            foreach (var claim in permissionClaims)
            {
                if (!identity2.HasClaim(c => c.Type == "Permission" && c.Value == claim.Value))
                {
                    identity2.AddClaim(claim);
                }
            }
        }

        return principal;
    }
}
