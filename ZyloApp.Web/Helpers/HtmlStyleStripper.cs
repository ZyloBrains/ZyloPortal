using System.Text.RegularExpressions;

namespace ZyloApp.Web.Helpers;

public static class HtmlStyleStripper
{
    private static readonly Regex StyleRegex = new Regex(@"\s*style\s*=\s*[""'][^""']*[""']", RegexOptions.IgnoreCase | RegexOptions.Compiled);

    public static string StripStyles(string? html)
    {
        if (string.IsNullOrEmpty(html))
            return string.Empty;

        return StyleRegex.Replace(html, "");
    }
}
