using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Caching.Memory;
using ZyloApp.Web.Data.Constants;
using ZyloApp.Web.Data.Models;

namespace ZyloApp.Web.Services;

public class PermissionService : IPermissionService
{
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IMemoryCache _cache;

    private const string CacheKeyPrefix = "role_permissions_";
    private static readonly MemoryCacheEntryOptions CacheOptions = new()
    {
        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5),
        SlidingExpiration = TimeSpan.FromMinutes(2)
    };

    public PermissionService(
        RoleManager<IdentityRole> roleManager,
        UserManager<ApplicationUser> userManager,
        IMemoryCache cache)
    {
        _roleManager = roleManager;
        _userManager = userManager;
        _cache = cache;
    }

    public IReadOnlyList<string> GetAllPermissions() => Permission.All;

    public async Task<IReadOnlyList<string>> GetRolePermissionsAsync(string roleId)
    {
        var cacheKey = CacheKeyPrefix + roleId;
        if (_cache.TryGetValue<IReadOnlyList<string>>(cacheKey, out var cached) && cached is not null)
            return cached;

        var role = await _roleManager.FindByIdAsync(roleId);
        if (role is null)
            return [];

        var claims = await _roleManager.GetClaimsAsync(role);
        var permissions = claims
            .Where(c => c.Type == "Permission")
            .Select(c => c.Value)
            .ToList()
            .AsReadOnly();

        _cache.Set(cacheKey, permissions, CacheOptions);
        return permissions;
    }

    public async Task SetRolePermissionsAsync(string roleId, IEnumerable<string> permissions)
    {
        var role = await _roleManager.FindByIdAsync(roleId);
        if (role is null)
            return;

        var existingClaims = await _roleManager.GetClaimsAsync(role);
        var existingPermissions = existingClaims.Where(c => c.Type == "Permission").ToList();

        // Remove permissions that are no longer assigned
        foreach (var claim in existingPermissions)
        {
            if (!permissions.Contains(claim.Value))
            {
                await _roleManager.RemoveClaimAsync(role, claim);
            }
        }

        // Add newly assigned permissions
        foreach (var permission in permissions)
        {
            if (existingPermissions.All(c => c.Value != permission))
            {
                await _roleManager.AddClaimAsync(role, new Claim("Permission", permission));
            }
        }

        // Invalidate cache
        _cache.Remove(CacheKeyPrefix + roleId);
    }

    public async Task<bool> HasPermissionAsync(ClaimsPrincipal principal, string permission)
    {
        if (principal is null)
            return false;

        // Check directly on the principal first
        if (principal.HasClaim(c => c.Type == "Permission" && c.Value == permission))
            return true;

        // Fallback: resolve from roles via DB
        var user = await _userManager.GetUserAsync(principal);
        if (user is null)
            return false;

        var roles = await _userManager.GetRolesAsync(user);
        foreach (var roleName in roles)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role is null) continue;

            var claims = await _roleManager.GetClaimsAsync(role);
            if (claims.Any(c => c.Type == "Permission" && c.Value == permission))
                return true;
        }

        return false;
    }
}
