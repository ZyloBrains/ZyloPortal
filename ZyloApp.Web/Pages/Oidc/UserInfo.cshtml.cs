using ZyloApp.Web.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenIddict.Server.AspNetCore;
using static OpenIddict.Abstractions.OpenIddictConstants;

namespace ZyloApp.Web.Pages.Oidc;

[Authorize(AuthenticationSchemes = OpenIddictServerAspNetCoreDefaults.AuthenticationScheme)]
public class UserInfoModel : PageModel
{
    private readonly UserManager<ApplicationUser> _userManager;

    public UserInfoModel(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
            return Challenge();

        var claims = new Dictionary<string, object>
        {
            [Claims.Subject] = user.Id
        };

        if (User.HasClaim(Claims.Scope, Scopes.Profile))
        {
            if (!string.IsNullOrEmpty(user.UserName))
                claims[Claims.Name] = user.UserName;
        }

        if (User.HasClaim(Claims.Scope, Scopes.Email))
        {
            if (!string.IsNullOrEmpty(user.Email))
                claims[Claims.Email] = user.Email;
        }

        if (User.HasClaim(Claims.Scope, Scopes.Roles))
        {
            var roles = await _userManager.GetRolesAsync(user);
            claims["roles"] = roles;
        }

        return new JsonResult(claims);
    }
}
