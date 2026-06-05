using PasswordGenerator;

namespace ZyloApp.Web.Helpers;
public static class PwdGenerator
{
    public static string NewPassword(int length)
    {
        var pass = new Password()
            .LengthRequired(length);

        var password = pass.Next();
        return password;
    }

    public static string GenerateSecret()
    {
        var pass = new Password()
            .LengthRequired(48)
            .IncludeLowercase()
            .IncludeUppercase()
            .IncludeNumeric()
            .IncludeSpecial();

        return pass.Next();
    }
}
