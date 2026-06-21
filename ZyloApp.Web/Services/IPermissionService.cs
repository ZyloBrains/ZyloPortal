using System.Security.Claims;

namespace ZyloApp.Web.Services;

public interface IPermissionService
{
    IReadOnlyList<string> GetAllPermissions();
    Task<IReadOnlyList<string>> GetRolePermissionsAsync(string roleId);
    Task SetRolePermissionsAsync(string roleId, IEnumerable<string> permissions);
    Task<bool> HasPermissionAsync(ClaimsPrincipal principal, string permission);
}
