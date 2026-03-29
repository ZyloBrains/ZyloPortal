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
}
