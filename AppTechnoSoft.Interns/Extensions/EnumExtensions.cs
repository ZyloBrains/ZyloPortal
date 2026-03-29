using ZyloApp.Web.Data.Enums;

namespace ZyloApp.Web.Extensions;
public static class EnumExtensions
{
    public static string GetGeneralProgText(this GeneralProgrammingExperience experience) => experience switch
    {
        GeneralProgrammingExperience.None => "Know nothing about programming",
        GeneralProgrammingExperience.KnowBasicProgrammingLogic => "Know basic logic (console read/write, conditions, loops etc.)",
        GeneralProgrammingExperience.ConfidenceOnALanguage => "Can code on any of C/C++/C#/Java/Python/JavaScript/etc.",
        GeneralProgrammingExperience.ConfidenceOnMultipleLanguageParadigms => "Can code on two or more programming languages",
        _ => string.Empty
    };

    public static string GetWebExperienceText(this WebExperience experience) => experience switch
    {
        WebExperience.None => "No knowledge at all",
        WebExperience.LittleHtmlCssAndJs => "Know little Html, CSS and JS",
        WebExperience.DevelopedHobbyWebApp => "Developed small hobby app",
        WebExperience.DevelopedCommercialApp => "Developed Commercial app for users",
        _ => string.Empty
    };

    public static string GetDbExperienceText(this DbExperience experience) => experience switch
    {
        DbExperience.None => "No knowledge at all",
        DbExperience.KnowLittleSql => "Know little SQL and relational databases",
        DbExperience.ComfortableWithSql => "Comfortable with SQL and relational databases",
        DbExperience.DesignedDbForApp => "Desinged database (schemas, constraints etc.) for app",
        _ => string.Empty
    };
}
