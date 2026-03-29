using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;

namespace ZyloApp.Web.Extensions;

public static class StringExtensions
{
    public static string MakeUnique(this string value)
    {
        Random _rnd = new();
        var guid = _rnd.Next().ToString("x");
        var output = $"{value} {guid}";
        return output;
    }

    public static string ToEmail(this string userName)
    {
        if (userName is null or "")
            return string.Empty;

        var nameParts = userName.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var partsLength = nameParts.Length;
        var email = string.Empty;
        var domain = "@zylobrains.com";

        if (partsLength == 0)
        {
            email = string.Empty;
        }

        else if (partsLength == 1)
        {
            email = nameParts[0].ToLower() + domain;
        }
        else
        {
            email += $"{nameParts[0].ToLower()}.{nameParts[partsLength - 1].ToLower()}{domain}";
        }

        return email;
    }

    public static string ToDomain(this string value)
    {
        if (value is null or "")
            return string.Empty;

        if (!value.StartsWith("https://"))
        {
            if (value.StartsWith("www."))
            {
                value = value.Replace("www.", "https://");
            }
            else
            {
                value = "https://" + value;
            }
        }

        return value;
    }

    // Generates a URL-friendly slug from a title.
    public static string ToSlug(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return string.Empty;

        value = value.Trim().ToLowerInvariant();

        // remove diacritics
        var normalized = value.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();
        foreach (var ch in normalized)
        {
            var uc = CharUnicodeInfo.GetUnicodeCategory(ch);
            if (uc != UnicodeCategory.NonSpacingMark)
                sb.Append(ch);
        }

        var cleaned = sb.ToString().Normalize(NormalizationForm.FormC);

        // replace non-alphanumeric characters with '-'
        cleaned = Regex.Replace(cleaned, @"[^a-z0-9]+", "-");

        // trim '-' and collapse duplicates
        cleaned = Regex.Replace(cleaned, @"-+", "-").Trim('-');

        return cleaned;
    }

    // Replaces the id attribute of the first root <section>, <header> or <footer> element with the provided newId.
    // Handles HTML-encoded content (e.g. &lt;section ...&gt;) by decoding before modification
    // and re-encoding to preserve storage format.
    public static string ReplaceSectionId(this string html, string newId)
    {
        if (string.IsNullOrWhiteSpace(html))
            return html;

        if (string.IsNullOrWhiteSpace(newId))
            return html;

        // Detect if content is HTML-encoded (contains &lt; / &gt; but no raw '<')
        var wasEncoded = html.Contains("&lt;") || html.Contains("&gt;");

        // Decode for manipulation if necessary
        var working = wasEncoded ? WebUtility.HtmlDecode(html) : html;

        // Allow targeting section, header or footer
        var tagsPattern = "section|header|footer";

        // Pattern to find a <(section|header|footer) ... id="..."> (id may use single or double quotes)
        var patternWithId = new Regex($@"<(?<tag>{tagsPattern})\b(?<before>[^>]*)\bid\s*=\s*(?<quote>[""'])(?<id>.*?)\k<quote>(?<after>[^>]*)>", RegexOptions.IgnoreCase | RegexOptions.Singleline);

        string replaced;
        if (patternWithId.IsMatch(working))
        {
            replaced = patternWithId.Replace(working, match =>
            {
                // keep surrounding attributes but replace id value, preserve tag name case as-is
                var tag = match.Groups["tag"].Value;
                var before = match.Groups["before"].Value; // attributes before id (may be empty)
                var after = match.Groups["after"].Value;  // attributes after id (may be empty)
                return $"<{tag}{before} id=\"{newId}\"{after}>";
            }, 1); // only replace first occurrence
        }
        else
        {
            // If no id attribute present, insert id after the tag token for the first matching element
            var patternTagOpen = new Regex($@"<(?<tag>{tagsPattern})\b", RegexOptions.IgnoreCase);
            if (patternTagOpen.IsMatch(working))
            {
                replaced = patternTagOpen.Replace(working, m => $"<{m.Groups["tag"].Value} id=\"{newId}\"", 1);
            }
            else
            {
                // No matching tag found, nothing to change
                replaced = working;
            }
        }

        // Re-encode if original content was encoded
        return wasEncoded ? WebUtility.HtmlEncode(replaced) : replaced;
    }
}
